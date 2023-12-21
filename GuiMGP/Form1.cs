using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFunctions;
namespace GuiMGP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void GetNewPrice_Click(object sender, EventArgs e)
        {
            Functions pg = new Functions();

            pg.GetTxtPath();
            pg.GetDocInfo();
            pg.GetClientlinks();
            pg.WriteCsvDocument();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void EditarUrls_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.ShowDialog();

        }

        private void AdicionarUrls_Click(object sender, EventArgs e)
        { 
          Form form3 = new Form3();
            form3.ShowDialog();
           
        }   
    }
 } 