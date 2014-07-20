using Chess.Core.Enums;
using Chess.Core.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Chess.Tests
{
    public class ChessboardTests
    {
        [Fact]
        public void initial_setup_is_correct()
        {
            var chessboard = new Chessboard();

            foreach (int row in new[] { 1, 8 })
            {
                Assert.True(chessboard['a', row] == PieceType.Rook);
                Assert.True(chessboard['b', row] == PieceType.Knight);
                Assert.True(chessboard['c', row] == PieceType.Bishop);
                Assert.True(chessboard['d', row] == PieceType.Queen);
                Assert.True(chessboard['e', row] == PieceType.King);
                Assert.True(chessboard['f', row] == PieceType.Bishop);
                Assert.True(chessboard['g', row] == PieceType.Knight);
                Assert.True(chessboard['h', row] == PieceType.Rook);
            }

            foreach (int row in new[] { 2, 7 })
            {
                for (int i = 0; i < 8; i++)
                {
                    Assert.True(chessboard[Convert.ToChar(i + 97), row] == PieceType.Pawn);
                }
            }

            for (int i = 3; i <= 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Assert.True(chessboard[Convert.ToChar(j + 97), i] == PieceType.Empty);
                }
            }
        }
    }
}