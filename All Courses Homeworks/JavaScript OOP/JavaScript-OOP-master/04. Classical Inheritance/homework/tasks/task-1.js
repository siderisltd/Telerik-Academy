/* Task Description */
/*
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {

	var Person = (function () {

		function Person (firstName, lastName, age) {
			this.firstname = firstName;
			this.lastname = lastName;
			this.age = age;
		}

		Object.defineProperty(Person.prototype,
				'fullname',{
				get: function () {
					return this._firstname + ' ' + this._lastname;
				},
				set: function (value) {
					var firstAndLastName = value.split(' ');
						this._firstname = firstAndLastName[0];
						this._lastname = firstAndLastName[1];
				}
			});

		Object.defineProperty(Person.prototype,
			'firstname', {
				get: function () {
					return this._firstname;
				},
				set: function (value) {
					if (validateName(value)) {
						this._firstname = value;
					}
					else {
						throw new Error('Invalid first name');
					}
				}
			});

			Object.defineProperty(Person.prototype,
		'lastname', {
				get: function () {
					return this._lastname;
				},
				set: function (value) {
					if (validateName(value)) {
						this._lastname = value;
					}
					else {
						throw new Error('Invalid last name');
					}
				}
			});

			Object.defineProperty(Person.prototype,
				'age', {
				get: function () {
					return this._age;
				},
				set: function (value) {
					if (validateAge(value)) {
						this._age = value;
					}
					else {
						throw new Error('Invalid age');
					}
				}
			});

		Person.prototype.introduce = function () {
			return 'Hello! My name is ' + this.fullname +
				' and I am ' + this.age + '-years-old'
		};

		function validateName(name) {
			if ((/^[A-Za-z]+$/g).test(name) && (name.length >= 3 && name.length <= 20)) {
				return true;
			}
			return false;
		}

		function validateAge(age) {
			age = age.toString().trim() * 1;
			if (parseInt(age) >= 0 && parseInt(age) <= 150) {
				return true;
			}
			return false;
		}

		return Person;

	}());

	return Person;
}


module.exports = solve;