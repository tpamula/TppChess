/// <reference path="model/chessboardmanager.ts" />

class ChessController {
    constructor($scope: any) {
        $scope.status = "Hello world!";

        $scope.chessboardManager = new ChessboardManager();
    }