using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

namespace BooksLibrary
{
    public partial class EditToc : Form
    {
        Form1 parent;
        public EditToc(Form1 f)
        {
            InitializeComponent();

            parent = f; //получаем ссылку на родительскую форму

            string toc = @"<tableofcontents><chapter>Благодарности</chapter><chapter>Предисловие</chapter><chapter>ЧАСТЬ I. ЯЗЫК C#</chapter><chapter>Глава 1. Создание C#</chapter><chapter>Глава 2. Краткий обзор элементов C#</chapter><chapter>Глава 3. Типы данных</chapter><chapter>Приложение. Краткий справочник по составлению</chapter><chapter>документирующих комментариев</chapter><chapter>Предметный указатель</chapter></tableofcontents>";

            XDocument xDoc = XDocument.Parse(toc);
            Debug.WriteLine(xDoc);

            tb.Text = xDoc.ToString();
            tb.SelectionStart = 0; //снимает выделение

            //foreach(XmlNode child in xRoot.ChildNodes)
            //{
            //    //Debug.WriteLine(child.InnerText);
            //}

            //Debug.WriteLine(xRoot.Name);


            //MutableString ms = new MutableString(toc);
            //tb.Text = ms.getFormattedString;
            //tb.SelectionStart = 0; //снимает выделение
        }
        class MutableString
        {
            string inputString = string.Empty; //изначальная строка
            string formattedString = string.Empty; //с переносами и табуляцией
            string cleanedString = string.Empty; //с переносами и с табуляцией, но без тегов
            public string getFormattedString { get { return formattedString; } } //свойство для получения форматированной строки
            public string getСleanedString { get { return cleanedString; } } //свойство для получения очищенной строки
            public MutableString(string input) //конструктор, принимающий строку
            {
                inputString = input;
                formatString();
                cleanString();
            }
            void formatString()
            {
                //formattedString = inputString.Replace("><", ">" + Environment.NewLine + "<");
                formattedString = inputString;

                int pos = 0;

                int index = formattedString.IndexOf("><");
                //string previewTag = formattedString.Substring();


                Debug.WriteLine(index);

                //while (pos < formattedString.Length) //двигаемся по строке
                //{
                //    //когда встречаем "><", заменяем на перенос с табом или без
                //    if (formattedString.IndexOf("><"){

                //    }


                //    Debug.WriteLine("!");



                //}
            }
            void cleanString()
            {

            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                XDocument uDoc = XDocument.Parse(tb.Text);
                Debug.WriteLine(uDoc);
            }
        }
    }
}
