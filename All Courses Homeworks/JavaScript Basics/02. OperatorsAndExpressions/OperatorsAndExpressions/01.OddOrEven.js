/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.*/

var num = 0;
var isOdd;

function checkOddOrEven(number) {
    if (num % 2 === 0) {
        isOdd = false;
    }
    else {
        isOdd = true;
    }
    return isOdd;
}

console.log(checkOddOrEven(num));
