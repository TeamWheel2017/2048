using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
	public partial class Form1 : Form
	{
		private Game game;

		public Form1()
		{
			InitializeComponent();

			game = new Game();

			game.GameBoardModified += DrawGameBoard;
			game.GameOver += GameOver;

			game.Start();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == Keys.Up)
			{
				game.Move(Direction.UP);
			}

			if(keyData == Keys.Down)
			{
				game.Move(Direction.DOWN);
			}

			if(keyData == Keys.Left)
			{
				game.Move(Direction.LEFT);
			}

			if(keyData == Keys.Right)
			{
				game.Move(Direction.RIGHT);
			}	
			
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void GameOver(object sender, EventArgs e)
		{
			MessageBox.Show("Game Over!", "Game Over!", MessageBoxButtons.OK);
		}

		private Color NumToColor(int num)
		{
			switch (num)
			{
				case 0://Empty
					return base.BackColor;
				case 2://1
					return Color.FromArgb(255, 255, 255);
				case 4://2
					return Color.FromArgb(200, 255, 255);
				case 8://3
					return Color.FromArgb(255, 200, 255);
				case 16://4
					return Color.FromArgb(255, 255, 200);
				case 32://5
					return Color.FromArgb(200, 200, 255);
				case 64://6
					return Color.FromArgb(200, 255, 200);
				case 128://7
					return Color.FromArgb(255, 200, 200);
				case 256://8
					return Color.FromArgb(150, 200, 200);
				case 512://9
					return Color.FromArgb(200, 150, 200);
				case 1024://10
					return Color.FromArgb(200, 200, 150);
				case 2048://11
					return Color.FromArgb(150, 150, 200);
				case 4096://12
					return Color.FromArgb(150, 200, 150);
				case 8192://13
					return Color.FromArgb(200, 150, 150);
				case 16384://14
					return Color.FromArgb(100, 150, 150);
				case 32768://15
					return Color.FromArgb(150, 100, 150);
				case 65536://16
					return Color.FromArgb(150, 150, 100);
				case 131072://17
					return Color.FromArgb(100, 100, 100);
				default:
					return base.BackColor;
			}
		}

		private String NumToText(int num)
		{
			if (num == 0)
			{
				return "";
			}
			else
			{
				return num.ToString();
			}
		}

		private void DrawGameBoard(object sender, EventArgs e)
		{
			int[,] gameBoard = (e as GameBoardStatus).gameBoard;

			cell00.BackColor = NumToColor(gameBoard[0, 0]);
			cell00.Text = NumToText(gameBoard[0, 0]);

			cell01.BackColor = NumToColor(gameBoard[0, 1]);
			cell01.Text = NumToText(gameBoard[0, 1]);

			cell02.BackColor = NumToColor(gameBoard[0, 2]);
			cell02.Text = NumToText(gameBoard[0, 2]);

			cell03.BackColor = NumToColor(gameBoard[0, 3]);
			cell03.Text = NumToText(gameBoard[0, 3]);

			cell10.BackColor = NumToColor(gameBoard[1, 0]);
			cell10.Text = NumToText(gameBoard[1, 0]);

			cell11.BackColor = NumToColor(gameBoard[1, 1]);
			cell11.Text = NumToText(gameBoard[1, 1]);

			cell12.BackColor = NumToColor(gameBoard[1, 2]);
			cell12.Text = NumToText(gameBoard[1, 2]);

			cell13.BackColor = NumToColor(gameBoard[1, 3]);
			cell13.Text = NumToText(gameBoard[1, 3]);

			cell20.BackColor = NumToColor(gameBoard[2, 0]);
			cell20.Text = NumToText(gameBoard[2, 0]);

			cell21.BackColor = NumToColor(gameBoard[2, 1]);
			cell21.Text = NumToText(gameBoard[2, 1]);

			cell22.BackColor = NumToColor(gameBoard[2, 2]);
			cell22.Text = NumToText(gameBoard[2, 2]);

			cell23.BackColor = NumToColor(gameBoard[2, 3]);
			cell23.Text = NumToText(gameBoard[2, 3]);

			cell30.BackColor = NumToColor(gameBoard[3, 0]);
			cell30.Text = NumToText(gameBoard[3, 0]);

			cell31.BackColor = NumToColor(gameBoard[3, 1]);
			cell31.Text = NumToText(gameBoard[3, 1]);

			cell32.BackColor = NumToColor(gameBoard[3, 2]);
			cell32.Text = NumToText(gameBoard[3, 2]);

			cell33.BackColor = NumToColor(gameBoard[3, 3]);
			cell33.Text = NumToText(gameBoard[3, 3]);

			Invalidate();
		}

		private void 새게임ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("새로운 게임을 시작합니다. 계속하시겠습니까?", "새 게임", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				game = null;

				game = new Game();

				game.GameBoardModified += DrawGameBoard;
				game.GameOver += GameOver;

				game.Start();
			}
		}

		private void 종료qToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("게임을 종료합니다. 계속하시겠습니까?", "게임 종료", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new ProgramInfo()).ShowDialog();
		}

		private void 게임방법ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new HowTo()).ShowDialog();
		}
	}
}
