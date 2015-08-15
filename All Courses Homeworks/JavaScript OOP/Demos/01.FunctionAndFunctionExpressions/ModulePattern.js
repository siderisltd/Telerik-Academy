//module pattern -> napravi mi eedno IIFE , koeto ima nqkakvi hidden neshta i nakraq vrushta samo edin obekt
// koito expose-va public methods

var db = (function(){
    var objects = [],
        ID = 0;

    function getNextID (){
        return ++ID;
    }

    return {
            add: function (obj) {
                obj.id = getNextID();
                objects.push(obj);
            },
            list: function (){
                // return objects.slice(); //vinagi vrushtame referenciq za da ne ni smeni nqkoi private obekta
                return objects.map(function (obj) {
                    return {
                        name: obj.name,
                        id: obj.id
                    }
                }).slice();
            }
    };
}());

db.add({name: 'John'});

console.log(db.list());