namespace ClickerGame
{
    partial class Form6
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
            this.player1 = new System.Windows.Forms.FlowLayoutPanel();
            this.player2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ball = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.White;
            this.player1.Location = new System.Drawing.Point(50, 163);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(40, 100);
            this.player1.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.White;
            this.player2.Location = new System.Drawing.Point(527, 163);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(40, 100);
            this.player2.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(105, 208);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form6_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel player1;
        private System.Windows.Forms.FlowLayoutPanel player2;
        private System.Windows.Forms.FlowLayoutPanel ball;
        private System.Windows.Forms.Timer timer1;
    }
}