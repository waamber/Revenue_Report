app.service("ItemService", function ($http, $q, $rootScope) {

    const addItem = function (item) {
        return $q((resolve, reject) => {
            $http.post(`/api/item`, JSON.stringify(item)).then(function (results) {
                resolve(results);
            }).catch(function (err) {
                reject("Error ItemService", err);
            });
        });
    };

    return { addItem };
});