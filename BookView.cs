using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BooksLibrary
{
    public partial class BookView : Form
    {
        Form1 parent;
        public BookView()
        {
            InitializeComponent();
        }
        public BookView(Form1 f)
        {
            InitializeComponent();
            parent = f; //получаем ссылку на родительскую форму
            textBoxName.Text = parent.b.currentName; //заполняем поля формы данными
            textBoxAutor.Text = parent.b.currentAutor;
            textBoxYear.Text = parent.b.currentYear.ToString();
            textBoxToc.Text = parent.b.currentToc.ToString();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
                parent.b.currentName = textBoxName.Text; //отдаём значения полей из формы с класс родительской формы
                parent.b.currentAutor = textBoxAutor.Text;
                parent.b.currentYear = Convert.ToInt32(textBoxYear.Text);
                parent.b.currentToc = textBoxToc.Text;

                DialogResult = DialogResult.OK; //присваиваем результат ОК
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
