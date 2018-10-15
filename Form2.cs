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
    public partial class Form2 : Form
    {
        //difining integers here
        public int count = 0, load;
        public int Spinval;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\ezgif.com-resize 1.gif");
            pictureBox1.Image = img;
            //defining the variable for lables
           


        }


        private void button4_Click(object sender, EventArgs e)
        {
           
            //Shoot image source and coding
            //image code
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shoot 1.gif");
            pictureBox3.Image = img;
            //sound code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shot.wav");
            player.Play();

            RouletteGame ShotObj = new RouletteGame();
            int score = ShotObj.Fire_Bullet(load, Spinval);

           

            if (count == 0 && score == 10)
            {
                MessageBox.Show("you won and your score is " + score);
                button4.Enabled = false;
            }

            else if (count == 1 && score == 5)
            {
                MessageBox.Show("you won and your score is " + score);
                button4.Enabled = false;
            }
            if (count == 1 && score == 0)
            {
                MessageBox.Show("Sorry, you losse the game");
                button4.Enabled = false;
            }
            else
            {
                count++;
                Spinval = spinchambervalue(Spinval);
            }
        }

        public int spinchambervalue(int spin_val)
        {
            if (spin_val == 6)
            {
                spin_val = 1;

            }
            else
            {
                spin_val++;

            }
            return spin_val;

        }




            private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //load image code
            //Image coding
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\9b0affdb1c10e17006bc04e391c5ec9b1512793216_full.jpg");
            pictureBox2.Image = img; 
            Image img1 = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\load.gif");
            pictureBox3.Image = img1;
            //Sound code(back sound played)
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\sound.wav");
            player.Play();
            load = 1;

            button2.Enabled = true;
            btnload.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Main fixed gif image source
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\ezgif.com-resize 1.gif");
            pictureBox1.Image = img;
        }
        //Below is the code of picture box 2(face image)
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
        //Below is the code of small picture box named picture box3 (small GIF appears)
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Exit button code
            System.Diagnostics.Process.GetCurrentProcess().Kill();

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Spin image and code
            //image code
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\spin.gif");
            pictureBox3.Image = img;
            //sound code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\spin sound.wav");
            player.Play();
            RouletteGame SpinObj = new RouletteGame();
            Spinval = SpinObj.Spin_Chamber();

            button4 .Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Try again and reopening the application code
            RouletteGame try1 = new RouletteGame();
           try1.try_again();

            (new Form2()).Show();
            this.Close();

        }
        //Label 5 in front of scores
        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        //lable 6 in front of wins 
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //lable 7 in front of looses
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
