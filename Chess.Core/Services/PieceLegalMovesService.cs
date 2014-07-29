using Chess.Core.Enums;
using Chess.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Services
{
    public static class PieceLegalMovesService
    {
        public static HashSet<Position> GetLegalMoves(Position position, Chessboard chessboard)
        {
            var pieceType = chessboard[position].Type;
            HashSet<Position> result;

            switch (pieceType)
            {
                case PieceType.Pawn:
                    result = GetMovesForPawn(position, chessboard);
                    break;

                default:
                    throw new NotImplementedException();
            }

            return result;
        }

        private static HashSet<Position> GetMovesForPawn(Position position, Chessboard chessboard)
        {
            var piece = chessboard[position];
            var result = new HashSet<Position>();

            if (piece.Color == PieceColor.White)
            {
                if (position.Row < 7) result.Add(new Position(position.Column, position.Row + 1));
                if (position.Row == 2)
                {
                    result.Add(new Position(position.Column, position.Row + 2));
                    // TODO En passant capture.
                }
            }
            else
            {
                if (position.Row > 2) result.Add(new Position(position.Column, position.Row - 1));
                if (position.Row == 7)
                {
                    result.Add(new Position(position.Column, position.Row - 2));
                    // TODO En passant capture.
                }
            }
            // TODO capture.

            return result;
        }
    }
}