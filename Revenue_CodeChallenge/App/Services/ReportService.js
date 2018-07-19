app.service("ReportService", function ($http, $q) {


    const addReport = function (report) {
        return $http.post(`/api/report`, report);
    };

    const getReport = function (reportName) {
        return $http.get(`/api/report/${reportName}`);
    };

    return { addReport, getReport };
});