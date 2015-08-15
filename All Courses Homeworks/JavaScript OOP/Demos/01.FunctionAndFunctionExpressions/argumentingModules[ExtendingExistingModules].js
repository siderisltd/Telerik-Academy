//ArgumentingModules - Extending Existing MODULE -> Na praktika ni kazva:
//ideqta e ako imam modul 500 reda kod da moga da go razpredelq v 2 faila za da mi e po podredeno i qko


// file-1.js   abe tuka imam file 1.js
var mod = (function(){
    return {
      x: 'file-1'
    };
}());

// file-2.js abe tuka imam file 2.js

var mod = (function(){
    return{
        y: 'file-2'
    }
}());

//console.log(mod.x);  tova e undefined zashtoto ednoto override va drugoto i imame samo property [y];
//pravi se taka :
var module = module || {};   //moje da go slojim taka i v dvata faila vmesto da go deklarirame v
                                // ediniq fail i da mu kazvame ako e undefined to e falsy like da suzdava nov obekt, a ako
                                    // go ima suzdaden kato obekt da si polzva nego :) 

(function(scope){

scope.x = 'file-1';

}(module));

// file-2.js abe tuka imam file 2.js
var module = module || {};

(function(scope){

       scope.y = 'file-2';

}(module));

console.log(module.x);
console.log(module.y);