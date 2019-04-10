/// <reference path="angular.js" />

var url = "http://localhost:50492/api/employee/";
var myApp = angular.module("myApp", []);



var MyController = function ($scope, $http) {
    //debugger;
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

    debugger;

     $scope.AddData = function () {
       
        var emp = {
            Name:$scope.EName
         };
         console.log(emp);
         $http.post(url, emp)

    };
};

myApp.controller("MyController", MyController);

