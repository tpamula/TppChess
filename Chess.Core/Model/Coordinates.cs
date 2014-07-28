using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Model
{
    public struct Coordinates
    {
        public readonly char Column;
        public readonly int Row;

        public Coordinates(char column, int row)
        {
            Row = row;
            Column = column;
        }
    }

    public static class StringExtensions
    {
        public static Coordinates ToCoordinates(this string value)
        {
            return new Coordinates(value[0], Convert.ToInt32(value[1]));
        }
    }
}