/*Problem 1. Make person
Write a function for creating persons.
Each person must have firstname, lastname, age and gender (true is female, false is male)
Generate an array with ten person with different names, ages and genders*/

function person(firstName, lastName, age, gender){
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
}


var personArr = [
    firstPerson = new person('Ivan', 'Ivanov', 14, true),
    secondPerson = new person('pesho', 'penev', 16, false),
    thirdPerson = new person('Mariika', 'Ivanova', 24, true),
];

for(var i = 0; i < personArr.length; i += 1){
    console.log(personArr[i]);
}