angular.module("app", []).controller("HelloWorldCtrl", function ($scope, $http, $filter) {
    $scope.title = "AutoPT"
    $scope.cars = null;
    $scope.searchQuery = '';

    $http.get('data/cars.json').then(function (response) {
        $scope.cars = $filter('orderBy')(response.data, 'status');
    });
})