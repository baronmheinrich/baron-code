(function(na){
'use strict';

  var hw = angular.module('helloWorld', ['ngRoute']);

  hw.config(['$routeProvider',function(banana){
    banana
    .when('/home',{
      controller: 'homeCtrl',
      templateUrl: 'home/template.html'
    })
    .when('/contact',{
      controller: 'contractCtrl',
      templateUrl: 'contact/template.html'
    })
    .otherwise({
      redirectTo: '/home'
    })
  }]);

  return na;
})(window.ngApp || (window.ngApp = {}));