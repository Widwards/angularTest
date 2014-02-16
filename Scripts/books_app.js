angular.module('booksApp', []).
config([$routeProvider, function($routeProvider) {
	$routeProvider.
	when('books', {templateUrl: 'partial/books-list.html', controller: BooksListCtrl}).
	when('books\:id', {templateUrl: 'partial/book-view.html', controller: BookViewCtrl}).
	otherwise({redirectTo: 'books'});
}]);