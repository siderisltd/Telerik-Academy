/**
 * Created by Alex on 5/30/2015.
 */
/*Problem 2. Reverse number
Write a function that reverses the digits of given decimal number.*/

var number = 123.45;

function reverseNumber(num){
    num = num.toString();
    var newNum = '';
    for(var i = 0; i < num.length; i++ ){
        newNum += num[num.length - i - 1];
    }
    return newNum;
}

console.log(reverseNumber(number));