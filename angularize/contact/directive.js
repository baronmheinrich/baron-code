(function()
{
  'use strict';

  na.directive('fred', function(){
   return{
    'name' : 'debbie',
    'type' : 'E',
    'template' : '<div><p>lorem ipsum..............</p></div>'
   }
  });

  na.directive('fredFunc', function()
  {
    return function(){
      return new Date().toDateString();
    }
  })

})(window.ngApp);