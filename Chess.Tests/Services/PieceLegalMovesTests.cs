using Chess.Core.Enums;
using Chess.Core.Model;
using Chess.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Chess.Tests.Services
{
    public class PieceLegalMovesTests
    {
        [Fact]
        public void should_return_legal_moves_for_a2_pawn_on_chessboard_with_initial_setup()
        {
            var chessboard = new Chessboard();
            var legalMoves = new HashSet<Coordinates>()
            {
                "a3".ToCoordinates(),
                "a4".ToCoordinates()
            };

            Assert.True(PieceLegalMoves.GetLegalMoves("a2".ToCoordinates(), chessboard)
                                       .SetEquals(legalMoves));
        }
    }
}