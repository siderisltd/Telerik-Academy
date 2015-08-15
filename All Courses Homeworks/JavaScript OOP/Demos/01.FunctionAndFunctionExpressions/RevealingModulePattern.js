//revealing module pattern sushtata kato module pattern , samo che razlikata e vmesto da slagame funkciite v return
//obekta vsichki funkcii si gi slagame nai otgore i v return obekta mu podavame referenciq kum funkciite:

var db = (function () {
    var objects = [],
        ID = 0;

    function getNextID() {
        return ++ID; // closure kum ID
    }

    function addObject(obj) {
        obj.ID = getNextID(); // closure kum getNextID
        objects.push(obj);
    }

    function listObjects() {
        // return objects.slice(); //vinagi vrushtame referenciq za da ne ni smeni nqkoi private obekta
        return objects.map(function (obj) {
            return {
                name: obj.name,
                id: obj.ID
            }
        }).slice();
    }

    return {
        add: addObject,  // tuk mu podavame referencii kum funkciite..
        list: listObjects
    };
}());

db.add({name:'Pesho'});
db.add({name:'asd'});
db.add({name:'ttt'});
db.add({name:'222'});

console.log(db.list());