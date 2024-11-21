var app = angular.module('ProductApp', []);

app.controller('ProductController', function ($scope, $http) {
    $scope.products = [];

    // Fetch Products
    $scope.loadProducts = function () {
        $http.get('/api/Products').then(function (response) {
            $scope.products = response.data;
        });
    };

    // Add Product
    $scope.addProduct = function () {
        $http.post('/api/Products', $scope.newProduct).then(function () {
            $scope.newProduct = {};
            $scope.loadProducts();
        });
    };

    // Update Product
    $scope.updateProduct = function (product) {
        $http.put('/api/Products', product).then(function () {
            $scope.loadProducts();
        });
    };

    // Delete Product
    $scope.deleteProduct = function (id) {
        $http.delete('/api/Products/' + id).then(function () {
            $scope.loadProducts();
        });
    };

    // Initial load
    $scope.loadProducts();
});
