/**
 * Created by Alex on 5/30/2015.
 */
/*Problem 3. Maximal sequence
Write a script that finds the maximal sequence of equal elements in an array.*/

var arr = [
    2, 1, 1, 2, 3, 3, 2, 2, 2, 1
];
var longestSeq = 0,
    currentSeq = 1,
    repeatedNumber = undefined;

for(var index = 0; index < arr.length ; index +=1){
    var currentDigit = arr[index];
    if(currentDigit == Number(currentDigit)){

        if(currentDigit == arr[index + 1] && arr[index + 1] <= arr.length - 1 && arr[index + 1] == Number(arr[index+1])){
            currentSeq += 1;
        }
        else{
            currentSeq = 1;
        }
        if(currentSeq > longestSeq){
            longestSeq = currentSeq;
            repeatedNumber = arr[index];
        }
    }
    else{
        throw new Error("Your arrays does not contain only digits");
    }
}

console.log(Array(longestSeq + 1).join(repeatedNumber));