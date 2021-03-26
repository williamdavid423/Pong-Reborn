using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Reborn
{
    public partial class Form1 : Form
    {
        int scene = 0;

        int paddle1X = 10;
        int paddle1Y = 100;
        int player1Score = 0;

        int paddle2X = 10;
        int paddle2Y = 300;
        int player2Score = 0;

        int paddleWidth = 10;
        int paddleHeight = 60;
        int paddleSpeed = 4;

        int ballX = 295;
        int ballY = 195;
        int ballXSpeed = 6;
        int ballYSpeed = 6;
        int ballWidth = 10;
        int ballHeight = 10;



        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool aDown = false;
        bool dDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;


        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (scene)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
        }
    }
}
