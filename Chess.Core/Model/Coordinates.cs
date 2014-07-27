using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Model
{
    public struct Coordinates
    {
        private char _column;
        private int _row;

        public Coordinates(char column, int row)
        {
            _row = row;
            _column = column;
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