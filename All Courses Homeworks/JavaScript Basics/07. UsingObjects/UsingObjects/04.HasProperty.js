//Write a function that checks if a given object contains a given property.

var pesho = { z:3, y:4};
function hasProperty(obj, property){
	if (obj[property]) {
		return true;
	}
	return false;
}

console.log(hasProperty(pesho, 'x'));