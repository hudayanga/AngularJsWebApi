/// <reference path="angular.js" />

var url = "http://localhost:50492/api/employee/";
var myApp = angular.module("myApp", []);



var MyController = function ($scope, $http) {
    debugger;
    var onSuccess = function (response) {
        console.log(response.data);
        $scope.employees = response.data;;
    };

    var onFailure = function (reason) {
        $scope.error = reason;
    };


    var getAllEmployees = function () {
        $http.get(url).then(onSuccess, onFailure)

    
    };

    getAllEmployees();
};

myApp.controller("MyController", MyController);

