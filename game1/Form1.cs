using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Location = new Point(ball.Location.X + yerX, ball.Location.Y + yerY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            int a = 3;
        }
    }
}
