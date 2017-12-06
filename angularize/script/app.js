// (function(){
//   "use strict";
//   fizzBuzz();

//   function fizzBuzz(){
    
//     'use strict';
    
//       var fizz = "fizz";
//       var buzz = "buzz";
//       var fizzBuzz = "fizzBuzz";
//       var x = 0;

//     for(; x<10; x+=1){
     
//       if(x % 3 === 0){
//        //console.log(fizz);
//      }
  
//       if(x % 5 === 0){
//         //console.log(buzz);
//       }else{
//         //console.log(x);
//       }
//       function display(x){
//         //console.log(x);
//       }
  
//       (function(i){
//         console.log(i);
//       })(x);
  
//     }  
//   }
  
//   //console.log('outside funciton lul ' + fizz);
//   //console.log('outside func ' + buzz);
// })();

var APP = (function(){

  'use strict';

  var person = {
    first: null,
    last: null,

  }

  function Person(){
    this.first = "first";
    this.last = "last";

  }

  function callSwapi(){
    var xhr = new XMLHttpRequest();

    xhr.open('get',"https://swapi.co/api/people/1");
    xhr.onreadystatechange = function(){
      if(xhr.readyState === 4 && xhr.status === 200){
        console.log(xhr.response);
      }
    }
    xhr.send();
  }

  return{
    pLiteral: person,
    pConstructor: Person,
    swapi: callSwapi
  };

})();

var p = new APP.pConstructor();
var p1 = APP.pLiteral;

function NewPerson(){
  this.middle = null;
}
NewPerson.prototype = new APP.pConstructor;
var p2 = new NewPerson();
p2.middle = 'Middle';
console.log(p2);
console.log(p2.first);
APP.swapi();

(function(wa){
  'use strict';

  wa = {

  };

})(window.APP || (window.APP = {}));

