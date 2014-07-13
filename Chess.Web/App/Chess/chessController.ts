/// <reference path="model/chessboardmanager.ts" />

class ChessController {
    constructor($scope: any) {
        $scope.status = "Hello world!";

        var chessboardManager: ChessboardManager = new ChessboardManager();
        $scope.chessboardManager = chessboardManager;
    }
}