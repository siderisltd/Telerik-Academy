/**
 * Created by Alex on 5/30/2015.
 */
/*Problem 1. English digit
 Write a function that returns the last digit of given integer as an English word.*/

var inputNumber = 1026;

function lastDigitAsWord(input){
    var word,
        lastDigit;
    lastDigit = (input % 10) | 0;
    switch (lastDigit){
        case 1: word = 'One' ; break;
        case 2: word = 'Two' ; break;
        case 3: word = 'Three' ; break;
        case 4: word = 'Four' ; break;
        case 5: word = 'Five' ; break;
        case 6: word = 'Six' ; break;
        case 7: word = 'Seven' ; break;
        case 8: word = 'Eight' ; break;
        case 9: word = 'Nine' ; break;
        default: word = 'Not a word' ; break;
    }
    return word;
}

console.log(lastDigitAsWord(inputNumber));