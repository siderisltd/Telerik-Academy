/*Problem 4. Average age of female
Write a function that calculates the average age of all females, extracted from an array of persons
Use Array#filter
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

function averageFemaleAge(objArr){
    var averageFemaleAge = objArr.filter(function(number){
        return number.gender === 'female';
    })
        .reduce(function(s, num) {
            return s + num.age;
        }, 0);

    return averageFemaleAge;
}

console.log(averageFemaleAge(persons));