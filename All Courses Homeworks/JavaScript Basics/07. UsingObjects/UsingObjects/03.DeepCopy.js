//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

var simpleObj = { x: 3, y: 4 };

function deepCopy(obj) {
	var copy = (JSON.parse(JSON.stringify(obj)));
	return copy;
}

var copy = deepCopy(simpleObj); //our deep copy object

console.log(copy);