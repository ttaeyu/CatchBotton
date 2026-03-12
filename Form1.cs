using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


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
            MessageBox.Show("드디어 잡으셨네요! 축하합니다!", "검거 성공",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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
