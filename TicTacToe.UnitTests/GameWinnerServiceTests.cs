using NUnit.Framework;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;
        [SetUp]
        public void SetupTest()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        }
        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            
           
            const char expected = ' ';
            _gameBoard = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            
             
            const char expected = 'X';
            _gameBoard = new char[3, 3] { { expected, expected, expected }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithAllSpacesInFirstColumnIsWinner()
        {
            const char expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameBoard[i, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
        {
            const char expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameBoard[i, i] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [Test]
        public void PlayerWithThreeInARowDiagonallyDownAndToLeftIsWinner()
        {
            const char expected = 'X';
            _gameBoard[0, 2] = expected;
            _gameBoard[1, 1] = expected;
            _gameBoard[2, 0] = expected;
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
