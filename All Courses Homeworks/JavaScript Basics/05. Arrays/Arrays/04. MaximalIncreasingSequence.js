/**
 * Created by Alex on 5/30/2015.
 */

var arr = [
    2, 1, 2, 3, 4, 8, 6, 7, 4
];
var longestSeq = 0,
    currentSeq = 1,
    maxSeqNumber = undefined;

for(var index = 0; index < arr.length ; index +=1){
    var currentDigit = arr[index];
    if(currentDigit == Number(currentDigit)){

        if(currentDigit + 1 == arr[index + 1] && arr[index + 1] <= arr.length - 1 && arr[index + 1] == Number(arr[index+1])){
            currentSeq += 1;
        }
        else{
            currentSeq = 1;
        }
        if(currentSeq > longestSeq){
            longestSeq = currentSeq;
            maxSeqNumber = arr[index] + 1;
        }
    }
    else{
        throw new Error("Your arrays does not contain only digits");
    }
}
var start = maxSeqNumber - longestSeq + 1;
var result = [];

for(var index = start; index <= maxSeqNumber; index += 1 ){
    result.push(index);
}
console.log(result);