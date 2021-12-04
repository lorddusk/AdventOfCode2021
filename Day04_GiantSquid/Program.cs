using System;
using System.Collections.Generic;
using System.Linq;
using Day04_GiantSquid.Models;
using StringUtilities;

namespace Day04_GiantSquid
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day04");

            int finalScore = SimpleBingo(stringInput);
            Console.WriteLine($"Part One: {finalScore} is the final score of the winning board.");
            finalScore = AdvancedBingo(stringInput);
            Console.WriteLine($"Part One: {finalScore} is the final score of the losing board.");
        }

        public static int SimpleBingo(string[] input)
        {
            (string[] draws, List<Board> boards) = SetupBingo(input);
            int draw = 0;
            int sum = 0;
            foreach (string drawS in draws)
            {
                draw = Convert.ToInt32(drawS);
                foreach (Board board in boards)
                {
                    foreach (BoardCell cell in board.cells)
                    {
                        if (cell.number == draw)
                        {
                            cell.marked = true;
                        }
                    }
                }

                foreach (Board board in boards)
                {
                    int rowX0Correct = 0;
                    int rowX1Correct = 0;
                    int rowX2Correct = 0;
                    int rowX3Correct = 0;
                    int rowX4Correct = 0;
                    int rowY0Correct = 0;
                    int rowY1Correct = 0;
                    int rowY2Correct = 0;
                    int rowY3Correct = 0;
                    int rowY4Correct = 0;

                    foreach (BoardCell cell in board.cells)
                    {
                        if (cell.x == 0 && cell.marked) rowX0Correct++;
                        if (cell.x == 1 && cell.marked) rowX1Correct++;
                        if (cell.x == 2 && cell.marked) rowX2Correct++;
                        if (cell.x == 3 && cell.marked) rowX3Correct++;
                        if (cell.x == 4 && cell.marked) rowX4Correct++;
                        if (cell.y == 0 && cell.marked) rowY0Correct++;
                        if (cell.y == 1 && cell.marked) rowY1Correct++;
                        if (cell.y == 2 && cell.marked) rowY2Correct++;
                        if (cell.y == 3 && cell.marked) rowY3Correct++;
                        if (cell.y == 4 && cell.marked) rowY4Correct++;

                        if (rowX0Correct == 5 || rowX1Correct == 5 || rowX2Correct == 5 || rowX3Correct == 5 ||
                            rowX4Correct == 5 ||
                            rowY0Correct == 5 || rowY1Correct == 5 || rowY2Correct == 5 || rowY3Correct == 5 ||
                            rowY4Correct == 5)
                        {
                            foreach (BoardCell cellWinners in board.cells)
                            {
                                if (!cellWinners.marked)
                                {
                                    sum += cellWinners.number;
                                }
                            }

                            return sum * draw;
                        }
                    }
                }
            }

            return 0;
        }

        public static int AdvancedBingo(string[] input)
        {
            (string[] draws, List<Board> boards) = SetupBingo(input);
            List<Board> copyBoards = new List<Board>();
            foreach (Board board in boards)
            {
                copyBoards.Add(board);
            }

            int draw = 0;
            int sum = 0;
            foreach (string drawS in draws)
            {
                draw = Convert.ToInt32(drawS);
                foreach (Board board in boards)
                {
                    foreach (BoardCell cell in board.cells)
                    {
                        if (cell.number == draw)
                        {
                            cell.marked = true;
                        }
                    }
                }

                foreach (Board board in boards)
                {
                    int rowX0Correct = 0;
                    int rowX1Correct = 0;
                    int rowX2Correct = 0;
                    int rowX3Correct = 0;
                    int rowX4Correct = 0;
                    int rowY0Correct = 0;
                    int rowY1Correct = 0;
                    int rowY2Correct = 0;
                    int rowY3Correct = 0;
                    int rowY4Correct = 0;

                    foreach (BoardCell cell in board.cells)
                    {
                        if (cell.x == 0 && cell.marked)
                            rowX0Correct++;
                        else if (cell.x == 1 && cell.marked)
                            rowX1Correct++;
                        else if (cell.x == 2 && cell.marked)
                            rowX2Correct++;
                        else if (cell.x == 3 && cell.marked)
                            rowX3Correct++;
                        else if (cell.x == 4 && cell.marked)
                            rowX4Correct++;

                        if (cell.y == 0 && cell.marked)
                            rowY0Correct++;
                        else if (cell.y == 1 && cell.marked)
                            rowY1Correct++;
                        else if (cell.y == 2 && cell.marked)
                            rowY2Correct++;
                        else if (cell.y == 3 && cell.marked)
                            rowY3Correct++;
                        else if (cell.y == 4 && cell.marked)
                            rowY4Correct++;

                        if (rowX0Correct == 5 || rowX1Correct == 5 || rowX2Correct == 5 || rowX3Correct == 5 ||
                            rowX4Correct == 5 ||
                            rowY0Correct == 5 || rowY1Correct == 5 || rowY2Correct == 5 || rowY3Correct == 5 ||
                            rowY4Correct == 5)
                        {
                            if (copyBoards.Count != 1)
                            {
                                copyBoards.Remove(board);
                            }
                            else
                            {
                                Board losingBoard = copyBoards.First();
                                if (CheckWinningBoard(losingBoard))
                                {
                                    foreach (BoardCell cellWinners in losingBoard.cells)
                                    {
                                        if (!cellWinners.marked)
                                        {
                                            sum += cellWinners.number;
                                        }
                                    }

                                    return sum * draw;
                                }
                            }
                        }
                    }
                }
            }

            return sum * draw;
        }

        private static bool CheckWinningBoard(Board board)
        {
            int rowX0Correct = 0;
            int rowX1Correct = 0;
            int rowX2Correct = 0;
            int rowX3Correct = 0;
            int rowX4Correct = 0;
            int rowY0Correct = 0;
            int rowY1Correct = 0;
            int rowY2Correct = 0;
            int rowY3Correct = 0;
            int rowY4Correct = 0;

            foreach (BoardCell cell in board.cells)
            {
                if (cell.x == 0 && cell.marked)
                    rowX0Correct++;
                else if (cell.x == 1 && cell.marked)
                    rowX1Correct++;
                else if (cell.x == 2 && cell.marked)
                    rowX2Correct++;
                else if (cell.x == 3 && cell.marked)
                    rowX3Correct++;
                else if (cell.x == 4 && cell.marked)
                    rowX4Correct++;

                if (cell.y == 0 && cell.marked)
                    rowY0Correct++;
                else if (cell.y == 1 && cell.marked)
                    rowY1Correct++;
                else if (cell.y == 2 && cell.marked)
                    rowY2Correct++;
                else if (cell.y == 3 && cell.marked)
                    rowY3Correct++;
                else if (cell.y == 4 && cell.marked)
                    rowY4Correct++;

                if (rowX0Correct == 5 || rowX1Correct == 5 || rowX2Correct == 5 || rowX3Correct == 5 ||
                    rowX4Correct == 5 ||
                    rowY0Correct == 5 || rowY1Correct == 5 || rowY2Correct == 5 || rowY3Correct == 5 ||
                    rowY4Correct == 5)
                {
                    return true;
                }
            }

            return false;
        }

        private static (string[], List<Board>) SetupBingo(string[] input)
        {
            string[] draws = new string[] { };
            List<Board> boards = new List<Board>();
            int row = 0;
            int currentBoard = 0;

            for (int line = 0; line < input.Length; line++)
            {
                if (line == 0)
                {
                    draws = input[line].Split(",");
                }
                else
                {
                    if (input[line].Equals(""))
                    {
                        Board board = new Board(new List<BoardCell>());
                        boards.Add(board);
                        row = 0;
                    }
                    else
                    {
                        Board board = boards.Last();
                        string[] numbers = input[line].Split(" ");
                        int y = 0;
                        foreach (string n in numbers)
                        {
                            if (!n.Equals(""))
                            {
                                int number = Convert.ToInt32(n);
                                BoardCell cell = new BoardCell(number, row, y++);
                                board.cells.Add(cell);
                            }
                        }

                        row++;
                    }
                }
            }

            return (draws, boards);
        }
    }
}