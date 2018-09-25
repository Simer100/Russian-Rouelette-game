using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Russianreolette : Form


    {
        
        public static string a;
        public Russianreolette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Main gif picture coding
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\ezgif.com-resize.gif");
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Play button 
            (new Form2()).Show();
            this.Hide();
        }     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //Below is the code of text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Below is the code of the main GIG Picture
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
