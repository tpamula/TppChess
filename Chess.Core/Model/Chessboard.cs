using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core.Model
{
    public class Chessboard
    {
        public Chessboard()
        {
            createInitialSetup();
        }

        private void createInitialSetup()
        {
            var initialSetup = new List<Row>();

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Rook, PieceType.Knight, PieceType.Bishop, PieceType.Queen,
                PieceType.King, PieceType.Bishop, PieceType.Knight, PieceType.Rook
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Pawn, PieceType.Pawn, PieceType.Pawn, PieceType.Pawn, PieceType.Pawn,
                PieceType.Pawn, PieceType.Pawn, PieceType.Pawn
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty,
                PieceType.Empty, PieceType.Empty, PieceType.Empty
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty,
                PieceType.Empty, PieceType.Empty, PieceType.Empty
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty,
                PieceType.Empty, PieceType.Empty, PieceType.Empty
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty, PieceType.Empty,
                PieceType.Empty, PieceType.Empty, PieceType.Empty
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Pawn, PieceType.Pawn, PieceType.Pawn, PieceType.Pawn, PieceType.Pawn,
                PieceType.Pawn, PieceType.Pawn, PieceType.Pawn
            }));

            initialSetup.Add(new Row(new List<PieceType>()
            {
                PieceType.Rook, PieceType.Knight, PieceType.Bishop, PieceType.Queen,
                PieceType.King, PieceType.Bishop, PieceType.Knight, PieceType.Rook
            }));

            chessboardInternalRepresentation = initialSetup.AsReadOnly();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="column"></param>
        /// <param name="row">Numbered like in chess - starting from 1.</param>
        /// <returns></returns>
        public PieceType this[char column, int row]
        {
            get { return chessboardInternalRepresentation[row - 1][column]; }
        }

        private IReadOnlyList<Row> chessboardInternalRepresentation;
    }
}