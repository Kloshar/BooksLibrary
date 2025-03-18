namespace BooksLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBook = new Button();
            booksTable = new DataGridView();
            editBook = new Button();
            removeBook = new Button();
            editTocBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)booksTable).BeginInit();
            SuspendLayout();
            // 
            // addBook
            // 
            addBook.Location = new Point(12, 410);
            addBook.Name = "addBook";
            addBook.Size = new Size(107, 27);
            addBook.TabIndex = 0;
            addBook.Text = "Добавить";
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += addBook_Click;
            // 
            // booksTable
            // 
            booksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksTable.Location = new Point(12, 11);
            booksTable.MultiSelect = false;
            booksTable.Name = "booksTable";
            booksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            booksTable.Size = new Size(776, 384);
            booksTable.TabIndex = 2;
            // 
            // editBook
            // 
            editBook.Location = new Point(135, 410);
            editBook.Name = "editBook";
            editBook.Size = new Size(107, 27);
            editBook.TabIndex = 3;
            editBook.Text = "Редактировать";
            editBook.UseVisualStyleBackColor = true;
            editBook.Click += editBook_Click;
            // 
            // removeBook
            // 
            removeBook.Location = new Point(263, 410);
            removeBook.Name = "removeBook";
            removeBook.Size = new Size(107, 27);
            removeBook.TabIndex = 4;
            removeBook.Text = "Удалить";
            removeBook.UseVisualStyleBackColor = true;
            removeBook.Click += removeBook_Click;
            // 
            // editTocBtn
            // 
            editTocBtn.Location = new Point(386, 411);
            editTocBtn.Name = "editTocBtn";
            editTocBtn.Size = new Size(107, 27);
            editTocBtn.TabIndex = 5;
            editTocBtn.Text = "Содержание";
            editTocBtn.UseVisualStyleBackColor = true;
            editTocBtn.Click += editTocBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editTocBtn);
            Controls.Add(removeBook);
            Controls.Add(editBook);
            Controls.Add(booksTable);
            Controls.Add(addBook);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)booksTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addBook;
        private DataGridView booksTable;
        private Button editBook;
        private Button removeBook;
        private Button editTocBtn;
    }
}
