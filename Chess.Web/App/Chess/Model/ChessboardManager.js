/// <reference path="piece.ts" />
var ChessboardManager = (function () {
    function ChessboardManager() {
        this.chessboardSize = 8;
        this.rows = [1, 2, 3, 4, 5, 6, 7, 8];
        this.columns = ["a", "b", "c", "d", "e", "f", "g", "h"];
        this.createInitialSetup();
    }
    ChessboardManager.prototype.getPositionName = function (columnNumber, rowNumber) {
        return this.columns[columnNumber] + this.rows[rowNumber];
    };

    ChessboardManager.prototype.createInitialSetup = function () {
        this.chessboard = new Array(this.chessboardSize);

        for (var i = 0; i < this.chessboardSize; i++) {
            this.chessboard[i] = new Array(this.chessboardSize);
            for (var j = 0; j < this.chessboardSize; j++) {
                if (i > 1 && i < 6) {
                    this.chessboard[i][j] = new Piece(0 /* Empty */);
                } else if (i === 1 || i === 6) {
                    this.chessboard[i][j] = new Piece(1 /* Pawn */);
                } else {
                    switch (j) {
                        case 0:
                        case 7:
                            this.chessboard[i][j] = new Piece(4 /* Rook */);
                            break;
                        case 1:
                        case 6:
                            this.chessboard[i][j] = new Piece(2 /* Knight */);
                            break;
                        case 2:
                        case 5:
                            this.chessboard[i][j] = new Piece(3 /* Bishop */);
                            break;
                        case 3:
                            this.chessboard[i][j] = new Piece(5 /* Queen */);
                            break;
                        case 4:
                            this.chessboard[i][j] = new Piece(6 /* King */);
                            break;
                    }
                }
            }
        }
    };
    return ChessboardManager;
})();
//# sourceMappingURL=chessboardmanager.js.map
