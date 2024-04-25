namespace ox
{
    using System;

    class TicTacToe
    {
        private char[,] board; // 用於存儲OX遊戲板的二維陣列
        private char currentPlayer; // 當前玩家

        public TicTacToe()
        {
            board = new char[3, 3]; // 創建一個3x3的遊戲板
            currentPlayer = 'X'; // 從玩家X開始
            InitializeBoard();
        }

        // 初始化遊戲板，將所有格子設為空白
        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        // 顯示遊戲板
        public void DisplayBoard()
        {
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

        // 檢查是否有玩家贏得遊戲或遊戲結束
        public bool CheckForWin()
        {
            // 檢查行和列
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
            }

            // 檢查對角線
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            // 檢查是否所有格子都被填滿
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false; // 還有空格子，遊戲還未結束
                    }
                }
            }

            // 所有格子都被填滿，遊戲平局
            return true;
        }

        // 嘗試在指定位置下棋
        public bool PlaceMark(int row, int col)
        {
            if (row < 0 || row >= 3 || col < 0 || col >= 3 || board[row, col] != ' ')
            {
                return false; // 位置無效或已被佔據
            }

            board[row, col] = currentPlayer;
            return true;
        }

        // 切換玩家
        public void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        // 主遊戲循環
        public void PlayGame()
        {
            Console.WriteLine("歡迎來到OX遊戲！");
            DisplayBoard();

            while (!CheckForWin())
            {
                Console.WriteLine($"輪到玩家 {currentPlayer} 下棋，請輸入行和列（範圍：0-2，以空格分隔）：");
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col))
                {
                    Console.WriteLine("輸入無效，請重新輸入！");
                    continue;
                }

                if (PlaceMark(row, col))
                {
                    DisplayBoard();
                    if (CheckForWin())
                    {
                        Console.WriteLine($"恭喜玩家 {currentPlayer} 贏得了遊戲！");
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

            Console.WriteLine("遊戲結束！");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            game.PlayGame();
        }
    }
}
