using ApprovalTests;
using ApprovalTests.Reporters;
using Chess.Core.Enums;
using Chess.Core.Model;
using Xunit;

namespace Chess.Tests.Model
{
    [UseReporter(typeof(DiffReporter))]
    public class ChessboardTests
    {
        [Fact]
        public void initial_setup_is_correct()
        {
            var chessboard = new Chessboard();

            Approvals.Verify(chessboard.ToString());
        }

        [Fact]
        public void returns_correct_piece_on_a1_field()
        {
            var chessboard = new Chessboard();

            Assert.Equal(chessboard["a1"], new Piece(PieceColor.White, PieceType.Rook));
        }

        [Fact]
        public void returns_correct_piece_on_e8_field()
        {
            var chessboard = new Chessboard();

            Assert.Equal(chessboard["e8"], new Piece(PieceColor.Black, PieceType.King));
        }
    }
}