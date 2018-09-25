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
        int Spin=0;
        int load=0;
        int r = 2;
      
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
            int shot = 0;
            //Shoot image source and coding
            //image code
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shoot 1.gif");
            pictureBox3.Image = img;
            //sound code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shot.wav");
            player.Play();
            while(shot<=2)
            {
                if (shot == 0 && load == Spin)
                {
                    MessageBox.Show("you won and your score is 10");
                    shot = 3;
                    button4.Enabled = false;
                }
                else if (shot == 1 && load == Spin)
                {
                    MessageBox.Show("you won and your score is 5");
                    shot = 3;
                    r = r - 1;

                }
                else if (shot == 2)
                {
                    MessageBox.Show("you loose");
                    shot = 3;
                    r = r - 1;

                }
                else
                {
                    shot++;

                    if (Spin == 6)
                    {
                        Spin = 1;
                    }
                    else
                    {
                        Spin++;
                    }
                }
            }
            if(r==0)
            {
                button4.Enabled = false;
            }

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
            Random rnd = new Random();
            Spin  = rnd.Next(1, 7);
            button4 .Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Try again and reopening the application code
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
