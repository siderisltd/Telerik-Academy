/*Problem 5. Youngest person
Write a function that finds the youngest male person in a given array of people and prints his full name
Use only array methods and no regular loops (for, while)
Use Array#find*/

if (!Array.prototype.find) {
    Array.prototype.find = function(predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}


var persons = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32, gender:'female'},
    { firstname: 'Bay', lastname: 'Ivan', age: 81, gender:'female' },
    { firstname: 'Pesho', lastname: 'Kondov', age: 12, gender:'male'},
    { firstname: 'Ganka', lastname: 'Ivanova', age: 23, gender:'female' },
    { firstname: 'Ivanka', lastname: 'Peneva', age: 22, gender:'male' },
    { firstname: 'Zlatka', lastname: 'Chervenata', age: 16, gender:'female' },
    { firstname: 'Goshko', lastname: 'Hubaveca', age: 13, gender:'male' },
    { firstname: 'Qn', lastname: 'Bibiqn', age: 22, gender:'female' }
];

var youngestMale = persons.sort(function(a, b) {
    return a.age - b.age;
}).find(function(item) {
    return item.gender === 'male';
});

console.log(youngestMale);