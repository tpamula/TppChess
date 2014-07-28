using Chess.Core.Enums;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Model
{
    public struct Piece
    {
        public readonly PieceColor Color;

        public readonly PieceType Type;

        public Piece(PieceColor color, PieceType type)
        {
            Color = color;
            Type = type;
        }

        public override string ToString()
        {
            return string.Join("",
                Enum.GetName(typeof(PieceColor), Color)[0],
                Enum.GetName(typeof(PieceType), Type)[0]);
        }
    }
}