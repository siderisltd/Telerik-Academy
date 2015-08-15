/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 7. Is prime
 Write an expression that checks if given positive integer number n (n ? 100) is prime.*/

var number = 7;
var isPrime = false;

if (number === 1) {
    isPrime = false;
}
else {
    for (var index = 2; index <= Math.sqrt((number | 0)); index++) {
        if (number % index === 0) {
            console.log(isPrime);
        }
        else {
            isPrime = true;
            console.log(isPrime);
        }
    }
}