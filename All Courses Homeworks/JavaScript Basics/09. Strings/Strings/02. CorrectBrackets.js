/*Problem 2. Correct brackets
Write a JavaScript function to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)). */

function correctBrackets(expression){
    var isCorrect = true,
        leftBracket = ')',
        rightBracket = '(',
        counter = 0;
   var indexOfLeftBracket = expression.indexOf(leftBracket);
   var indexOfRightBracket = expression.indexOf(rightBracket);

    for (var i = 0; i < expression.length; i++) {

        if( indexOfLeftBracket < indexOfRightBracket){
            isCorrect = false;
            return isCorrect;
        }

        if (indexOfLeftBracket > -1 ){
            counter ++;
        }

        if(indexOfRightBracket > -1){
            counter--;
        }

        if (indexOfLeftBracket < 0 && indexOfRightBracket < 0){
            if(counter == 0){
                return isCorrect;
            }
            else return false;
        }

        indexOfLeftBracket = expression.indexOf(indexOfLeftBracket+1);
        indexOfRightBracket = expression.indexOf(indexOfRightBracket + 1);
    }
}

console.log(correctBrackets('((a+b)/5-d)'));