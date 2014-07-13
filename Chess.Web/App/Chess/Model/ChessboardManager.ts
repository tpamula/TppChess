/// <reference path="piece.ts" />

class ChessboardManager {
    public chessboardSize: number = 8;
    public chessboard: Piece[][];

    constructor() {
        this.chessboard = new Array(this.chessboardSize);

        for (var i: number = 0; i < this.chessboardSize; i++) {
            this.chessboard[i] = new Array(this.chessboardSize);
            for (var j: number = 0; j < this.chessboardSize; j++) {
                this.chessboard[i][j] = Piece.Empty;
            }
        }
    }
}