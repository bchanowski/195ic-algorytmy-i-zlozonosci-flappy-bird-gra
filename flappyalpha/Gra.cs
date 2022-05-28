using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;
namespace flappyalpha
{
    public partial class Gra : Form
    {
        private static Random rand;
        static Gra()
        {
            rand = new Random();
        }
        int counter = 3;
        bool jump = false;
        int speed;
        int grav = 5;
        int gScore = 0;
        public Gra()
        { 
            InitializeComponent();
            string line = "";
            int ile = 0;
            string[] opcje = new string[6];
            StreamReader sr = new StreamReader("ustawienia.txt");
            while ((line = sr.ReadLine()) != null)
            {
                opcje[ile] = line;
                ile++;
            }
            sr.Close();
            this.BackColor = (Color)new ColorConverter().ConvertFromString(opcje[0]);
            bird.Image = Image.FromFile(opcje[1]);
            ground.Image = Image.FromFile(opcje[2]);
            pipeUp.Image = Image.FromFile(opcje[3]);
            pipeDown.Image = Image.FromFile(opcje[4]);
            speed = int.Parse(opcje[5]);


        }
        public static int RandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            odlicz.Visible = false;
            pipeDown.Left -= speed;
            pipeUp.Left -= speed;
            bird.Top += grav;
            int Ypos;
            if (pipeDown.Left < -80)
            {
                pipeDown.Left = 500;
                gScore++;
                Ypos = Gra.RandomNumber(240,420);
                pipeDown.Location = new Point(500,Ypos);
                pipeUp.Location = new Point(500, pipeDown.Location.Y  - 480);
                wynik.Text = "Wynik = " + gScore;
            }
            if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (bird.Bounds.IntersectsWith(pipeDown.Bounds))
            {
                endGame();
            }
            else if (bird.Bounds.IntersectsWith(pipeUp.Bounds))
            {
                endGame();
            }else if(bird.Location.Y < 0)
            {
                endGame();
            }
            
        }
        private void endGame()
        {
            timer1.Stop();
            koniec.Visible = true;
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(@"sfx_hit.wav");
            player3.Play();
        }

        private void gKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                jump = true;
                grav = -5;
                if (koniec.Visible == false) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sfx_wing.wav");
                    player.Play();
                }
            }
        }

        private void gKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jump = false;
                grav = 5;
            }
        }

        private void dalej_Click(object sender, EventArgs e)
        {
            imie.Visible = true;
            infoKoniec.Text = "Podaj swoję imię!:";
            dalej.Visible = false;
            nie.Visible = false;
            zapisz.Visible = true;
        }

        private void nie_Click(object sender, EventArgs e)
        {
            this.Close();
            SoundPlayer sound = new SoundPlayer(@"sfx_menu.wav");
            sound.PlayLooping();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            string zapis;
            if (gScore < 10)
            {
                zapis = gScore + "            |           " + imie.Text;
            }else if(gScore < 100) zapis = gScore + "          |           " + imie.Text;
            else zapis = gScore + "        |          " + imie.Text;
            StreamWriter sw = new StreamWriter("wynik.txt", true);
            sw.WriteLine(zapis);
            sw.Dispose();
            sw.Close();
            this.Close();
            SoundPlayer sound = new SoundPlayer(@"sfx_menu.wav");
            sound.PlayLooping();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                odlicz.Text = "" + counter;
            }
            if(counter == 0)
            {
                odlicz.Location = new Point(150,152);
                odlicz.Text = "START";
                timer2.Interval = 100;
            }
            if (counter < 0)
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
            counter--;
        }
    }
}
