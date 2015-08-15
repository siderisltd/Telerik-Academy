/*Problem 2. People of age
Write a function that checks if an array of person contains only people of age (with age 18 or greater)
Use only array methods and no regular loops (for, while)*/

var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pesho', lastname: 'Kondov', age: 42 },
    { firstname: 'Ganka', lastname: 'Ivanova', age: 23 },
    { firstname: 'Ivanka', lastname: 'Peneva', age: 22 },
    { firstname: 'Zlatka', lastname: 'Chervenata', age: 66 },
    { firstname: 'Goshko', lastname: 'Hubaveca', age: 33 },
    { firstname: 'Qn', lastname: 'Bibiqn', age: 22 }
];

console.log(people.every(function(number){
    return (number.age > 18);
}));
