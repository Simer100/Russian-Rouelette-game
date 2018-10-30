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
        
        public string Name_val;
        public Russianreolette()
        {
            InitializeComponent();
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {
            //Main gif picture coding
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\ezgif.com-resize.gif");
            WelcomeGif_Pic.Image = img;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Name_val = Name_textBox.Text;
            //Play button 
            (new PlayTheRoulette()).Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
