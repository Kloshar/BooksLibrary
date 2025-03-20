namespace BooksLibrary
{
    partial class EditToc
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
            tb = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            switchBtn = new CheckBox();
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(25, 45);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.ScrollBars = ScrollBars.Vertical;
            tb.Size = new Size(735, 338);
            tb.TabIndex = 0;
            tb.KeyDown += tb_KeyDown;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(394, 406);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 23);
            cancelBtn.TabIndex = 12;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(273, 406);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(115, 23);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // switchBtn
            // 
            switchBtn.Appearance = Appearance.Button;
            switchBtn.AutoSize = true;
            switchBtn.Location = new Point(25, 12);
            switchBtn.MinimumSize = new Size(50, 0);
            switchBtn.Name = "switchBtn";
            switchBtn.Size = new Size(50, 27);
            switchBtn.TabIndex = 13;
            switchBtn.Text = "Abc";
            switchBtn.UseVisualStyleBackColor = true;
            switchBtn.CheckedChanged += switchBtn_CheckedChanged;
            // 
            // EditToc
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(switchBtn);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(tb);
            Name = "EditToc";
            Text = "EditToc";
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox tb;
        private Button cancelBtn;
        private Button saveBtn;
        private CheckBox switchBtn;

        #endregion

        //private WebBrowser wb;
    }
}