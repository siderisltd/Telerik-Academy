//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)
//Example:
//var people = {…};
//var groupedByFname = group(people, 'firstname');
//var groupedByAge= group(people, 'age');

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

function group(objArr, groupParam) {
	var associativeArr = {};

	for (var i in objArr) {
		if (objArr[i].firstname[0].toLowerCase < 'e') {
			associativeArr.firstname.push(objArr[i]);
		}
	}

	//switch (groupParam) {
	//	case 'firstname': break;
	//	case 'lastname': break;
	//	case 'age': break;
	//	default:
	return associativeArr;

}

console.log(people, 'firstname');