using System;
using System.Drawing;
using System.Windows.Forms;


namespace CatchBotton
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int newX = rand.Next(0, maxX);
            int newY = rand.Next(0, maxY);
            button1.Location = new Point(newX, newY);

        }
    }
}
