(function(na){

  'use strict';

  na.service('contactSvc', ['$http',function($http){

    return function(id,pass,fail){
    $http.get('http://pokeapi.co/api/v2/pokemon'+id).then(pass,fail);

    }
  }]);

  na.factory('contactFac', ['$http',function($http){

    return{
      get: function (id, pass, fail)
      {
        $http.get('http://pokeapi.co/api/v2/pokemon'+id).then(pass,fail);
      }
    }
  }]);

  na.service('contractSvLocal',fucntion()){

    return function()
    {

    }

  };

  // var p = new Promise(function(){
  //   'do work';
  //   if(test){
  //     return true;
  //   }
  //   return false;
  // }).then(true,false);

})(window.ngApp);