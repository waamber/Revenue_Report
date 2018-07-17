app.controller("AddReportController", ["$scope", "$http", "$location", "$routeParams",
    function ($scope, $http, $location, $routeParams) {

        document.getElementById("uploaded-report").addEventListener("change", function (e) {
            var file = e.target.files[0];

            var reader = new FileReader();
            reader.onload = function (e) {
                $scope.fileContents = e.target.result;
                $scope.$apply();
                tsvToJson($scope.fileContents);
            };

            reader.readAsText(file);
        });

        function tsvToJson(tsvFile) {
            var lines = tsvFile.split("\n");
            var result = [];

            var headers = lines[0].split("\t");
            for (var i = 1; i < lines.length; i++) {
                var obj = {};
                var currentLine = lines[i].split("\t");

                for (var j = 0; j < headers.length; j++) {
                    obj[headers[j]] = currentLine[j];
                }

                result.push(obj);
            }

            var tsvToJSON = result;
            arrayOfObjects(tsvToJSON);
            return tsvToJSON;
        }

        function arrayOfObjects(array) {
            for (var key in array) {
                if (array.hasOwnProperty(key)){
                    console.log(array[key]);
                }
            };
        };

    }
]);
