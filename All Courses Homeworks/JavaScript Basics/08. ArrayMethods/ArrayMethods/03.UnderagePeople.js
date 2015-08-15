/*Problem 3. Underage people
Write a function that prints all underaged persons of an array of person
Use Array#filter and Array#forEach
Use only array methods and no regular loops (for, while)*/

var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pesho', lastname: 'Kondov', age: 12 },
    { firstname: 'Ganka', lastname: 'Ivanova', age: 23 },
    { firstname: 'Ivanka', lastname: 'Peneva', age: 22 },
    { firstname: 'Zlatka', lastname: 'Chervenata', age: 16 },
    { firstname: 'Goshko', lastname: 'Hubaveca', age: 13 },
    { firstname: 'Qn', lastname: 'Bibiqn', age: 22 }
];

function findUnderaged(objArr){
    var underAged = objArr.filter(function(number){
        return (number.age < 18);
    });
    return underAged;
}

var result = findUnderaged(people);

console.log(result);