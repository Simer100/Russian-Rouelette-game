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
    public partial class PlayTheRoulette : Form
    {
        //difining integers here
        public int count = 0, load;
        public int Spinval;
        Russianreolette objRR = new Russianreolette();

        public PlayTheRoulette()
        {
            InitializeComponent();
        }
        private void Play_Roulette_Form_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\ezgif.com-resize 1.gif");
            MainGif.Image = img;
            Name_lbl.Text = objRR.Name_val;
            //defining the variable for lables

        }
        
        private void btnload_Click(object sender, EventArgs e)
        {
            //load image code
            //Image coding
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\9b0affdb1c10e17006bc04e391c5ec9b1512793216_full.jpg");
            anime_target_image.Image = img;
            Image img1 = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\load.gif");
            pistol_image.Image = img1;
            //Sound code(back sound played)
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\sound.wav");
            player.Play();
            load = 1;

            btnspin.Enabled = true;
            btnload.Enabled = false;

        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            //Spin image and code
            //image code
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\spin.gif");
            pistol_image.Image = img;
            //sound code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\spin sound.wav");
            player.Play();
            RouletteGame SpinObj = new RouletteGame();
            Spinval = SpinObj.Spin_Chamber();

            btnshoot.Enabled = true;
            btnspin.Enabled = false;

        }

        private void btnshoot_Click(object sender, EventArgs e)
        {

            //Shoot image source and coding
            //image code
            Image img = Image.FromFile(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shoot 1.gif");
            pistol_image.Image = img;
            //sound code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\SS077\source\repos\WindowsFormsApp2\Images\shot.wav");
            player.Play();

            RouletteGame ShotObj = new RouletteGame();
            int score = ShotObj.Fire_Bullet(load, Spinval);
            
            if (count == 0 && score == 10)
            {
                MessageBox.Show("you won and your score is " + score);
                btnshoot.Enabled = false;
            }

            else if (count == 1 && score == 5)
            {
                MessageBox.Show("you won and your score is " + score);
                btnshoot.Enabled = false;
            }
            if (count == 1 && score == 0)
            {
                MessageBox.Show("Sorry, you losse the game");
                btnshoot.Enabled = false;
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

        private void btnshootaway_Click(object sender, EventArgs e)
        {

            //Try again and reopening the application code
            RouletteGame try1 = new RouletteGame();
            try1.try_again();

            (new PlayTheRoulette()).Show();
            this.Close();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Exit button code
            System.Diagnostics.Process.GetCurrentProcess().Kill();

            Application.Exit();

        }
        
    }
}
