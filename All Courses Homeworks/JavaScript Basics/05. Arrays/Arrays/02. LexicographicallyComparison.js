/**
 * Created by Alex on 5/30/2015.
 */
/*Problem 2. Lexicographically comparison
Write a script that compares two char arrays lexicographically (letter by letter).*/

var first = ['a','b','c'],
    second = ['a','b'],
    firstStr = 'asd',
    secondStr = 'asd';

function areEqual (charArrOne, charArrTwo){

    var areEqual = true;

    if(first.length !== second.length){
        areEqual = false;
        return areEqual;
    }
    else{
        for (var index = 0; index < first.length; index += 1) {
            if(first[index] !== second[index]){
                areEqual = false;
            }
        }
    }
    return areEqual;
}


console.log(areEqual(first,second));