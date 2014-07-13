/// <reference path="model/chessboardmanager.ts" />
var ChessController = (function () {
    function ChessController($scope) {
        $scope.status = "Hello world!";

        var chessboardManager = new ChessboardManager();
        $scope.chessboardManager = chessboardManager;
    }
    return ChessController;
})();
//# sourceMappingURL=ChessController.js.map
