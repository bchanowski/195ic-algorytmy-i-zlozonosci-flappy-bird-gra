namespace flappyalpha
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.zobaczW = new System.Windows.Forms.Button();
            this.exitP = new System.Windows.Forms.Button();
            this.opcje = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.wynikiMenu = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wyjdzWyn = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.listaWyn1 = new System.Windows.Forms.ListBox();
            this.optionsMenu = new System.Windows.Forms.GroupBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picPink = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picSilv = new System.Windows.Forms.PictureBox();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.opGreen = new System.Windows.Forms.RadioButton();
            this.opPink = new System.Windows.Forms.RadioButton();
            this.opBlue = new System.Windows.Forms.RadioButton();
            this.opWroc = new System.Windows.Forms.Button();
            this.opTak = new System.Windows.Forms.Button();
            this.opM1 = new System.Windows.Forms.Panel();
            this.op1 = new System.Windows.Forms.Label();
            this.ez = new System.Windows.Forms.RadioButton();
            this.med = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.op2 = new System.Windows.Forms.Label();
            this.opBlack = new System.Windows.Forms.RadioButton();
            this.opRed = new System.Windows.Forms.RadioButton();
            this.opClas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.wynikiMenu.SuspendLayout();
            this.optionsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            this.opM1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(36, 59);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 72);
            this.start.TabIndex = 0;
            this.start.Text = "ZAGRAJ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // zobaczW
            // 
            this.zobaczW.Location = new System.Drawing.Point(40, 173);
            this.zobaczW.Name = "zobaczW";
            this.zobaczW.Size = new System.Drawing.Size(138, 75);
            this.zobaczW.TabIndex = 1;
            this.zobaczW.Text = "ZOBACZ WYNIKI";
            this.zobaczW.UseVisualStyleBackColor = true;
            this.zobaczW.Click += new System.EventHandler(this.zobaczW_Click);
            // 
            // exitP
            // 
            this.exitP.Location = new System.Drawing.Point(279, 344);
            this.exitP.Name = "exitP";
            this.exitP.Size = new System.Drawing.Size(115, 58);
            this.exitP.TabIndex = 2;
            this.exitP.Text = "ZAMKNIJ";
            this.exitP.UseVisualStyleBackColor = true;
            this.exitP.Click += new System.EventHandler(this.exitP_Click);
            // 
            // opcje
            // 
            this.opcje.Location = new System.Drawing.Point(40, 283);
            this.opcje.Name = "opcje";
            this.opcje.Size = new System.Drawing.Size(138, 68);
            this.opcje.TabIndex = 3;
            this.opcje.Text = "OPCJE";
            this.opcje.UseVisualStyleBackColor = true;
            this.opcje.Click += new System.EventHandler(this.opcje_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(216, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(195, 151);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // wynikiMenu
            // 
            this.wynikiMenu.Controls.Add(this.label2);
            this.wynikiMenu.Controls.Add(this.label1);
            this.wynikiMenu.Controls.Add(this.wyjdzWyn);
            this.wynikiMenu.Controls.Add(this.usun);
            this.wynikiMenu.Controls.Add(this.listaWyn1);
            this.wynikiMenu.Location = new System.Drawing.Point(12, 12);
            this.wynikiMenu.Name = "wynikiMenu";
            this.wynikiMenu.Size = new System.Drawing.Size(400, 442);
            this.wynikiMenu.TabIndex = 5;
            this.wynikiMenu.TabStop = false;
            this.wynikiMenu.Text = "WYNIKI";
            this.wynikiMenu.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wynik";
            // 
            // wyjdzWyn
            // 
            this.wyjdzWyn.Location = new System.Drawing.Point(208, 288);
            this.wyjdzWyn.Name = "wyjdzWyn";
            this.wyjdzWyn.Size = new System.Drawing.Size(128, 57);
            this.wyjdzWyn.TabIndex = 2;
            this.wyjdzWyn.Text = "WRÓĆ";
            this.wyjdzWyn.UseVisualStyleBackColor = true;
            this.wyjdzWyn.Click += new System.EventHandler(this.wyjdzWyn_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(208, 211);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(128, 57);
            this.usun.TabIndex = 1;
            this.usun.Text = "USUŃ WYNIK";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.usun_Click);
            // 
            // listaWyn1
            // 
            this.listaWyn1.FormattingEnabled = true;
            this.listaWyn1.Location = new System.Drawing.Point(22, 60);
            this.listaWyn1.Name = "listaWyn1";
            this.listaWyn1.Size = new System.Drawing.Size(152, 303);
            this.listaWyn1.TabIndex = 0;
            // 
            // optionsMenu
            // 
            this.optionsMenu.Controls.Add(this.picGreen);
            this.optionsMenu.Controls.Add(this.picPink);
            this.optionsMenu.Controls.Add(this.picBlue);
            this.optionsMenu.Controls.Add(this.picSilv);
            this.optionsMenu.Controls.Add(this.picRed);
            this.optionsMenu.Controls.Add(this.picClass);
            this.optionsMenu.Controls.Add(this.opGreen);
            this.optionsMenu.Controls.Add(this.opPink);
            this.optionsMenu.Controls.Add(this.opBlue);
            this.optionsMenu.Controls.Add(this.opWroc);
            this.optionsMenu.Controls.Add(this.opTak);
            this.optionsMenu.Controls.Add(this.opM1);
            this.optionsMenu.Controls.Add(this.op2);
            this.optionsMenu.Controls.Add(this.opBlack);
            this.optionsMenu.Controls.Add(this.opRed);
            this.optionsMenu.Controls.Add(this.opClas);
            this.optionsMenu.Location = new System.Drawing.Point(18, 12);
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(430, 461);
            this.optionsMenu.TabIndex = 5;
            this.optionsMenu.TabStop = false;
            this.optionsMenu.Text = "Opcje";
            this.optionsMenu.Visible = false;
            // 
            // picGreen
            // 
            this.picGreen.Image = ((System.Drawing.Image)(resources.GetObject("picGreen.Image")));
            this.picGreen.Location = new System.Drawing.Point(304, 318);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(65, 62);
            this.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreen.TabIndex = 20;
            this.picGreen.TabStop = false;
            // 
            // picPink
            // 
            this.picPink.Image = ((System.Drawing.Image)(resources.GetObject("picPink.Image")));
            this.picPink.Location = new System.Drawing.Point(182, 318);
            this.picPink.Name = "picPink";
            this.picPink.Size = new System.Drawing.Size(65, 62);
            this.picPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPink.TabIndex = 19;
            this.picPink.TabStop = false;
            // 
            // picBlue
            // 
            this.picBlue.Image = ((System.Drawing.Image)(resources.GetObject("picBlue.Image")));
            this.picBlue.Location = new System.Drawing.Point(68, 318);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(65, 62);
            this.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlue.TabIndex = 18;
            this.picBlue.TabStop = false;
            // 
            // picSilv
            // 
            this.picSilv.Image = ((System.Drawing.Image)(resources.GetObject("picSilv.Image")));
            this.picSilv.Location = new System.Drawing.Point(304, 242);
            this.picSilv.Name = "picSilv";
            this.picSilv.Size = new System.Drawing.Size(65, 62);
            this.picSilv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSilv.TabIndex = 17;
            this.picSilv.TabStop = false;
            // 
            // picRed
            // 
            this.picRed.Image = ((System.Drawing.Image)(resources.GetObject("picRed.Image")));
            this.picRed.Location = new System.Drawing.Point(181, 242);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(65, 62);
            this.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRed.TabIndex = 16;
            this.picRed.TabStop = false;
            // 
            // picClass
            // 
            this.picClass.Image = ((System.Drawing.Image)(resources.GetObject("picClass.Image")));
            this.picClass.Location = new System.Drawing.Point(68, 242);
            this.picClass.Name = "picClass";
            this.picClass.Size = new System.Drawing.Size(65, 62);
            this.picClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClass.TabIndex = 15;
            this.picClass.TabStop = false;
            // 
            // opGreen
            // 
            this.opGreen.AutoSize = true;
            this.opGreen.Location = new System.Drawing.Point(284, 341);
            this.opGreen.Name = "opGreen";
            this.opGreen.Size = new System.Drawing.Size(14, 13);
            this.opGreen.TabIndex = 14;
            this.opGreen.TabStop = true;
            this.opGreen.UseVisualStyleBackColor = true;
            // 
            // opPink
            // 
            this.opPink.AutoSize = true;
            this.opPink.Location = new System.Drawing.Point(162, 341);
            this.opPink.Name = "opPink";
            this.opPink.Size = new System.Drawing.Size(14, 13);
            this.opPink.TabIndex = 13;
            this.opPink.TabStop = true;
            this.opPink.UseVisualStyleBackColor = true;
            // 
            // opBlue
            // 
            this.opBlue.AutoSize = true;
            this.opBlue.Location = new System.Drawing.Point(48, 341);
            this.opBlue.Name = "opBlue";
            this.opBlue.Size = new System.Drawing.Size(14, 13);
            this.opBlue.TabIndex = 12;
            this.opBlue.TabStop = true;
            this.opBlue.UseVisualStyleBackColor = true;
            // 
            // opWroc
            // 
            this.opWroc.Location = new System.Drawing.Point(237, 395);
            this.opWroc.Name = "opWroc";
            this.opWroc.Size = new System.Drawing.Size(99, 34);
            this.opWroc.TabIndex = 11;
            this.opWroc.Text = "WRÓĆ";
            this.opWroc.UseVisualStyleBackColor = true;
            this.opWroc.Click += new System.EventHandler(this.opWroc_Click);
            // 
            // opTak
            // 
            this.opTak.Location = new System.Drawing.Point(65, 395);
            this.opTak.Name = "opTak";
            this.opTak.Size = new System.Drawing.Size(115, 34);
            this.opTak.TabIndex = 10;
            this.opTak.Text = "ZAPISZ USTAWIENIA";
            this.opTak.UseCompatibleTextRendering = true;
            this.opTak.UseVisualStyleBackColor = true;
            this.opTak.Click += new System.EventHandler(this.opTak_Click);
            // 
            // opM1
            // 
            this.opM1.Controls.Add(this.op1);
            this.opM1.Controls.Add(this.ez);
            this.opM1.Controls.Add(this.med);
            this.opM1.Controls.Add(this.hard);
            this.opM1.Location = new System.Drawing.Point(26, 38);
            this.opM1.Name = "opM1";
            this.opM1.Size = new System.Drawing.Size(373, 134);
            this.opM1.TabIndex = 9;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.op1.Location = new System.Drawing.Point(16, 31);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(317, 31);
            this.op1.TabIndex = 3;
            this.op1.Text = "POZIOM TRUDNOŚCI:";
            this.op1.UseMnemonic = false;
            // 
            // ez
            // 
            this.ez.AutoSize = true;
            this.ez.Location = new System.Drawing.Point(22, 96);
            this.ez.Name = "ez";
            this.ez.Size = new System.Drawing.Size(54, 17);
            this.ez.TabIndex = 0;
            this.ez.TabStop = true;
            this.ez.Text = "Łatwy";
            this.ez.UseVisualStyleBackColor = true;
            // 
            // med
            // 
            this.med.AutoSize = true;
            this.med.Location = new System.Drawing.Point(136, 96);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(69, 17);
            this.med.TabIndex = 1;
            this.med.TabStop = true;
            this.med.Text = "Normalny";
            this.med.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(258, 96);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(58, 17);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Trudny";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.op2.Location = new System.Drawing.Point(42, 186);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(131, 31);
            this.op2.TabIndex = 7;
            this.op2.Text = "MOTYW:";
            // 
            // opBlack
            // 
            this.opBlack.AutoSize = true;
            this.opBlack.Location = new System.Drawing.Point(284, 264);
            this.opBlack.Name = "opBlack";
            this.opBlack.Size = new System.Drawing.Size(14, 13);
            this.opBlack.TabIndex = 6;
            this.opBlack.TabStop = true;
            this.opBlack.UseVisualStyleBackColor = true;
            // 
            // opRed
            // 
            this.opRed.AutoSize = true;
            this.opRed.Location = new System.Drawing.Point(162, 264);
            this.opRed.Name = "opRed";
            this.opRed.Size = new System.Drawing.Size(14, 13);
            this.opRed.TabIndex = 5;
            this.opRed.TabStop = true;
            this.opRed.UseVisualStyleBackColor = true;
            // 
            // opClas
            // 
            this.opClas.AutoSize = true;
            this.opClas.Location = new System.Drawing.Point(48, 261);
            this.opClas.Name = "opClas";
            this.opClas.Size = new System.Drawing.Size(14, 13);
            this.opClas.TabIndex = 4;
            this.opClas.TabStop = true;
            this.opClas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(452, 478);
            this.Controls.Add(this.optionsMenu);
            this.Controls.Add(this.wynikiMenu);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.opcje);
            this.Controls.Add(this.exitP);
            this.Controls.Add(this.zobaczW);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.wynikiMenu.ResumeLayout(false);
            this.wynikiMenu.PerformLayout();
            this.optionsMenu.ResumeLayout(false);
            this.optionsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSilv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            this.opM1.ResumeLayout(false);
            this.opM1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button zobaczW;
        private System.Windows.Forms.Button exitP;
        private System.Windows.Forms.Button opcje;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.GroupBox wynikiMenu;
        private System.Windows.Forms.ListBox listaWyn1;
        private System.Windows.Forms.Button wyjdzWyn;
        private System.Windows.Forms.Button usun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox optionsMenu;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton med;
        private System.Windows.Forms.RadioButton ez;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.RadioButton opBlack;
        private System.Windows.Forms.RadioButton opRed;
        private System.Windows.Forms.RadioButton opClas;
        private System.Windows.Forms.Panel opM1;
        private System.Windows.Forms.Button opWroc;
        private System.Windows.Forms.Button opTak;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picPink;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picSilv;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.RadioButton opGreen;
        private System.Windows.Forms.RadioButton opPink;
        private System.Windows.Forms.RadioButton opBlue;
    }
}

