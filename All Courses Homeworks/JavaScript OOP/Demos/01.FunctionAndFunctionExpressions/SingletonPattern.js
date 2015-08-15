//singleton pattern -> znachi che kolkoto puti da pravim edin obekt, toi shte ima edna i sushta instanciq
// kato -> saita na akademiqta e edin a ne za vsichki razlichen

// kaji rechi vsqko IIFE implementira SINGLETON pattern tui kato se suzdava samo vednuj

var databases = (function(){ // kato ni dava IIFE nqma smisul da pishem slojni neshta

   var items = [];

   var db = {
       add: function (item) {
           items.push(item);
           return this;//po sigurno e da vurnem db   // za da si napravim chaining
       },
       list: function () {
           return items.slice();
       }
   };

    return {
        get: function () {
            return db;
        }
    }
}());

console.log(databases.get()
         .add('John')
         .add('Hohn')
         .list());