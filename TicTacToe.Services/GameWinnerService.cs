using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';
        public char Validate(char[,] gameBoard)
        {
            
            var currentWinnerSymbol = CheckForThreeInARowInHorizontlRow(gameBoard);
            if (currentWinnerSymbol != SymbolForNoWinner)
                return currentWinnerSymbol;
            currentWinnerSymbol = CheckForThreeInARowInVerticalColumn(gameBoard);
            if (currentWinnerSymbol != SymbolForNoWinner)
                return currentWinnerSymbol;
            currentWinnerSymbol = CheckForThreeInARowDiagonally(gameBoard);
            if (currentWinnerSymbol != SymbolForNoWinner)
                return currentWinnerSymbol;
            currentWinnerSymbol = CheckForThreeInARowDiagonallyToLeft(gameBoard);
            return currentWinnerSymbol;
        }
        private static char CheckForThreeInARowInHorizontlRow(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];
            if (columnOneChar == columnTwoChar && columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }
            return SymbolForNoWinner;
        }
        private static char CheckForThreeInARowInVerticalColumn(char[,] gameBoard)
        {
            var rowOneChar = gameBoard[0, 0];
            var rowTwoChar = gameBoard[1, 0];
            var rowThreeChar = gameBoard[2, 0];
            if (rowOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return rowOneChar;
            }
            return SymbolForNoWinner;
        }
        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[0, 0];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 2];
            if(cellOneChar==cellTwoChar&&cellTwoChar==cellThreeChar)
            {
                return cellThreeChar;
            }
            return SymbolForNoWinner;
        }
        private static char CheckForThreeInARowDiagonallyToLeft(char[,] gameBoard)
        {
            var cellOneChar = gameBoard[0, 2];
            var cellTwoChar = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 0];
            if (cellOneChar == cellTwoChar && cellTwoChar == cellThreeChar)
            {
                return cellThreeChar;
            }
            return SymbolForNoWinner;
        }

    }
}
