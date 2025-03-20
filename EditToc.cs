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
        XDocument xDoc;
        public EditToc(Form1 f)
        {
            InitializeComponent();
            parent = f; //получаем ссылку на родительскую форму

            //string toc = @"<tableofcontents><chapter>Благодарности</chapter><chapter>Предисловие</chapter><chapter>ЧАСТЬ I. ЯЗЫК C#</chapter><chapter>Глава 1. Создание C#</chapter><chapter>Глава 2. Краткий обзор элементов C#</chapter><chapter>Глава 3. Типы данных</chapter><chapter>Приложение. Краткий справочник по составлению</chapter><chapter>документирующих комментариев</chapter><chapter>Предметный указатель</chapter></tableofcontents>";
            string toc = f.toc; //забираем из главной формы значение с содержанием

            if(xDoc != null)
            {
                xDoc = XDocument.Parse(toc); //парсим в xml
            }
            else
            {
                //создаём шаблон для содержения
                xDoc = new XDocument(new XElement("tableofcontents",
                    new XElement("chapter", "Глава 1")));                
            }
            tb.Text = xDoc.ToString(); //добавлем в тексбокс
            tb.SelectionStart = 0; //снимает выделение
        }
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.S)
            {
                xDoc = XDocument.Parse(tb.Text);
            }
        }
        private void switchBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (switchBtn.CheckState == CheckState.Checked)
            {
                try //на случай, если текст не соответствует xml, например пустой
                {
                    xDoc = XDocument.Parse(tb.Text);
                    XElement? tableofcontents = xDoc.Element("tableofcontents");

                    tb.Clear();

                    if (tableofcontents != null)
                    {
                        foreach (XElement chapter in tableofcontents.Elements("chapter"))
                        {
                            tb.Text += chapter.Value + Environment.NewLine;
                        }
                    }
                }
                catch
                {
                    //ничего не делаем, xDoc не перезаписываем, чтобы вернуть после отжатия кнопки
                }

                tb.ReadOnly = true;
            }
            else
            {
                tb.ReadOnly = false;
                tb.Clear();
                tb.Text = xDoc.ToString();
                tb.SelectionStart = 0; //снимает выделение
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                xDoc = XDocument.Parse(tb.Text); //сохраняем результат из текстбокса в переменную
                parent.toc = xDoc.ToString(); //выгружаем результат в главную форму
            }
            catch(XmlException xmlEx) //если поле не валидно
            {
                //то ничего не сохраняем
            }            
            DialogResult = DialogResult.OK; //присваиваем результат ОК
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //присваиваем результат Cancel
        }
    }
}