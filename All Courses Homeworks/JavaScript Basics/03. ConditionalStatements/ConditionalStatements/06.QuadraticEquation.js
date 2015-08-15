/**
 * Created by Alex on 5/22/2015.
 */
/* Problem 6. Quadratic equation
Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Calculates and prints its real roots.Note: Quadratic equations may have 0, 1 or 2 real roots. */

var a = -1,
    b = 3,
    c = -0;

var discriminant = Math.pow(b,2) - (4*a*c);

if(discriminant < 0 ){
    console.log("This equasion has no real roots")
}
if (discriminant == 0)
{
    console.log("Only one root exist");
    var firstRoot = ((-b - Math.sqrt(discriminant)) / (2 * a));
    var secondRoot = ((-b + Math.sqrt(discriminant)) / (2 * a));
    if(firstRoot === secondRoot){
        console.log("X1=" + firstRoot);
    }

}
if(discriminant > 0){
    console.log("Two roots exists");
    var firstRoot = ((-b - Math.sqrt(discriminant)) / (2 * a));
    var secondRoot = ((-b + Math.sqrt(discriminant)) / (2 * a));
    console.log("X1=" + firstRoot);
    console.log("X2=" + secondRoot);
}