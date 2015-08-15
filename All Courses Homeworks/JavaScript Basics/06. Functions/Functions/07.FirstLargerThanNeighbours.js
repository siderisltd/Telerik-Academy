/**
 * Created by Alex on 5/31/2015.
 */
/*Problem 7. First larger than neighbours
Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
Use the function from the previous exercise.*/

arr = [
    1,2,3,4,9
];

function largerThanNeighbours(arr){
    var position = 0;
    while(true) {
        if (arr[position - 1] != null && arr[position + 1] != null) {
            if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1]) {
                return position;
            }
        }
        position += 1;

        if (position == arr.length - 1) {
            return -1;
        }
    }
}

console.log(largerThanNeighbours(arr));