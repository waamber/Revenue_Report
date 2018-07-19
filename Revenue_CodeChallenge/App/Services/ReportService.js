app.service("ReportService", function ($http, $q, $rootScope) {


    const addReport = function (report) {
        return $q((resolve, reject) => {
            $http.post(`/api/report`, report).then(function (results) {
                resolve(results);
            }).catch(function (err) {
                reject("Error ReportService", err);
            });
        });
    };

    const getReport = function (reportName) {
        return $q((resolve, reject) => {
            $http.get(`/api/report/${reportName}`).then(function (results) {
                resolve(results.data);
            }).catch(function (err) {
                reject("Error in ReportService", err);
            });
        });
    };



    return { addReport, getReport };
});