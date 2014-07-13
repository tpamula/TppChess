/// <reference path="piece.ts" />
var ChessboardManager = (function () {
    function ChessboardManager() {
        this.chessboardSize = 8;
        this.chessboard = new Array(this.chessboardSize);

        for (var i = 0; i < this.chessboardSize; i++) {
            this.chessboard[i] = new Array(this.chessboardSize);
            for (var j = 0; j < this.chessboardSize; j++) {
                this.chessboard[i][j] = 0 /* Empty */;
            }
        }
    }
    return ChessboardManager;
})();
//# sourceMappingURL=chessboardmanager.js.map
