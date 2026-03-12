using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace CatchBotton
{
    public partial class Form1 : Form
    {
        private const int START_WIDTH = 100;
        private const int START_HEIGHT = 40;
        private int score = 0;
        private int missCount = 0;
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

            score += 100;
            

            MessageBox.Show("잡았다! 100점 획득!");
            int newWidth = (int)(button1.Width * 0.9);
            int newHeight = (int)(button1.Height * 0.9);

            // 최소 크기 제한 (너무 작아서 안 보이면 안 되니까요!)
            if (newWidth > 5 && newHeight > 5)
            {
                button1.Size = new Size(newWidth, newHeight);
            }

            // 3. 성공 알림
            MessageBox.Show("잡았다! 버튼이 더 작아집니다!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;
            int newX = rand.Next(0, maxX);
            int newY = rand.Next(0, maxY);
            button1.Location = new Point(newX, newY);
            // 10점 감점
            score -= 10;
            

            // 버튼을 랜덤한 위치로 이동
            int x = rand.Next(0, this.ClientSize.Width - button1.Width);
            int y = rand.Next(0, this.ClientSize.Height - button1.Height);
            button1.Location = new Point(x, y);
            if (button1.Enabled == false) return;

            // 1. 점수 감점 및 놓친 횟수 증가
            score -= 10;
            missCount++;
            

            // 2. 20번 놓쳤는지 확인
            if (missCount >= 20)
            {
                GameOver();
                return; // 게임 오버 시 버튼 이동을 하지 않고 종료
            }

        }
        private void GameOver()
        {
            // 모든 버튼 비활성화 (화면에 버튼이 하나라면 이것만)
            button1.Enabled = false;

            // 메시지 출력
            MessageBox.Show("20번이나 놓치셨네요. Game Over!", "게임 종료");
        }

       
       

       
        }
    }
