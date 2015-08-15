/*Problem 5. Selection sort
Sorting an array means to arrange its elements in increasing order.
Write a script to sort an array.
Use the selection sort algorithm: Find the smallest element, move it at the first position,
find the smallest from the rest, move it at the second position, etc.
Hint: Use a second array*/

var arr = [
    56,67,87,89,56,4,2,12,43,56
],
    min,
    swapPos,
    shouldSwap;

for(var i = 0; i < arr.length - 1 ; i+=1){
    min = arr[i];
    for(var j = i; j < arr.length; j+=1){
        if(arr[j] < min){
            shouldSwap = true;
            min = arr[j];
            swapPos = j;
        }
    }
    //swapping elements
    if(shouldSwap){
        var temp = arr[i];
        arr[i] = min;
        arr[swapPos] = temp;
        swapPos = undefined;
    }
    shouldSwap = false;
}

console.log(arr);


