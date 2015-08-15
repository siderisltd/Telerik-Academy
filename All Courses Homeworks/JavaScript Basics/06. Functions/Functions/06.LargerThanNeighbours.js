/**
 * Created by Alex on 5/31/2015.
 */
/*Problem 6. Larger than neighbours
Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).*/

arr = [
    1,2,7,4,9
],
    position = 2;

function largerThanNeighbours(arr, position){
    if(arr[position - 1] != null && arr[position + 1] != null){
        if(arr[position] > arr[position + 1] && arr[position] > arr[position - 1]){
            return true;
        }
        else{
            return false;
        }
    }
    else{
        return 'There is no element before or after';
    }
}

console.log(largerThanNeighbours(arr,position));