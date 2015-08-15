/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 3. The biggest of Three
 Write a script that finds the biggest of three numbers. Use nested if statements.*/

var firstNumber = 1,
    secondNumber =10,
    thirdNumber = 10;

var isFound = false;

if (firstNumber !== undefined || secondNumber !== undefined || thirdNumber !== undefined) {
    if ((firstNumber > secondNumber) && (firstNumber > thirdNumber)) {
        console.log(firstNumber);
        isFound = true;
    }
    else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber)) {
        console.log(secondNumber);
        isFound = true;
    }
    else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber)) {
        console.log(thirdNumber);
        isFound = true;
    }
}
if ((firstNumber !== undefined || secondNumber !== undefined || thirdNumber !== undefined) && isFound === false) {
    if ((firstNumber === secondNumber) && (secondNumber > thirdNumber)) {
        console.log(firstNumber);
    }
    if ((thirdNumber === secondNumber) && (secondNumber > firstNumber)) {
        console.log(secondNumber);
    }
    if ((thirdNumber === firstNumber) && (thirdNumber > secondNumber)) {
        console.log(thirdNumber);
    }

    if ((firstNumber === secondNumber) && (secondNumber < thirdNumber)) {
        console.log(thirdNumber);
    }
    if ((thirdNumber === secondNumber) && (secondNumber < firstNumber)) {
        console.log(firstNumber);
    }
    if ((thirdNumber === firstNumber) && (thirdNumber < secondNumber)) {
        console.log(secondNumber);
    }


    if ((thirdNumber === firstNumber) && firstNumber === secondNumber) {
        console.log(thirdNumber);
    }
}
if ((firstNumber === undefined || secondNumber === undefined || thirdNumber === undefined)){
    throw new Error('Some of the numbers is undefined');
}