app.controller("AddReportController", ["$scope", "$http", "$location", "$routeParams", "ReportService", "ItemService",
    function ($scope, $http, $location, $routeParams, ReportService, ItemService) {

        document.getElementById("uploaded-report").addEventListener("change", function (e) {

            var report = e.target.files[0];
            $scope.reportName = document.getElementById("fileName").value;

            var reader = new FileReader();
            reader.onload = function (e) {
                $scope.fileContents = e.target.result;
                $scope.$apply();
                tsvToJson($scope.fileContents);
            };

            reader.readAsText(report);
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

            var parsedReport = result;
            addReport(parsedReport);
            return parsedReport;
        };

        function addReport(array) {
            var items = [];
            var reportObj = {};
            reportObj.ReportName = $scope.reportName;

            addReportToDb(reportObj);

            //    for (var key in array) {
            //        if (array.hasOwnProperty(key)) {R
            //            items.push(array[key]);
            //            items.forEach(function (obj) {
            //                {
            //                    obj.ReportId = $scope.reportId;
            //                }
            //            });

            //            ItemService.addItem(obj).then(function (results) {
            //                $location.path()
            //            }).catch(function (err) {
            //                console.log("Error in ItemService.addItem", err);
            //            });
            //        };
            //    };
            //};


        };

        const addReportToDb = function (report) {
            ReportService.addReport(report).then(function (result) {
                if (result) {
                    getReportId($scope.reportName);
                }
                    
               
            }).catch((function (err) {
                console.log("Error in addReportToDb", err);
            }));
        };

        const getReportId = function (reportName) {
            ReportService.getReport(reportName).then(function (results) {
                if (results) {
                    $scope.ReportId = results.data.ReportId;
                    console.log($scope.ReportId);
                }
            }).catch(function (err) {
                console.log("Error in getReportId", err);
            });
        };
    }
]);
