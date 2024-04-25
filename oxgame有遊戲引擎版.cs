namespace ox
{
    using System;

    class OXGameEngine
    {
        private char[,] board; // 遊戲板
        private char currentPlayer; // 當前玩家

        public OXGameEngine()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // 初始化遊戲板，所有格子設為空白
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        public void DisplayGameScreen()
        {
            // 顯示遊戲畫面，包括遊戲狀況和分隔線
            Console.WriteLine("遊戲中的畫面：");
            Console.WriteLine("  0 1 2"); // 列號
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i} "); // 行號
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{board[i, j]}");
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                {
                    Console.WriteLine("  -----");
                }
            }
        }

        public void Play()
        {
            Console.WriteLine("歡迎來到OX遊戲！");

            while (true)
            {
                Console.WriteLine("  0 1 2"); // 列號
                DisplayGameScreen();
                Console.WriteLine($"輪到玩家 {currentPlayer} 下棋，請輸入行和列（範圍：0-2，以空格分隔）：");
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col))
                {
                    Console.WriteLine("輸入無效，請重新輸入！");
                    continue;
                }

                if (PlaceMark(row, col))
                {
                    if (CheckForWin())
                    {
                        DisplayGameScreen();
                        Console.WriteLine($"恭喜玩家 {currentPlayer} 贏得了遊戲！");
                        break;
                    }
                    else if (CheckForDraw())
                    {
                        DisplayGameScreen();
                        Console.WriteLine("遊戲結束，平局！");
                        break;
                    }
                    else
                    {
                        SwitchPlayer();
                    }
                }
                else
                {
                    Console.WriteLine("此位置無效或已被佔據，請重新輸入！");
                }
            }
        }

        private bool PlaceMark(int row, int col)
        {
            // 下棋並檢查位置是否有效
            if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != ' ')
            {
                return false;
            }

            board[row, col] = currentPlayer;
            return true;
        }

        private void SwitchPlayer()
        {
            // 切換玩家
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        private bool CheckForWin()
        {
            // 檢查是否有玩家贏得遊戲
            // 檢查行和列
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true; // 行連成一直線
                }
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true; // 列連成一直線
                }
            }

            // 檢查對角線
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true; // 左上角到右下角連成一直線
            }
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true; // 右上角到左下角連成一直線
            }

            return false; // 沒有玩家贏得遊戲
        }

        private bool CheckForDraw()
        {
            // 檢查遊戲是否平局
            // 如果所有格子都被填滿但沒有玩家贏，則返回 true，否則返回 false
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false; // 還有空格子，遊戲繼續進行
                    }
                }
            }
            // 所有格子都被填滿但沒有玩家贏，遊戲平局
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OXGameEngine gameEngine = new OXGameEngine();
            gameEngine.Play();
        }
    }
}
