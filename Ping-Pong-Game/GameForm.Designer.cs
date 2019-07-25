namespace Ping_Pong_Game
{
    partial class playGroundForm
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
            this.playGround = new System.Windows.Forms.Panel();
            this.gameOver_label = new System.Windows.Forms.Label();
            this.points_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.BackColor = System.Drawing.SystemColors.Control;
            this.playGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playGround.Controls.Add(this.gameOver_label);
            this.playGround.Controls.Add(this.points_label);
            this.playGround.Controls.Add(this.score_label);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(828, 657);
            this.playGround.TabIndex = 0;
            // 
            // gameOver_label
            // 
            this.gameOver_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameOver_label.AutoSize = true;
            this.gameOver_label.BackColor = System.Drawing.SystemColors.Control;
            this.gameOver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOver_label.Location = new System.Drawing.Point(305, 187);
            this.gameOver_label.Name = "gameOver_label";
            this.gameOver_label.Size = new System.Drawing.Size(220, 176);
            this.gameOver_label.TabIndex = 4;
            this.gameOver_label.Text = "Game Over\r\nPress\r\nF1 - Restrat\r\nEsc - Exit\r\n";
            this.gameOver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.BackColor = System.Drawing.SystemColors.Control;
            this.points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points_label.Location = new System.Drawing.Point(131, 9);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(41, 44);
            this.points_label.TabIndex = 3;
            this.points_label.Text = "0";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.SystemColors.Control;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.81132F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_label.Location = new System.Drawing.Point(12, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(130, 44);
            this.score_label.TabIndex = 2;
            this.score_label.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(20, 56);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.racket.Location = new System.Drawing.Point(279, 608);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // playGroundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 657);
            this.Controls.Add(this.playGround);
            this.Name = "playGroundForm";
            this.Text = "PlayGroundForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayGroundForm_KeyDown);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label gameOver_label;
    }
}

