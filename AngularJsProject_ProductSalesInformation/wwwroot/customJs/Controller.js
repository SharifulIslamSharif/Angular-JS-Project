app.controller('myController', function ($scope, myService) {

    $scope.newProduct = {};
    $scope.clickedProduct = {};
    $scope.message = "";
    ProductList();
    function ProductList() {
        myService.productList().then(function (result) {
            $scope.Products = result.data;
        });
    };

    $scope.AddProduct = function () {
        myService.addProduct($scope.newProduct).then(function (result) {
            //alert(result);            
            $scope.message = "Product saved successfully";
            $scope.newProduct = {};
            ProductList();
        });
    };

    $scope.SelectedProduct = function (product) {
        $scope.clickedProduct = product;
    };

    $scope.UpdateProduct = function () {
        myService.updateProduct($scope.clickedProduct).then(function (result) {
            $scope.message = "Data updated successfully";
            $scope.Products = result.data;
            ProductList();
        }, function () {
            alert(result);
        });
    };

    $scope.DeleteProduct = function () {
        myService.deleteProduct($scope.clickedProduct.JsProductId).then(function () {
            $scope.message = "Product deleted successfully"
            ProductList();
        }, function (result) {
            alert(result);
        })
    };

    $scope.ClearMessage = function () {
        $scope.message = "";
    }
})