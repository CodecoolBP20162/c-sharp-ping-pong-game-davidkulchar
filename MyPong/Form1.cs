using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPong
{
    public partial class space : Form
    {
        private int speedLeft = 4;
        private int speedTop = 4;
        public int hungarocellSnake = 0;
        bool pause = false;
        private int gameLevel = 1;
        private int progress = 0;

        public space()
        {
            Cursor.Hide();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pause = !pause;
                timer1.Enabled = !timer1.Enabled;
            }

            if (e.KeyCode == Keys.Escape) Close();

            if (!pause)
            {
                if (e.KeyCode == Keys.Right || Keys.D == e.KeyCode) if (pong.Right < screen.Right) pong.Left += 20;

                if (e.KeyCode == Keys.Left || Keys.A == e.KeyCode) if (pong.Left > screen.Left) pong.Left -= 20;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point ballPoint = ball.Location;
            ballPoint.X += speedLeft;
            ballPoint.Y += speedTop;
            ball.Location = ballPoint;

            if (ball.Right >= screen.Right || ball.Left <= screen.Left) this.speedLeft = -speedLeft;
            if (ball.Top <= screen.Top) this.speedTop = -speedTop;
            if (ball.Right <= pong.Right +ball.Width && ball.Left >= pong.Left -ball.Width && pong.Top <= ball.Top) CollisionHandling();
            if (ball.Bottom > pong.Bottom + 30) EndGame(); 
        }

        private void EndGame()
        {
            timer1.Enabled = false;
            String mess = "Kilyukadt a labda?! \nSzóljatok a Pistikének, hogy ne a szögesdróton játsszon!" + "\nHungarocellKígyó: " + hungarocellSnake + "\nSzint: " + gameLevel;
            MessageBox.Show(mess, "Shiiiiet!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }

        private void CollisionHandling()
        {
            if (-15 < speedTop && speedTop < 15) this.speedTop = -speedTop - 1;
            else if (gameLevel == 6) this.speedTop = -speedTop - 1;
            else if (gameLevel == 7)
            { 
                pong.Width -= 5;
                speedTop = -speedTop;
            }
            else speedTop = -speedTop;
            hungarocellSnake++;
            if (hungarocellSnake % 5 == 0)
                gameLevel++;
            if (progress == 80) progress = 0;
            else progress += 20;
            if (gameLevel == 5) pong.Width -= 10;
            lbHs.Text = "HungarocellSnakes: " + hungarocellSnake + "            " + "Level: " + gameLevel + "           " + "Progress: " + progress +"%";
        }
    }
}
