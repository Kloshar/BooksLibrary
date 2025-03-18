namespace BooksLibrary
{
    partial class BookView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxAutor = new TextBox();
            label2 = new Label();
            textBoxYear = new TextBox();
            label3 = new Label();
            textBoxToc = new TextBox();
            label4 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(111, 27);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(596, 25);
            textBoxName.TabIndex = 1;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(111, 69);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(596, 25);
            textBoxAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 9;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(111, 114);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(596, 25);
            textBoxYear.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 4;
            label3.Text = "Год издания";
            // 
            // textBoxToc
            // 
            textBoxToc.Location = new Point(111, 160);
            textBoxToc.Name = "textBoxToc";
            textBoxToc.Size = new Size(596, 25);
            textBoxToc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(82, 17);
            label4.TabIndex = 6;
            label4.Text = "Созержание";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(268, 224);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(115, 23);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(389, 224);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 23);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 11;
            label5.Text = "Автор";
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 309);
            Controls.Add(label5);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(textBoxToc);
            Controls.Add(label4);
            Controls.Add(textBoxYear);
            Controls.Add(label3);
            Controls.Add(textBoxAutor);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "BookView";
            Text = "BookView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxAutor;
        private Label label2;
        private TextBox textBoxYear;
        private Label label3;
        private TextBox textBoxToc;
        private Label label4;
        private Button saveBtn;
        private Button cancelBtn;
        private Label label5;
    }
}