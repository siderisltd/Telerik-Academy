//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.
//Example:
//var people = [
//  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
//  { firstname : 'Bay', lastname: 'Ivan', age: 81},… ];

var people = [
  { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Pesho', lastname: 'Kondov', age: 42 },
  { firstname: 'Ganka', lastname: 'Ivanova', age: 23 },
  { firstname: 'Ivanka', lastname: 'Peneva', age: 12 },
  { firstname: 'Zlatka', lastname: 'Chervenata', age: 66 },
  { firstname: 'Goshko', lastname: 'Hubaveca', age: 33 },
  { firstname: 'Qn', lastname: 'Bibiqn', age: 6 },
];

function findYoungest(objArr) {
	var minAge = Number.MAX_VALUE,
	             searchedIndex;

	for (var index in objArr) {
		
		if (objArr[index].age) {
			if (minAge > objArr[index].age) {
				minAge = objArr[index].age;
				searchedIndex = index;
			}
		}
	}
	return objArr[searchedIndex];
}

console.log(findYoungest(people));