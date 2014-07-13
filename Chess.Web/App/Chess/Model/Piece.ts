class Piece {
    public type: PieceType;

    constructor(type: PieceType) {
        this.type = type;
    }

    public toString(): string {
        var result: string;

        switch(this.type) {
            case PieceType.Bishop:
                result = "B";
                break;
            case PieceType.Empty:
                result = "";
                break;
            case PieceType.King:
                result = "K";
                break;
            case PieceType.Knight:
                result = "N";
                break;
            case PieceType.Pawn:
                result = "P";
                break;
            case PieceType.Queen:
                result = "Q";
                break;
            case PieceType.Rook:
                result = "R";
                break;
        }

        return result;
    }
}