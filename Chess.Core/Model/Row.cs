using Chess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Core.Model
{
    public class Row
    {
        private readonly List<Piece> _rowInternalRepresentation;

        public Row(ICollection<Piece> pieces)
        {
            if (pieces.Count != 8) throw new ArgumentException();

            _rowInternalRepresentation = pieces.ToList();
        }

        public IReadOnlyList<Piece> Representation
        {
            get { return _rowInternalRepresentation.AsReadOnly(); }
        }

        public Piece this[char column]
        {
            get
            {
                return _rowInternalRepresentation[ConvertColumnToListIndex(column)];
            }
            private set
            {
                _rowInternalRepresentation[ConvertColumnToListIndex(column)] = value;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < 8; i++)
            {
                result += _rowInternalRepresentation[i].ToString();

                if (i != 7)
                {
                    result += " ";
                }
            }

            return result;
        }

        private int ConvertColumnToListIndex(char column)
        {
            return Convert.ToInt32(column) - Convert.ToInt32('a');
        }
    }
}