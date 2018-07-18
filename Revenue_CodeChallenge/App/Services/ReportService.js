app.service("ReportService", function ($http, $q, $rootScope) {


    const addReport = function (report) {
        return $q((resolve, reject) => {
            $http.post(`/api/report`, report).then(function (results) {
                resolve(results);
            }).catch(function (err) {
                reject("error ReportService", err);
            });
        });
    }

   



    return { addReport };
});