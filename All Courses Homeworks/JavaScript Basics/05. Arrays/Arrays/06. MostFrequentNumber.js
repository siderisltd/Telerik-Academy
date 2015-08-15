/**
 * Created by Alex on 5/30/2015.
 */
/*Problem 6. Most frequent number
Write a script that finds the most frequent number in an array.
Example: 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/

var arr = [
    4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 4
],
    counter,
    mostFrequentElement,
    maxCount = 0;

//logic hvashtame vseki element po otdelno i s nego obikalqme cikula i sravnqvame

for(var i = 0; i < arr.length ; i += 1){
    var currentElement = arr[i];
    counter = 0;
    for(var j = 0; j < arr.length ; j += 1){
        if(currentElement === arr[j]){
            counter += 1;
            if(counter > maxCount){
                maxCount = counter;
                mostFrequentElement = currentElement;
            }
        }
    }
}
console.log('Most frequent element is: ' + mostFrequentElement + ' [ ' + maxCount +' ] times');