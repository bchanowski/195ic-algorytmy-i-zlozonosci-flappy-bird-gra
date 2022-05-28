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
using System.Windows;

namespace flappyalpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            string line = "";
            StreamReader sr = new StreamReader("ustawienia.txt");
            line = sr.ReadLine();
            sr.Close();
            this.BackColor = (Color)new ColorConverter().ConvertFromString(line);
            listaWyn1.BackColor = (Color)new ColorConverter().ConvertFromString(line);
            SoundPlayer sound = new SoundPlayer(@"sfx_menu.wav");
            sound.PlayLooping();
        }

        private void start_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"sfx_play.wav");
            player.Play();
            Gra gierka = new Gra();
            gierka.Show();
            
        }

        private void exitP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zobaczW_Click(object sender, EventArgs e)
        {
            wynikiMenu.Visible = true;
            string line = "";
            StreamReader sr = new StreamReader("wynik.txt");
            listaWyn1.BeginUpdate();
            listaWyn1.Items.Clear();
            while ((line = sr.ReadLine()) != null)
            {
                listaWyn1.Items.Add(line);
            }
            listaWyn1.EndUpdate();
            sr.Close();
        }

        private void wyjdzWyn_Click(object sender, EventArgs e)
        {
            wynikiMenu.Visible = false;
        }

        private void usun_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("wynik.txt", File.ReadLines("wynik.txt").Where(l => l != listaWyn1.Text).ToList());
            listaWyn1.Items.Remove(listaWyn1.SelectedItem);
            listaWyn1.Refresh();

        }
        private void opcje_Click(object sender, EventArgs e)
        {
            optionsMenu.Visible = true;
        }

        private void opWroc_Click(object sender, EventArgs e)
        {
            optionsMenu.Visible = false;
        }

        private void opTak_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("ustawienia.txt");
            
            if(opBlue.Checked == true)
            {
                sw.WriteLine("SkyBlue");
                sw.WriteLine("birdBlue.png");
                sw.WriteLine("groundBlue.png");
                sw.WriteLine("pipeGblue.png");
                sw.WriteLine("pipeDblue.png");
            }else if(opRed.Checked == true)
            {
                sw.WriteLine("DarkRed");
                sw.WriteLine("birdRed.png");
                sw.WriteLine("groundRed.png");
                sw.WriteLine("pipeGred.png");
                sw.WriteLine("pipeDred.png");
            }else if(opBlack.Checked == true)
            {
                sw.WriteLine("Silver");
                sw.WriteLine("birdBlack.png");
                sw.WriteLine("groundBlack.png");
                sw.WriteLine("pipeGblack.png");
                sw.WriteLine("pipeDblack.png");
            }
            else if (opPink.Checked == true)
            {
                sw.WriteLine("Plum");
                sw.WriteLine("birdPink.png");
                sw.WriteLine("groundPink.png");
                sw.WriteLine("pipeGpink.png");
                sw.WriteLine("pipeDpink.png");
            }
            else if (opGreen.Checked == true)
            {
                sw.WriteLine("SeaGreen");
                sw.WriteLine("birdGreen.png");
                sw.WriteLine("groundGreen.png");
                sw.WriteLine("pipeGgreen.png");
                sw.WriteLine("pipeDgreen.png");
            }
            else
            {
                sw.WriteLine("PeachPuff");
                sw.WriteLine("birdClass.png");
                sw.WriteLine("groundClass.png");
                sw.WriteLine("pipeGclass.png");
                sw.WriteLine("pipeDclass.png");
            }
            if (hard.Checked == true)
            {
                sw.WriteLine("10");
            }
            else if (ez.Checked == true) sw.WriteLine("2");
            else sw.WriteLine("5");
            sw.Dispose();
            sw.Close();
            string line = "";
            StreamReader sr = new StreamReader("ustawienia.txt");
            line = sr.ReadLine();
            sr.Close();
            this.BackColor = (Color)new ColorConverter().ConvertFromString(line);
            listaWyn1.BackColor = (Color)new ColorConverter().ConvertFromString(line);
        }
    }
}
