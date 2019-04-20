using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x_ong1, x_ong2;

        int diemso = 0;

        int KhoangcachHaiOng = 200;
        int x_ongtren1, y_ongtren1;
        int x_ongduoi1,y_ongduoi1;
        int x_conchim, y_conchim;
       
        int x_ongtren2,y_ongtren2;
        int dem = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            if (y_conchim + conchim.Height <= this.Height)
            {
                y_conchim += 10;
                conchim.Location = new Point(x_conchim, y_conchim);
                if (x_conchim + conchim.Width >= x_ong1 && x_conchim + conchim.Width <= x_ong1 + pcbOngTren1.Width)
                {
                    if (y_conchim <= 1000 + y_ongtren1 || y_conchim+conchim.Height >= y_ongduoi1)
                    {
                        timer1.Stop();
                        conchim.BackgroundImage = new Bitmap(@"D:\NodeJS\FlappyBird1\FlappyBird\FlappyBird\Picture\ChimChet.png");
                        timer2.Stop();
                        //music game over
                        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                        player.URL = "1.wav.mp3";
                        player.controls.play();

                        conchim.BackgroundImage = new Bitmap(@"C:\Users\asus\source\repos\FlappyBird\FlappyBird\Picture\ChimChet.png");
                        if (MessageBox.Show("Điểm: " + diemso.ToString() + "\n" + "Bạn có muốn chơi lại không?",
                            "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            Application.Exit();
                        else
                        {
                            this.Hide();
                            Form1 fr = new Form1();
                            fr.Show();
                        }

                    }
                }
                if (x_conchim + conchim.Width >= x_ong2 && x_conchim + conchim.Width <= x_ong2 + pcbOngTren2.Width)
                {
                    if (y_conchim <= 1000 + y_ongtren2 || y_conchim + conchim.Height >= y_ongduoi2)
                    {
                        timer1.Stop();
                        conchim.BackgroundImage = new Bitmap(@"D:\NodeJS\FlappyBird1\FlappyBird\FlappyBird\Picture\Chim-0nen.png");
                        timer2.Stop();
                        //music game over
                        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
                        player.URL = "1.wav.mp3";
                        player.controls.play();

                        conchim.BackgroundImage = new Bitmap(@"C:\Users\asus\source\repos\FlappyBird\FlappyBird\Picture\ChimChet.png");
                        if (MessageBox.Show("Điểm: " + diemso.ToString() + "\n" + "Bạn có muốn chơi lại không?",
                            "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            Application.Exit();
                        else
                        {
                            this.Hide();
                            Form1 fr = new Form1();
                            fr.Show();
                        }

                    }
                }
            }
            else
            {
                timer1.Start();

               
            }
        }

        private void pcbOngTren1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                y_conchim -= 50;
              

            }
        }

        private void pcbPlay_Click(object sender, EventArgs e)
        {
           
            dem++;
            if (dem % 2 != 0)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
           
        }

        int x_ongduoi2, y_ongduoi2;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Size sizeplay = new Size(50, 50);
            pcbPlay.Size = sizeplay;
            timer1.Interval = 1;
            timer2.Interval = 50;
            //timer1.Start();
            //full screen 
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            x_ong1 =this.Width+ 300;
            y_ongtren1 = -800;
          
            y_ongduoi1 = (1000 + y_ongtren1) + KhoangcachHaiOng;
            //x_ong2 = x_ong1+ pcbOngTren1.Width + 400;
            x_ong2 = x_ong1 + pcbOngTren1.Width + 400;
          
            y_ongtren2 = -800;

           
            y_ongduoi2 = (1000 + y_ongtren1) + KhoangcachHaiOng;
            Size size = new Size(275, 1000);
            pcbOngDuoi1.Size = size;
            pcbOngTren1.Size = size;



            pcbOngTren1.Location = new Point(x_ong1, y_ongtren1);
            pcbOngDuoi1.Location = new Point(x_ong1, y_ongduoi1);
            pcbOngTren2.Location = new Point(x_ong2, y_ongtren2);
            pcbOngDuoi2.Location = new Point(x_ong2, y_ongduoi2);
            //con chim
            Size sizeChim = new Size(101,80);
            conchim.Size = sizeChim;
            x_conchim = conchim.Location.X;
            y_conchim = conchim.Location.Y;

           
      
          
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ham chong rung
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            x_ong1 -= 10;
            x_ong2 -= 10;
            int KhoangcachHaiOng = 200;

            pcbOngTren1.Location = new Point(x_ong1, y_ongtren1);
            pcbOngDuoi1.Location = new Point(x_ong1, y_ongduoi1);
            pcbOngTren2.Location = new Point(x_ong2, y_ongtren2);
            pcbOngDuoi2.Location = new Point(x_ong2, y_ongduoi2);

            if (pcbOngTren1.Width + x_ong1 <= 0)
            {
                diemso++;
                Random rd = new Random();
                y_ongtren1 = rd.Next(-800, -700);
                y_ongduoi1 = (1000 + y_ongtren1) + KhoangcachHaiOng;
                x_ong1 = 500 + pcbOngTren2.Width + 400;
                pcbOngTren1.Location = new Point(x_ong1, y_ongtren1);
                pcbOngDuoi1.Location = new Point(x_ong1, y_ongduoi1);
            }
            if (x_ong2 + pcbOngTren2.Width <= 0)
            {
                diemso++;
          
                Random rd = new Random();
                y_ongtren2 = rd.Next(-700, -400);
                y_ongduoi2 = (1000 + y_ongtren2) + KhoangcachHaiOng;
                //x_ong2 = x_ong1 + pcbOngTren1.Width + 400;
                x_ong2 = 500 + pcbOngTren1.Width + 400;
                pcbOngTren2.Location = new Point(x_ong2, y_ongtren2);
                pcbOngDuoi2.Location = new Point(x_ong2, y_ongduoi2);
            }
            label1.Text = "Điểm" +  diemso.ToString();



        }

    }
}
