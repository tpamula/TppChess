using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Chess.Core.Model
{
    public class Chessboard
    {
        private IReadOnlyList<Row> _chessboardInternalRepresentation;

        public Chessboard()
        {
            CreateInitialSetup();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row">Numbered like in chess - starting from 1.</param>
        /// <returns></returns>
        public Piece this[char column, int row]
        {
            get { return _chessboardInternalRepresentation[row - 1][column]; }
        }

        public Piece this[string position]
        {
            get { return this[position[0], int.Parse(position[1].ToString(CultureInfo.InvariantCulture))]; }
        }

        public void MovePiece(Position source, Position target)
        {
            if (!IsMoveLegal(source, target)) throw new IllegalMoveException();
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 7; i >= 0; i--)
            {
                result += _chessboardInternalRepresentation[i].ToString();

                if (i != 0)
                {
                    result += Environment.NewLine;
                }
            }

            return result;
        }

        private void CreateInitialSetup()
        {
            var initialSetup = new List<Row>();

            initialSetup.Add(new Row(new List<Piece>()
            {
                new Piece(PieceColor.White, PieceType.Rook),
                new Piece(PieceColor.White, PieceType.Knight),
                new Piece(PieceColor.White, PieceType.Bishop),
                new Piece(PieceColor.White, PieceType.Queen),
                new Piece(PieceColor.White, PieceType.King),
                new Piece(PieceColor.White, PieceType.Bishop),
                new Piece(PieceColor.White, PieceType.Knight),
                new Piece(PieceColor.White, PieceType.Rook)
            }));

            initialSetup.Add(new Row(new List<Piece>()
            {
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
                new Piece(PieceColor.White, PieceType.Pawn),
            }));

            for (int i = 0; i < 4; i++)
            {
                initialSetup.Add(new Row(new List<Piece>()
            {
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
                new Piece(PieceColor.Ignored, PieceType.Empty),
            }));
            }

            initialSetup.Add(new Row(new List<Piece>()
            {
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
                new Piece(PieceColor.Black, PieceType.Pawn),
            }));

            initialSetup.Add(new Row(new List<Piece>()
            {
                new Piece(PieceColor.Black, PieceType.Rook),
                new Piece(PieceColor.Black, PieceType.Knight),
                new Piece(PieceColor.Black, PieceType.Bishop),
                new Piece(PieceColor.Black, PieceType.Queen),
                new Piece(PieceColor.Black, PieceType.King),
                new Piece(PieceColor.Black, PieceType.Bishop),
                new Piece(PieceColor.Black, PieceType.Knight),
                new Piece(PieceColor.Black, PieceType.Rook)
            }));

            _chessboardInternalRepresentation = initialSetup.AsReadOnly();
        }

        private bool IsMoveLegal(Position source, Position target)
        {
            throw new NotImplementedException();
        }
    }
}