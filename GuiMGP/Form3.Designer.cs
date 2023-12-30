namespace GuiMGP
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetUrlsText = new System.Windows.Forms.Button();
            this.UrlModifier = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.GetUrlsText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1287, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 541);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GetUrlsText
            // 
            this.GetUrlsText.Location = new System.Drawing.Point(34, 233);
            this.GetUrlsText.Name = "GetUrlsText";
            this.GetUrlsText.Size = new System.Drawing.Size(75, 23);
            this.GetUrlsText.TabIndex = 0;
            this.GetUrlsText.Text = "Adionar Urls";
            this.GetUrlsText.UseVisualStyleBackColor = true;
            this.GetUrlsText.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrlModifier
            // 
            this.UrlModifier.Location = new System.Drawing.Point(1, 0);
            this.UrlModifier.Multiline = true;
            this.UrlModifier.Name = "UrlModifier";
            this.UrlModifier.Size = new System.Drawing.Size(1290, 541);
            this.UrlModifier.TabIndex = 1;
            this.UrlModifier.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 541);
            this.Controls.Add(this.UrlModifier);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button GetUrlsText;
        public System.Windows.Forms.TextBox UrlModifier;
    }
}