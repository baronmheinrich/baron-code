(function(na){
'use strict'

na.controller('contactCtrl',['$scope','contactSvc',function ($scope, svc){
    $scope.contact = {};
    $scope.formSubmit = function (){
      $scope.message = $scope.contact.name + ' has set a message!';
      setTimeout(function(){
        $scope.message = '';
      },5000);
    }
    $scope.papiSubmit = function(id){
      function success(res){
        console.log(res);
      }

      function failure(res){
        console.log(res);
      }

      svc($scope.id, success, failure);

    }
}]);

})(window.ngApp);