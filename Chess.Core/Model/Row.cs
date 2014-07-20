using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core.Model
{
    public class Row
    {
        private List<PieceType> rowInternalRepresentation;

        public Row(ICollection<PieceType> pieces)
        {
            if (pieces.Count != 8) throw new ArgumentException();

            rowInternalRepresentation = pieces.ToList();
        }

        public IReadOnlyList<PieceType> Representation
        {
            get { return rowInternalRepresentation.AsReadOnly(); }
        }

        public PieceType this[char column]
        {
            get
            {
                return rowInternalRepresentation[ConvertColumnToListIndex(column)];
            }
            private set
            {
                rowInternalRepresentation[ConvertColumnToListIndex(column)] = value;
            }
        }

        private int ConvertColumnToListIndex(char column)
        {
            return Convert.ToInt32(column) - Convert.ToInt32('a');
        }
    }
}