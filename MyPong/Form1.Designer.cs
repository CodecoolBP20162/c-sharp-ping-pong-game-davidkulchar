namespace MyPong
{
    partial class space
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
            this.pong = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pong
            // 
            this.pong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pong.Location = new System.Drawing.Point(231, 569);
            this.pong.Margin = new System.Windows.Forms.Padding(2);
            this.pong.Name = "pong";
            this.pong.Size = new System.Drawing.Size(200, 21);
            this.pong.TabIndex = 2;
            this.pong.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ball.Location = new System.Drawing.Point(709, 209);
            this.ball.Margin = new System.Windows.Forms.Padding(2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 18);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 24;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // screen
            // 
            this.screen.Controls.Add(this.label2);
            this.screen.Controls.Add(this.pong);
            this.screen.Location = new System.Drawing.Point(0, 24);
            this.screen.Margin = new System.Windows.Forms.Padding(2);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(769, 601);
            this.screen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lbHs
            // 
            this.lbHs.AutoSize = true;
            this.lbHs.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbHs.Location = new System.Drawing.Point(12, 9);
            this.lbHs.Name = "lbHs";
            this.lbHs.Size = new System.Drawing.Size(0, 19);
            this.lbHs.TabIndex = 3;
            // 
            // space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(768, 614);
            this.Controls.Add(this.lbHs);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "space";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pong;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHs;
    }
}

