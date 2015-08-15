//**//  preobrazuvane na masiv v numbers  ----> moje i bez split-a //**//
//  arr = numArr.split(',').map(Number);

//**//  fast sum array members   //**//
//var sum = 0;
//arr.forEach(function(value){
//    return sum += value;
//});

//**//  dali vsichki sa chisla   //**//
//var isAllNumbers = arr.every(function(number){
//    return parseInt(number);
//});

//**//  dali vsichki elementi se konvertirat kum number   //**//
//var isConvertable = args.every(function(number){
//    number = parseInt(Number);
//    return typeof number == 'number';
//});

//**//  isPrime number  //**//
//function isPrime(number){
//    if (number == 1 || number <= 0){
//        return false;
//    }
//    var numSqrt = Math.sqrt(number);
//    var isPrime = true;
//
//    for (var i = 2; i <= numSqrt; i++) {
//        if(i === number){
//            continue;
//        }
//
//        if(number % i === 0) {
//            isPrime = false;
//            return isPrime;
//        }
//    }
//    return isPrime;
//}

//**//  IsGivenPropertyUnique SOME example  //**//  -- vrushta true ako se povtarq i false ako e unikalno
//function isIsbnUnique(isbn){
//    return books.some(function(book){
//        return isbn === book.isbn;
//    });
//}

//**//   dali vsichko e string //**//
//function isEveryArrayElementString (elements) {
//    return elements.every(function (element) {
//        return typeof element === 'string';
//    });
//}

//**//  is valid id between min and max allowed and is it number //**//
//function isValidIdNumberInGivenRange(id, min, max){
//    if(id != Number(id)){
//        throw 'Invalid type for id.';
//    }
//    if(id < min || id > max){
//        throw 'Invalid range.';
//    }
//}

//**//  Check if someElement inherits another //**//
//function checkForInheritance(parent, child) {
//    if (parent.isPrototypeOf(child)) {
//        return true;
//    }
//}

//**// Check for existing attribute ---> attribute, self = this //**//
//function checkIfExistingAttribute(attribute, self) {
//    if (checkIfString(attribute)) {
//        for (attr in self.attributes) {
//            if (attr == attribute) {
//                return true;
//            }
//        }
//
//        return false;
//    } else {
//        return false;
//    }
//}

//**//  Is this empty object --> only element's properties [without parent properties] //**//
//function isEmptyObject(obj) {
//    for (var prop in obj) {
//        if (obj.hasOwnProperty(prop)) {
//            return false;
//        }
//    }
//    return true;
//}

//**//  Extracting all elements by given property in array of objects //**//
//var females = objArr.filter(function(value){
//    return value.gender === 'female';
//});

//**// Extracting average from array / SUM / * , / with [].filter   [0 is the innitisl sum value] //**//
//MyArrauOfObjects.reduce(function(sum, object) {
//    return sum + object.property;
//}, 0) / females.length;




validator = {

    validateIfUndefined: function (val, name) {
        name = name || 'Value';
        if (typeof val === 'undefined') {
            throw new Error(name + ' cannot be undefined');
        }
    },

    validateIfObject: function (val, name) {
        name = name || 'Value';
        if (typeof val !== 'object') {
            throw new Error(name + ' must be an object');
        }
    },

    validateIfString: function (val, name) {
        name = name || 'Value';
        this.validateIfUndefined(val, name);

        if (typeof val !== 'string') {
            throw new Error(name + ' must be a string');
        }

        //if (val.length < CONSTANTS.TEXT_MIN_LENGTH
        //        || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
        //    throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH +
        //            ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols');
        //}
    },

    validateIfNumber: function (val, name) {
        name = name || 'Value';

        if (typeof val !== 'number') {
            throw new Error(name + ' must be a number');
        }
    },

    validatePositiveNumber: function (val, name) {
        name = name || 'Value';

        //this.validateIfUndefined(val, name);
        this.validateIfNumber(val, name);

        if (val <= 0) {
            throw new Error(name + ' must be positive number');
        }
    },

    validateId: function (id) {
        this.validateIfUndefined(id, 'From validateID ');
        this.validateIfNumber(id, 'From validateNumber in ValidateID')
        this.validatePositiveNumber(id, ' ID MUST BE POSITIVE FROM VALIDATE_ID')
        if (typeof id !== 'number') {
            id = id.id;
        }

        this.validateIfUndefined(id, 'Object must have id');
        return id;
    },   // tova se polzva s id = validateId(id); - ID trqbva da e num

    validateIsArray: function (val, name) {
        name = name || 'Value';

        if (!Array.isArray(val)) {
            throw new Error(name + ' is not array');
        }
    },

    validateAreAllArrMembersAreNumbers: function (val, name) {
        name = name || 'Value';
        this.validateIsArray(val, name);

        var isAllNumbers = val.every(function (number) {
            return parseInt(number);
        });

        if (!isAllNumbers) {
            throw new Error(name + ' Not all members are numbers');
        }

    },

    validateAreAllArrMembersAreStrings: function (val, name) {
        name = name || 'Value';
        this.validateIsArray(val, name);

        var isEveryElementString = val.every(function (element) {
            return typeof element === 'string';
        });

        if (!isEveryElementString) {
            throw new Error(name + ' Not all members are STRINGS');
        }
    },

    validateAreAllArrayElementsConvertibleToNumber: function (val, name) {
        name = name || 'Value';
        this.validateIsArray(val, name);

        var isConvertable = val.every(function (number) {
            number = parseInt(Number);
            return typeof number == 'number';
        });

        if (!isConvertable) {
            throw Error(name + ' Elements are not convertible to NUMBER');
        }
    },
    //must just have property length
    validateIfLenghtIsBetweenMinAndMax: function (val, name, minLength, maxLength) {
        name = name || 'Value';

        if (!val.length) {
            throw new Error('The value must have property length');
        }

        if (val.length < minLength || val.length > maxLength) {
            throw new Error(name + ' has invalid length');
        }

    }, //look it before use

    validateIfSomeElementInheritsAnother: function (child, parent, name) {
        name = name || 'Value';
        this.validateIfUndefined(child);
        this.validateIfUndefined(parent);

        var isParent = false;

        if (parent.isPrototypeOf(child)) {
            isParent = true;
        }

        if (!isParent) {
            throw new Error('NAME:' + name + ' CHILD: ' + child + ' is not child of ' + parent)
        }

    },
    //attribute, self = this //**// izpolzva se s this za konkretniq obekt i vaji samo za negovite si propertyta mai
    //CheckItBefore USING
    checkIfExistingAttribute: function (attribute, self , name) {
        name = name || 'Value';
        this.validateIfUndefined(self);
        this.validateIfObject(self);

        var isThereAttr = false
        // if (checkIfString(attribute)) {
        for (attr in self.attributes) {
            if (attr == attribute) {
                isThereAttr = true;
            }
        }
        // }

        if (isThereAttr = false) {
            throw new Error(name + ' ATTRIBUTE : ' + attribute + ' is NOT EXIST ')
        }
    }
};