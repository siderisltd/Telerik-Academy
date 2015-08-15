/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 2. Divisible by 7 and 5
Write a boolean expression that checks for given integer if it can be divided
(without remainder) by 7 and 5 in the same time.*/

var number= 36;
var result;

function divisibleBy7And5(number){
    if(number % 5 === 0 && number % 7 === 0){
        result = true;
    }
    else{
        result = false;
    }
    return result;
}

console.log(divisibleBy7And5(number));
