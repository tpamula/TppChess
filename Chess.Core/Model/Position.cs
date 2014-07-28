using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Model
{
    public struct Position
    {
        public readonly char Column;
        public readonly int Row;

        public Position(char column, int row)
        {
            Row = row;
            Column = column;
        }
    }

    public static class StringExtensions
    {
        public static Position ToPosition(this string value)
        {
            return new Position(value[0], Convert.ToInt32(value[1]));
        }
    }
}