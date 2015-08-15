/**
 * Created by Alex on 5/22/2015.
 */
/* Problem 4. Third digit
Write an expression that checks for given integer if its third digit (right-to-left) is 7. */

var number = 12900;

var thirdDigit = ((number / 100) % 10 ) | 0;

console.log(thirdDigit)