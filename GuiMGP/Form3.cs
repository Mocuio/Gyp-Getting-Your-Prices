using ProjectFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuiMGP
{
   
    public partial class Form3 : Form
    {

        public string ClientUrls {  get; set; }

        public Form3()
        {
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        public void button1_Click(object sender, EventArgs e)
        {   Functions pg = new Functions();
            pg.GetTxtPath();
            pg.GetClientlinks(UrlModifier.Text);
            this.Close();
        }

        public void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
         

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
