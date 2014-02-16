function BooksListCtrl($scope, $http, $sce){
	$scope.name = "Nikita";
	$http.get("/home/books").success(function(data) {
		$scope.books = data.Books;
	});
	$scope.PageView = "Выберите приложение";

	$scope.setPage = function(id) {
		$.ajax({
			url: "/home/getbook?id="+id,
			success: function(data) {
				$scope.BookView = $sce.trustAsHtml(data);

				console.log(data);
			}
		});
		//$("#ajax-place").html(ajaxData);

	};

};

function BookViewCtrl($scope, $http){
};