using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int score = 100;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("杉田夏葵");
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Left = fpos.X-label3.Width/2;
            //label3.Left = fpos.X + (label3.Left - label3.Right) / 2; これでもできる(やってることは同じ)
            label3.Top = fpos.Y-label3.Height/2;
            label3.Text = $"{fpos.X},{fpos.Y}";//マウスの座標表示

            timer1.Enabled = true;

            label1.Left += vx;
            label1.Top += vy;

            score -= 1;
            label2.Text = $"score {score}";
            //label2.Text = ("score "+ score); //これでもできる

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) * 110 / 100;// * 110 / 10は10%
                
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) * 110 / 100;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) * 110 / 100;
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) * 110 / 100;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
