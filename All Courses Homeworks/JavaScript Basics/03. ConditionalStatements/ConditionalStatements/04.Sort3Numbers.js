/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 4. Sort 3 numbers - Sort 3 real values in descending order.Use nested if statements.*/

var firstNumber = 5,
    secondNumber = 3,
    thirdNumber = 2;

var outputAsString = new String();

for (var index = 0; index < 3; index++) {
    var greater;
    var isFound = false;

    if (isFound === false) {
        if ((firstNumber > secondNumber) && (firstNumber > thirdNumber)) {
            greater = (firstNumber);
            isFound = true;
        }
        else if ((secondNumber > firstNumber) && (secondNumber > thirdNumber)) {
            greater = (secondNumber);
            isFound = true;
        }
        else if ((thirdNumber > firstNumber) && (thirdNumber > secondNumber)) {
            greater = (thirdNumber);
            isFound = true;
        }
    }
    if (isFound === false) {
        if ((firstNumber === secondNumber) && (secondNumber > thirdNumber)) {
            greater = (firstNumber);
        }
        if ((thirdNumber === secondNumber) && (secondNumber > firstNumber)) {
            greater = (secondNumber);
        }
        if ((thirdNumber === firstNumber) && (thirdNumber > secondNumber)) {
            greater = (thirdNumber);
        }

        if ((firstNumber === secondNumber) && (secondNumber < thirdNumber)) {
            greater = (thirdNumber);
        }
        if ((thirdNumber === secondNumber) && (secondNumber < firstNumber)) {
            greater = (firstNumber);
        }
        if ((thirdNumber === firstNumber) && (thirdNumber < secondNumber)) {
            greater = (secondNumber);
        }


        if ((thirdNumber === firstNumber) && firstNumber === secondNumber) {
            greater = (thirdNumber);
        }
    }

    if (greater === firstNumber) {
        outputAsString += firstNumber.toString();
        firstNumber = 0;
    }
    if (greater === secondNumber) {
        outputAsString += secondNumber.toString();
        secondNumber = 0;
    }
    if (greater === thirdNumber) {
        outputAsString += thirdNumber.toString();
        thirdNumber = 0;
    }
    isFound = false;
    greater = undefined;
}

console.log(parseInt(outputAsString));