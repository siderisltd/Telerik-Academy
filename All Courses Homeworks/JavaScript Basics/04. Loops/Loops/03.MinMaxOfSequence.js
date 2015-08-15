/**
 * Created by Alex on 5/23/2015.
 */
/*Problem 3. Min/Max of sequence
Write a script that finds the max and min number from a sequence of numbers.*/
var numbers = [1,2,20,4,0];

var min = Number.MAX_VALUE,
    max = Number.MIN_VALUE;


for(var index in numbers){
    if(numbers[index] > max){
        max = numbers[index];
    }
    if(numbers[index] < min){
        min = numbers[index];
    }
}
console.log('Min = ' + min);
console.log('Max = ' + max);