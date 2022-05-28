namespace flappyalpha
{
    partial class Gra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gra));
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wynik = new System.Windows.Forms.Label();
            this.koniec = new System.Windows.Forms.GroupBox();
            this.zapisz = new System.Windows.Forms.Button();
            this.imie = new System.Windows.Forms.TextBox();
            this.infoKoniec = new System.Windows.Forms.Label();
            this.nie = new System.Windows.Forms.Button();
            this.dalej = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.odlicz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.koniec.SuspendLayout();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(76, 204);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(85, 61);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp.Image")));
            this.pipeUp.Location = new System.Drawing.Point(412, -113);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(100, 265);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(412, 345);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 265);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 2;
            this.pipeDown.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-4, 474);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(824, 172);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(28, 544);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(133, 31);
            this.wynik.TabIndex = 4;
            this.wynik.Text = "Wynik = 0";
            // 
            // koniec
            // 
            this.koniec.BackColor = System.Drawing.SystemColors.Info;
            this.koniec.Controls.Add(this.zapisz);
            this.koniec.Controls.Add(this.imie);
            this.koniec.Controls.Add(this.infoKoniec);
            this.koniec.Controls.Add(this.nie);
            this.koniec.Controls.Add(this.dalej);
            this.koniec.Location = new System.Drawing.Point(114, 231);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(314, 210);
            this.koniec.TabIndex = 5;
            this.koniec.TabStop = false;
            this.koniec.Visible = false;
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(116, 154);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(75, 23);
            this.zapisz.TabIndex = 4;
            this.zapisz.Text = "ZAPISZ";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Visible = false;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(53, 88);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(222, 20);
            this.imie.TabIndex = 3;
            this.imie.Visible = false;
            // 
            // infoKoniec
            // 
            this.infoKoniec.AutoSize = true;
            this.infoKoniec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoKoniec.Location = new System.Drawing.Point(50, 37);
            this.infoKoniec.Name = "infoKoniec";
            this.infoKoniec.Size = new System.Drawing.Size(225, 36);
            this.infoKoniec.TabIndex = 2;
            this.infoKoniec.Text = "                Przegrałeś!\r\nCzy chcesz zapisać swój wynik?";
            // 
            // nie
            // 
            this.nie.Location = new System.Drawing.Point(176, 114);
            this.nie.Name = "nie";
            this.nie.Size = new System.Drawing.Size(75, 23);
            this.nie.TabIndex = 1;
            this.nie.Text = "KONIEC";
            this.nie.UseVisualStyleBackColor = true;
            this.nie.Click += new System.EventHandler(this.nie_Click);
            // 
            // dalej
            // 
            this.dalej.Location = new System.Drawing.Point(53, 114);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(75, 23);
            this.dalej.TabIndex = 0;
            this.dalej.Text = "TAK";
            this.dalej.UseVisualStyleBackColor = true;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // odlicz
            // 
            this.odlicz.AutoSize = true;
            this.odlicz.BackColor = System.Drawing.Color.Transparent;
            this.odlicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odlicz.Location = new System.Drawing.Point(293, 152);
            this.odlicz.Name = "odlicz";
            this.odlicz.Size = new System.Drawing.Size(97, 107);
            this.odlicz.TabIndex = 6;
            this.odlicz.Text = "3";
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(539, 633);
            this.Controls.Add(this.odlicz);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipeUp);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Gra";
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.koniec.ResumeLayout(false);
            this.koniec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        public System.Windows.Forms.PictureBox pipeUp;
        public System.Windows.Forms.PictureBox pipeDown;
        public System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.GroupBox koniec;
        private System.Windows.Forms.Label infoKoniec;
        private System.Windows.Forms.Button nie;
        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label odlicz;
    }
}