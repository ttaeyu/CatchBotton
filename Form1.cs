using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace CatchBotton
{
    public partial class Form1 : Form
    {
        private int score = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateTitleScore()
        {
            this.Text = "현재 점수: " + score + "점";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("드디어 잡으셨네요! 축하합니다!", "검거 성공",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            score += 100;
            UpdateTitleScore();

            MessageBox.Show("잡았다! 100점 획득!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int newX = rand.Next(0, maxX);
            int newY = rand.Next(0, maxY);
            button1.Location = new Point(newX, newY);
            // 10점 감점
            score -= 10;
            UpdateTitleScore();

            // 버튼을 랜덤한 위치로 이동
            int x = rand.Next(0, this.ClientSize.Width - button1.Width);
            int y = rand.Next(0, this.ClientSize.Height - button1.Height);
            button1.Location = new Point(x, y);
        }
    }
}
