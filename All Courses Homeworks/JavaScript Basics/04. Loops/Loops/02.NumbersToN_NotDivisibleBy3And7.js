/**
 * Created by Alex on 5/23/2015.
 */
/*Problem 2. Numbers not divisible
Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time*/

var n = 22;

for(var index = 1; index <= n; index++){
    if(index % 3 == 0 && index % 7 == 0){
        continue;
    }
    console.log(index);
}