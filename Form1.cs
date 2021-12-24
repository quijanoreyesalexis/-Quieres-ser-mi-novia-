using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieresSerMiNovia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            buttonsi.TabStop = false;
            buttonno.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - buttonno.Width);
            int y = r.Next(0, this.Height - buttonno.Height);
            buttonno.Location = new Point(x, y);
        }

        private void buttonno_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (buttonno.Location == buttonsi.Location || buttonno.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void buttonsi_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
