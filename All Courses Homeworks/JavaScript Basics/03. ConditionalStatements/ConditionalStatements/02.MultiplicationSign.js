/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 2. Multiplication Sign
 Write a script that shows the sign (+, - or 0) of the product of three real numbers,
 without calculating it.Use a sequence of if operators.*/

var firstNumber = 5,
    secondNumber = -2,
    thirdNumber = 9;

if(firstNumber < 0 || secondNumber < 0 || thirdNumber < 0){
 console.log('Sign : \"-\"');
}

else{
 console.log('Sign : \"+\"');
}