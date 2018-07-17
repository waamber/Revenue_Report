var app = angular.module("RevenueReportTracker", ["ngRoute", "ui.bootstrap"]);

app.config(["$routeProvider", function ($routeProvider) {
    $routeProvider.when("/",
        {
            templateUrl: "/app/partials/home.html",
            controller: "AddReportController"
        })

        .otherwise('/');
}]);