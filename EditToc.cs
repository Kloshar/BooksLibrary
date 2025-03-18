using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksLibrary
{
    public partial class EditToc : Form
    {
        HtmlEditor editor;
        Form1 parent;
        public EditToc(Form1 f)
        {
            InitializeComponent();

            parent = f; //получаем ссылку на родительскую форму

            string toc = @"<tableofcontents>chapter>Благодарности</chapter><chapter>Предисловие</chapter><chapter>ЧАСТЬ I. ЯЗЫК C#</chapter><chapter>Глава 1. Создание C#</chapter><chapter>Глава 2. Краткий обзор элементов C#</chapter><chapter>Глава 3. Типы данных</chapter><chapter>Приложение. Краткий справочник по составлению</chapter><chapter>документирующих комментариев</chapter><chapter>Предметный указатель</chapter>/tableofcontents>"
;
            //editor = new HtmlEditor(wb, html);

            tb.Text = toc;
            FormatXml(tb, toc);
        }
        void FormatXml(TextBox tb, string input)
        {
            string output = input.Replace("><", ">\r\n<");

            tb.Text = output; //




        } //форматирует строку в тектовом окне


    }
}
