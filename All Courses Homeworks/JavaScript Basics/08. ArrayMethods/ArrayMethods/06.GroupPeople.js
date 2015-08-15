/**
 * Created by Alex on 6/8/2015.
 */
/*Problem 6. Group people
Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
Use Array#reduce
Use only array methods and no regular loops (for, while)*/

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

var result = persons.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log(result);