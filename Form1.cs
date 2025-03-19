using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace BooksLibrary
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=replacement_name\SQLEXPRESS;Database=testTables;Trusted_Connection=True;TrustServerCertificate=True";
        SqlDataAdapter? adapter;
        DataSet? ds;
        //SqlCommandBuilder cb;
        public string operation = string.Empty;
        public Book? b;

        public Form1()
        {
            InitializeComponent();
            connectionString = connectionString.Replace("replacement_name", Environment.MachineName);
            booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadDataFromDb(connectionString);

            EditToc edittoc = new EditToc(this);
            edittoc.FormClosed += (sender, e) => Close();

            edittoc.ShowDialog();
        }
        async void ReadDataFromDb(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync(); //открываем соединение
                    adapter = new SqlDataAdapter("select * from Books", conn); //делаем запрос
                    ds = new DataSet(); //создаём набор данных
                    adapter.Fill(ds); //заполняем набор из адаптера
                    booksTable.DataSource = ds.Tables[0]; //устанавливаем источник datagridview
                    booksTable.Columns[0].ReadOnly = true; //запрет редактирования id
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                    Debug.WriteLine(conn.State);
                }
            }
        }
        private void addBook_Click(object sender, EventArgs e)
        {
            b = new Book();
            BookView bookView = new BookView(this);

            if (bookView.ShowDialog() == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "[addBook]",
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@name", b.currentName);
                    cmd.Parameters.AddWithValue("@autor", b.currentAutor);
                    cmd.Parameters.AddWithValue("@year", b.currentYear);
                    cmd.Parameters.AddWithValue("@toc", b.currentToc);

                    SqlParameter outParam = new SqlParameter
                    {
                        ParameterName = "@message",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 255,
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outParam);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    Debug.WriteLine(outParam.Value);

                    adapter = new SqlDataAdapter("select * from Books", conn); //делаем запрос
                    ds = new DataSet(); //создаём набор данных
                    adapter.Fill(ds); //заполняем набор из адаптера
                    booksTable.DataSource = ds.Tables[0]; //устанавливаем источник datagridview
                    booksTable.Columns[0].ReadOnly = true; //запрет редактирования id
                }

                //вариант без процедуры

                //DataRow r = ds.Tables[0].NewRow();
                //r["Name"] = b.currentName;
                //r["Autor"] = b.currentAutor;
                //r["Year"] = b.currentYear;
                //r["TableOfContents"] = b.currentToc;

                //ds.Tables[0].Rows.Add(r);

                //using (SqlConnection conn = new SqlConnection(connectionString))
                //{
                //    conn.Open();
                //    adapter = new SqlDataAdapter("select * from Books", conn); //делаем запрос
                //    cb = new SqlCommandBuilder(adapter); //передаём адаптер в command builder
                //    int i = adapter.Update(ds); //обновляем набор данных
                //    Debug.WriteLine(i);
                //}
            }
        }
        private void editBook_Click(object sender, EventArgs e)
        {
            b = new Book();
            b.currentName = booksTable.SelectedRows[0].Cells[1].Value.ToString()!;
            b.currentAutor = booksTable.SelectedRows[0].Cells[2].Value.ToString()!;
            b.currentYear = (int)booksTable.SelectedRows[0].Cells[3].Value;
            b.currentToc = booksTable.SelectedRows[0].Cells[4].Value.ToString()!;

            int bookId = Convert.ToInt32(booksTable.SelectedRows[0].Cells[0].Value);

            BookView bookView = new BookView(this); //открываем форму для резактирования

            if (bookView.ShowDialog() == DialogResult.OK)
            {
                booksTable.SelectedRows[0].Cells[1].Value = b.currentName; //переносим полученные значения в datagridview
                booksTable.SelectedRows[0].Cells[2].Value = b.currentAutor;
                booksTable.SelectedRows[0].Cells[3].Value = b.currentYear;
                booksTable.SelectedRows[0].Cells[4].Value = b.currentToc;

                booksTable.Refresh();
                booksTable.Update();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "[editBook]",
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@id", bookId);
                    cmd.Parameters.AddWithValue("@name", b.currentName);
                    cmd.Parameters.AddWithValue("@autor", b.currentAutor);
                    cmd.Parameters.AddWithValue("@year", b.currentYear);
                    cmd.Parameters.AddWithValue("@toc", b.currentToc);

                    SqlParameter outParam = new SqlParameter
                    {
                        ParameterName = "@message",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 255,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParam);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    Debug.WriteLine(outParam.Value);

                    //вариант без процедуры

                    //conn.Open(); //открываем соединение
                    //adapter = new SqlDataAdapter("select * from Books", conn); //делаем запрос
                    //cb = new SqlCommandBuilder(adapter); //передаём адаптер в command builder
                    //int i = adapter.Update(ds); //обновляем набор данных
                    //Debug.WriteLine(i); 
                }
            }
        }
        private void removeBook_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(booksTable.SelectedRows[0].Cells[0].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "[removeBook]",
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@id", bookId);

                SqlParameter outParam = new SqlParameter
                {
                    ParameterName = "@message",
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 255,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);
                conn.Open();
                cmd.ExecuteNonQuery();

                Debug.WriteLine(outParam.Value);

                adapter = new SqlDataAdapter("select * from Books", conn); //делаем запрос
                ds = new DataSet(); //создаём набор данных
                adapter.Fill(ds); //заполняем набор из адаптера
                booksTable.DataSource = ds.Tables[0]; //устанавливаем источник datagridview
                booksTable.Columns[0].ReadOnly = true; //запрет редактирования id
            }
        }
        private void editTocBtn_Click(object sender, EventArgs e)
        {
            EditToc tocView = new EditToc(this); //открываем форму для резактирования
            if (tocView.ShowDialog() == DialogResult.OK)
            { 
                
            }            
        }
    }
    public class Book
    {
        public string currentName { get; set; } = string.Empty;
        public string currentAutor { get; set; } = string.Empty;
        public int currentYear { get; set; } = 0;
        public string currentToc { get; set; } = string.Empty;
    }
}