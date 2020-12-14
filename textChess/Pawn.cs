﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textChess
{
    public class Pawn
    {
        
        public static List<string> FindLegalMoves(string[][] board, int startFile, int startRow, char turn)
        {
            //if the piece that is generating moves does not belong to the current turn, then it will return with an error
            string current = board[startRow - 1][startFile - 1];

            //two possible ways to generate moves corresponding to the current players turn.
            List<string> moves = new List<string>();
            //The moves will be returned in a non-zero indexing
            if(turn.Equals('w'))
            {
                if (startRow - 1 == 6 && board[(startRow - 1) - 1][startFile - 1].Equals("--") && board[(startRow - 1) - 2][startFile - 1].Equals("--")) { moves.Add(startFile + "," + (startRow - 2)); moves.Add(startFile + "," + (startRow - 1)); }
                else if (board[(startRow - 1) - 1][startFile - 1].Equals("--")) moves.Add(startFile + "," + (startRow - 1));

                if (startFile != 1 && !board[startRow - 2][startFile - 2].Equals("--")) moves.Add((startFile - 1) + "," + (startRow - 1));
                if (startFile != 8 && !board[startRow - 2][startFile].Equals("--")) moves.Add((startFile + 1) + "," + (startRow - 1));
            }
            else if(turn.Equals('b'))
            {
                if (startRow - 1 == 1 && board[(startRow - 1) + 1][startFile - 1].Equals("--") && board[(startRow - 1) + 2][startFile - 1].Equals("--")) { moves.Add(startFile + "," + (startRow + 2)); moves.Add(startFile + "," + (startRow + 1)); }
                else if (board[(startRow - 1) + 1][startFile - 1].Equals("--")) moves.Add(startFile + "," + (startRow + 1));

                if (startFile != 8 && !board[startRow][startFile].Equals("--")) moves.Add(startFile + "," + startFile);
                if (startFile != 1 && !board[startRow][startFile - 2].Equals("--")) moves.Add((startFile - 1) + "," + (startRow + 1));
            }
            return moves;
        }
        
    }
}
