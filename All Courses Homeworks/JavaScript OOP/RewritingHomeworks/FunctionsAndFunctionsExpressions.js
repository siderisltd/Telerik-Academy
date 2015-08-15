//Task 1.
//
//Write a function that sums an array of numbers:
//    Numbers must be always of type Number
//Returns null if the array is empty
//Throws Error if the parameter is not passed (undefined)
//Throws if any of the elements is not convertible to Number

function sum() {
    var numArr = arguments[0];
    if(numArr === 'undefined'){
        throw new Error('num is undefined')
        }
    if(numArr.length = 0){
        return null;
    }
        var toNum = numArr.every(function(num){
                return parseInt(num);
            });
var sum = 0;
    if(toNum) {
        for(var i in numArr){
            sum += numArr[i];
        }
        console.log(sum);
    }
    else{
        throw new Error('wtf');
    }
}
var arr = [1,3,2];

console.log(sum(arr));
module.exports = sum;