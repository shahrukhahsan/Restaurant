var app = angular.module('categoryModule', []);

app.controller('categoryController', function($scope, $http){
	// $scope.myName = 'ABC';
	// $scope.username
	$scope.loginVisible = true;
	$scope.categoryVisible = false;

	$scope.login = function(){
		
		// $http.post('http://localhost:55781/api/categories', {
		// 		categoryName: $scope.username,
		// 		description: $scope.password
		// })
		// .then(function(response){
		// 	if(response.status == 201)
		// 	{
		// 		alert('Insert successfull');
		// 	}
		// });
/*
		$http.get('http://localhost:50587/api/items', {
			headers: {Authorization: 'Basic ' + btoa($scope.username + ':' + $scope.password)}
		})
		.then(function(response){
			//console.log(response);
			if(response.status == 401)
			{
				alert('Invalid username or password');
			}
			else
			{
				$scope.catList = response.data;
				$scope.loginVisible = false;
				$scope.categoryVisible = true;
			}
		});


		
	}
});
*/

$(function(){

	$.ajax({
		url: 'http://localhost:50587/api/categories',
		method: 'GET',
		complete: function(xmlhttp, response){
			console.log(xmlhttp.responseJSON);
			for (var i = 0; i < xmlhttp.responseJSON.length; i++)
			{
				var row = '<tr>';
				row += '<td>' + xmlhttp.responseJSON[i].id + '</td>';
				row += '<td>' + xmlhttp.responseJSON[i].categoryName + '</td>';
				row += '<td>' + xmlhttp.responseJSON[i].description + '</td>';
				row += '</tr>';

				$('#catlist').append(row);
				$scope.catList = response.data;
				$scope.categoryVisible = true;
			}
		}
	});
})
