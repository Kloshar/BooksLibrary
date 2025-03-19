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
            SuspendLayout();
            // 
            // tb
            // 
            tb.Location = new Point(25, 35);
            tb.Multiline = true;
            tb.Name = "tb";
            tb.Size = new Size(735, 312);
            tb.TabIndex = 0;
            tb.KeyDown += tb_KeyDown;
            // 
            // EditToc
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tb);
            Name = "EditToc";
            Text = "EditToc";
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox tb;

        #endregion

        //private WebBrowser wb;
    }
}