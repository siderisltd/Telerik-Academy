/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 5. Third bit
Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

var number = 85;

var mask = 1;
var bitNumber = 3; // counting from 0
var numberInBinary = parseInt(number.toString(2));
var searchedBit = (numberInBinary & (mask << bitNumber)) >> bitNumber;

console.log(searchedBit);