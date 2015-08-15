﻿//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.
//var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
//arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

function removeElement(element, array) {
    for (var index in array) {
        if (array[index] == element) {
            array.splice(index, 1);
        }
    }
    return array;
}

Array.prototype.removeElement = removeElement;

console.log([].removeElement(1, arr));