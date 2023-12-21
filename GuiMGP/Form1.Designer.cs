namespace GuiMGP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.GetNewPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.EditarUrls = new System.Windows.Forms.Button();
            this.AdicionarUrls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 48);
            this.panel2.TabIndex = 1;
            // 
            // GetNewPrice
            // 
            this.GetNewPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.GetNewPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GetNewPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetNewPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetNewPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.GetNewPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.GetNewPrice.Location = new System.Drawing.Point(72, 80);
            this.GetNewPrice.Name = "GetNewPrice";
            this.GetNewPrice.Size = new System.Drawing.Size(139, 45);
            this.GetNewPrice.TabIndex = 2;
            this.GetNewPrice.Text = "Pesquisar Preços";
            this.GetNewPrice.UseVisualStyleBackColor = false;
            this.GetNewPrice.Click += new System.EventHandler(this.GetNewPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(187, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rafael C. Souza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // EditarUrls
            // 
            this.EditarUrls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.EditarUrls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditarUrls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarUrls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarUrls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.EditarUrls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.EditarUrls.Location = new System.Drawing.Point(72, 259);
            this.EditarUrls.Name = "EditarUrls";
            this.EditarUrls.Size = new System.Drawing.Size(139, 45);
            this.EditarUrls.TabIndex = 7;
            this.EditarUrls.Text = " EditarUrls";
            this.EditarUrls.UseVisualStyleBackColor = false;
            this.EditarUrls.Click += new System.EventHandler(this.EditarUrls_Click);
            // 
            // AdicionarUrls
            // 
            this.AdicionarUrls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.AdicionarUrls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AdicionarUrls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdicionarUrls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdicionarUrls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.AdicionarUrls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.AdicionarUrls.Location = new System.Drawing.Point(72, 172);
            this.AdicionarUrls.Name = "AdicionarUrls";
            this.AdicionarUrls.Size = new System.Drawing.Size(139, 45);
            this.AdicionarUrls.TabIndex = 8;
            this.AdicionarUrls.Text = "Adicionar Urls";
            this.AdicionarUrls.UseVisualStyleBackColor = false;
            this.AdicionarUrls.Click += new System.EventHandler(this.AdicionarUrls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(283, 370);
            this.Controls.Add(this.AdicionarUrls);
            this.Controls.Add(this.EditarUrls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetNewPrice);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyp- Get Your Prices";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GetNewPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button EditarUrls;
        private System.Windows.Forms.Button AdicionarUrls;
    }
}

