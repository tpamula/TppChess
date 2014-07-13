var Piece = (function () {
    function Piece(type) {
        this.type = type;
    }
    Piece.prototype.toString = function () {
        var result;

        switch (this.type) {
            case 3 /* Bishop */:
                result = "B";
                break;
            case 0 /* Empty */:
                result = "";
                break;
            case 6 /* King */:
                result = "K";
                break;
            case 2 /* Knight */:
                result = "N";
                break;
            case 1 /* Pawn */:
                result = "P";
                break;
            case 5 /* Queen */:
                result = "Q";
                break;
            case 4 /* Rook */:
                result = "R";
                break;
        }

        return result;
    };
    return Piece;
})();
//# sourceMappingURL=Piece.js.map
