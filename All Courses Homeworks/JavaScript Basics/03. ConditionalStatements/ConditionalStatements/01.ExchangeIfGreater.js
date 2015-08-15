/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 1. Exchange if greater
Write an if statement that takes two double variables a and b and exchanges
their values if the first one is greater than the second.As a result print the values a and b, separated by a space*/

var a = 0,
    b = -5;

if(a !== null || a !== undefined){
    if(a > b){
        var temp = b;
        b = a;
        a = temp;
    }
}
console.log('a = ' + a + ' ' +'b = ' + b);