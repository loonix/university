"use strict";
var app = angular.module('app', []);

app.controller("controller", function ($scope, $http, $filter, $sce) {
    $scope.title = "AutoPT"
    $scope.cars = null;
    $scope.searchQuery = '';
    $scope.brands = null;
    $scope.status = null;
    $scope.modalData = {
        city: null,
        country: null
    };

    var statuses = {
        featured: "destaque",
        lastChance: "oportunidade",
        reSale: "revenda",
        sold: "vendido"
    }

    $http.get('data/cars.json').then(function (response) {
        $scope.cars = $filter('orderBy')(response.data, 'status');
        $scope.status = $scope.cars.map((car) => car.status).filter((value, index, self) => self.indexOf(value) === index && value != null);

    });

    $scope.getStatusClass = (status) => {
        var statusLc = status.toLowerCase();
        if (statusLc === statuses.sold) {
            return 'status-assertive';
        } else if (statusLc === statuses.lastChance) {
            return 'status-positive';
        } else if (statusLc === statuses.featured) {
            return 'status-yellow';
        } else if (statusLc === statuses.reSale) {
            return 'status-amber';
        }
    };

    $scope.setModalData = (car) => {
        $scope.modalData = car;
    }

});