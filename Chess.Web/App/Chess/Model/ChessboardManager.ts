/// <reference path="piece.ts" />

class ChessboardManager {
    public chessboardSize: number = 8;
    public chessboard: Piece[][];
    public rows: number[] = [1, 2, 3, 4, 5, 6, 7, 8];
    public columns: string[] = ["a", "b", "c", "d", "e", "f", "g", "h"];

    constructor() {
        this.createInitialSetup();
    }

    public getPositionName(columnNumber: number, rowNumber: number): string {
        return this.columns[columnNumber] + this.rows[rowNumber];
    }

    private createInitialSetup(): void {
        this.chessboard = new Array(this.chessboardSize);

        for (var i: number = 0; i < this.chessboardSize; i++) {
            this.chessboard[i] = new Array(this.chessboardSize);
            for (var j: number = 0; j < this.chessboardSize; j++) {
                if (i > 1 && i < 6) {
                    this.chessboard[i][j] = new Piece(PieceType.Empty);
                } else if (i === 1 || i === 6) {
                    this.chessboard[i][j] = new Piece(PieceType.Pawn);
                } else {
                    switch(j) {
                        case 0:
                        case 7:
                            this.chessboard[i][j] = new Piece(PieceType.Rook);
                            break;
                        case 1:
                        case 6:
                            this.chessboard[i][j] = new Piece(PieceType.Knight);
                            break;
                        case 2:
                        case 5:
                            this.chessboard[i][j] = new Piece(PieceType.Bishop);
                            break;
                        case 3:
                            this.chessboard[i][j] = new Piece(PieceType.Queen);
                            break;
                        case 4:
                            this.chessboard[i][j] = new Piece(PieceType.King);
                            break;
                    }
                }
            }
        }
    }
}