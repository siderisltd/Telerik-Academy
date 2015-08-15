/*Write a function that sums an array of numbers:
Numbers must be always of type Number
Returns null if the array is empty
Throws Error if the parameter is not passed (undefined)
Throws if any of the elements is not convertible to Number*/

function sum(numArr){
    var arr = [];
    arr = numArr;
if(arguments[0] === undefined) {
    throw Error("The parameter should be an array of numbers");
}
    var isAllNumbers = arr.every(function(number){
        return parseInt(number);
    });

    if(!isAllNumbers) {
        throw new Error("All numbers should be convertible to 'Number'");
    }
    if(arr.length === 0) {
        return null;
    }
    if(numArr instanceof String){
        arr = numArr.split(',').map(Number);
    }
    else if(numArr instanceof Array){
        arr = numArr.map(Number);
    }

    var sum = 0;

    arr.forEach(function(value){
        return sum += value;
    });

    return sum;
}
module.exports = sum;
//console.log(sum([1,2,3]));