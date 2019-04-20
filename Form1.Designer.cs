namespace FlappyBird
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbOngTren1 = new System.Windows.Forms.PictureBox();
            this.pcbOngDuoi1 = new System.Windows.Forms.PictureBox();
            this.pcbOngTren2 = new System.Windows.Forms.PictureBox();
            this.pcbOngDuoi2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbPlay = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.conchim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngTren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngDuoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngTren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngDuoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbOngTren1
            // 
            this.pcbOngTren1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbOngTren1.BackgroundImage")));
            this.pcbOngTren1.Location = new System.Drawing.Point(123, -770);
            this.pcbOngTren1.Name = "pcbOngTren1";
            this.pcbOngTren1.Size = new System.Drawing.Size(271, 1001);
            this.pcbOngTren1.TabIndex = 0;
            this.pcbOngTren1.TabStop = false;
            this.pcbOngTren1.Click += new System.EventHandler(this.pcbOngTren1_Click);
            // 
            // pcbOngDuoi1
            // 
            this.pcbOngDuoi1.Image = ((System.Drawing.Image)(resources.GetObject("pcbOngDuoi1.Image")));
            this.pcbOngDuoi1.Location = new System.Drawing.Point(123, 319);
            this.pcbOngDuoi1.Name = "pcbOngDuoi1";
            this.pcbOngDuoi1.Size = new System.Drawing.Size(279, 498);
            this.pcbOngDuoi1.TabIndex = 1;
            this.pcbOngDuoi1.TabStop = false;
            // 
            // pcbOngTren2
            // 
            this.pcbOngTren2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbOngTren2.BackgroundImage")));
            this.pcbOngTren2.Location = new System.Drawing.Point(582, -770);
            this.pcbOngTren2.Name = "pcbOngTren2";
            this.pcbOngTren2.Size = new System.Drawing.Size(271, 1001);
            this.pcbOngTren2.TabIndex = 2;
            this.pcbOngTren2.TabStop = false;
            // 
            // pcbOngDuoi2
            // 
            this.pcbOngDuoi2.Image = ((System.Drawing.Image)(resources.GetObject("pcbOngDuoi2.Image")));
            this.pcbOngDuoi2.Location = new System.Drawing.Point(582, 302);
            this.pcbOngDuoi2.Name = "pcbOngDuoi2";
            this.pcbOngDuoi2.Size = new System.Drawing.Size(279, 498);
            this.pcbOngDuoi2.TabIndex = 3;
            this.pcbOngDuoi2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbPlay
            // 
            this.pcbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pcbPlay.BackgroundImage = global::FlappyBird.Properties.Resources.nut_play_removebg;
            this.pcbPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPlay.Location = new System.Drawing.Point(12, 12);
            this.pcbPlay.Name = "pcbPlay";
            this.pcbPlay.Size = new System.Drawing.Size(50, 50);
            this.pcbPlay.TabIndex = 5;
            this.pcbPlay.TabStop = false;
            this.pcbPlay.Click += new System.EventHandler(this.pcbPlay_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điểm: ";
            // 
            // conchim
            // 
            this.conchim.BackColor = System.Drawing.Color.Transparent;
            this.conchim.BackgroundImage = global::FlappyBird.Properties.Resources.Chim_0nen;
            this.conchim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conchim.Location = new System.Drawing.Point(170, 253);
            this.conchim.Name = "conchim";
            this.conchim.Size = new System.Drawing.Size(60, 40);
            this.conchim.TabIndex = 7;
            this.conchim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 664);
            this.Controls.Add(this.conchim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbPlay);
            this.Controls.Add(this.pcbOngDuoi2);
            this.Controls.Add(this.pcbOngTren2);
            this.Controls.Add(this.pcbOngDuoi1);
            this.Controls.Add(this.pcbOngTren1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngTren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngDuoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngTren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOngDuoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbOngTren1;
        private System.Windows.Forms.PictureBox pcbOngDuoi1;
        private System.Windows.Forms.PictureBox pcbOngTren2;
        private System.Windows.Forms.PictureBox pcbOngDuoi2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbPlay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox conchim;
    }
}

