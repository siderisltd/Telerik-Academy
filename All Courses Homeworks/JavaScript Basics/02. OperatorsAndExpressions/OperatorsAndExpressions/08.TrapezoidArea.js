/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 8. Trapezoid area
 Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

var a = 0.222,
    b = 0.333,
    h = 0.555;

var calculateTerapezoidArea = function (a, b, h) {
    var area = parseFloat(((a + b)/2 *h).toPrecision(7)); // Making the result to have precision of 7 digits
    return area;
};

console.log(calculateTerapezoidArea(a,b,h));