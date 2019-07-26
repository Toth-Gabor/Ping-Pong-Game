using System.Windows.Forms;

namespace Ping_Pong_Game
{
    public partial class playGroundForm : Form
    {
        public int speed_left = 10;
        public int speed_top = 10;
        public int points = 0;
        private readonly int maxLeft;
        private readonly int maxRight;



        public playGroundForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            Cursor.Hide();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playGround.Bottom - (playGround.Bottom / 10);
            gameOver_label.Left = (playGround.Width / 2) - (gameOver_label.Width / 2);
            gameOver_label.Top = (playGround.Height / 2) - (gameOver_label.Height / 2);
            gameOver_label.Visible = false;
            score_label.SendToBack();
            points_label.SendToBack();
            maxLeft = 0;
            maxRight = playGround.Width - racket.Width;

        }

        private void PlayGroundForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }
            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Stop();
                }
                else if (timer1.Enabled == false)
                {
                    timer1.Start();
                }

            }

            if (e.KeyCode == Keys.F1)
            {
                ball.Left = 50;
                ball.Top = 50;
                speed_left = 10;
                speed_top = 10;
                points = 0;
                points_label.Text = "0";
                timer1.Enabled = true;
                gameOver_label.Visible = false;
            }

            if(e.KeyCode == Keys.F2)
            {
                ball.Left = 50;
                ball.Top = 50;
                speed_left = 15;
                speed_top = 15;
                points = 0;
                points_label.Text = "0";
                timer1.Enabled = true;
                gameOver_label.Visible = false;
                racket.Width = 100; 
            }

            if (e.KeyCode == Keys.F3)
            {
                ball.Left = 50;
                ball.Top = 50;
                speed_left = 20;
                speed_top = 20;
                points = 0;
                points_label.Text = "0";
                timer1.Enabled = true;
                gameOver_label.Visible = false;
                racket.Width = 50;

            }

        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                points_label.Text = points.ToString();
            }

            if (racket.Location.X < maxLeft)
            {
                racket.Left = maxLeft;
            }
            else if (racket.Location.X > maxRight)
            {
                racket.Left = maxRight;
            }

            if (ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playGround.Bottom)
            {
                timer1.Enabled = false;
                gameOver_label.Visible = true;
            }
        }

    }
}
