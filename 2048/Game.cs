using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
	public enum Direction { UP, DOWN, LEFT, RIGHT }

	public class GameBoardStatus : EventArgs
	{
		public int[,] gameBoard;

		public GameBoardStatus(int[,] gameBoard)
		{
			this.gameBoard = (int[,])gameBoard.Clone();
		}
	}

	public class Game
	{
		private const int PERCENTAGE_OF_4_APPEARANCE = 20;

		private int[,] gameBoard;

		public event EventHandler GameBoardModified;
		public event EventHandler GameOver;

		public Game()
		{
			gameBoard = new int[4, 4];
		}

		public void Start()
		{
			AddNewNum();
			AddNewNum();

			GameBoardModified?.Invoke(this, new GameBoardStatus(gameBoard));
		}

		private void AddNewNum()
		{
			Random rand = new Random();

			int x, y;

			while (true)
			{
				x = rand.Next(4);
				y = rand.Next(4);

				if (gameBoard[x, y] == 0)
				{
					break;
				}
			}

			int percent = rand.Next(100);

			if (percent < PERCENTAGE_OF_4_APPEARANCE)
			{
				gameBoard[x, y] = 4;
			}
			else
			{
				gameBoard[x, y] = 2;
			}
		}

		public void Move(Direction dir)
		{
			int movement = 0;

			switch (dir)
			{
				case Direction.UP:
					movement = MoveUp();
					break;

				case Direction.DOWN:
					movement = MoveDown();
					break;

				case Direction.LEFT:
					movement = MoveLeft();
					break;

				case Direction.RIGHT:
					movement = MoveRight();
					break;
			}

			if (movement != 0)
			{
				AddNewNum();
				GameBoardModified?.Invoke(this, new GameBoardStatus(gameBoard));
			}

			if (MoveAble() == false)
			{
				GameOver?.Invoke(this, EventArgs.Empty);
			}
		}

		private int MoveUp()
		{
			return _MoveUp(gameBoard);
		}

		private int MoveDown()
		{
			return _MoveDown(gameBoard);
		}

		private int MoveLeft()
		{
			return _MoveLeft(gameBoard);
		}

		private int MoveRight()
		{
			return _MoveRight(gameBoard);
		}

		private bool MoveAble()
		{
			int[,] cloneForMoveUp = (int[,])gameBoard.Clone();
			int[,] cloneForMoveDown = (int[,])gameBoard.Clone();
			int[,] cloneForMoveLeft = (int[,])gameBoard.Clone();
			int[,] cloneForMoveRight = (int[,])gameBoard.Clone();

			int movement = _MoveUp(cloneForMoveUp) + _MoveDown(cloneForMoveDown) + _MoveLeft(cloneForMoveLeft) + _MoveRight(cloneForMoveRight);

			if(movement == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		#region /* Move 메서드들의 실체 */
		/// <summary>
		/// int[4] 배열 input을 받아서 그 안의 원소들을 0번째 원소 쪽으로 움직이고 총 이동횟수를 return한다.
		/// </summary>
		/// <param name="line">움직일 int[4] 배열</param>
		/// <returns>움직인 횟수</returns>
		private int _MoveLine(int[] input)
		{
			int movement = 0;

			//1. 우선 0번째 원소 쪽으로 모든 원소들을 모은다.
			int numNum = 0;
			for(int i = 0; i < input.Length; i++)
			{
				if(input[i] != 0) //input[i]에 수가 있으면
				{
					if(i != numNum) //그 수가 올바른 위치에 있지 않을 때만
					{
						input[numNum] = input[i];
						input[i] = 0;
						movement++;
					}

					numNum++;
				}
			}

			//2. 0번째 원소부터 합칠 수 있는 수가 있는지 검사하고, 만약 있으면 합친다.
			for(int i = 0; i < numNum - 1; i++)
			{
				if(input[i] == input[i + 1])
				{
					input[i] *= 2;
					input[i + 1] = 0;
					movement++;
					i++; //(i + 1)번째 원소는 검사할 필요가 없다.
				}
			}

			//3. 다시 0번째 원소 쪽으로 모든 원소를 모은다.
			int ptr = 0;
			for (int i = 0; i < numNum; i++)
			{
				if(input[i] != 0)
				{
					if(i != ptr)
					{
						input[ptr] = input[i];
						input[i] = 0;
						movement++;
					}
					
					ptr++;
				}
			}

			return movement;
		}

		private int _MoveUp(int[,] gameBoard)
		{
			int movement = 0;

			for (int i = 0; i < 4; i++)
			{
				int[] input = new int[4] { gameBoard[0, i], gameBoard[1, i], gameBoard[2, i], gameBoard[3, i] };

				movement += _MoveLine(input);

				for(int j = 0; j < 4; j++)
				{
					gameBoard[j, i] = input[j];
				}
			}

			return movement;
		}

		private int _MoveDown(int[,] gameBoard)
		{
			int movement = 0;

			for (int i = 0; i < 4; i++)
			{
				int[] input = new int[4] { gameBoard[3, i], gameBoard[2, i], gameBoard[1, i], gameBoard[0, i] };

				movement += _MoveLine(input);

				for (int j = 0; j < 4; j++)
				{
					gameBoard[3 - j, i] = input[j];
				}
			}

			return movement;
		}

		private int _MoveLeft(int[,] gameBoard)
		{
			int movement = 0;

			for (int i = 0; i < 4; i++)
			{
				int[] input = new int[4] { gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2], gameBoard[i, 3] };

				movement += _MoveLine(input);

				for (int j = 0; j < 4; j++)
				{
					gameBoard[i, j] = input[j];
				}
			}

			return movement;
		}

		private int _MoveRight(int[,] gameBoard)
		{
			int movement = 0;

			for (int i = 0; i < 4; i++)
			{
				int[] input = new int[4] { gameBoard[i, 3], gameBoard[i, 2], gameBoard[i, 1], gameBoard[i, 0] };

				movement += _MoveLine(input);

				for (int j = 0; j < 4; j++)
				{
					gameBoard[i, 3 - j] = input[j];
				}
			}

			return movement;
		}
		#endregion
	}
}
