/**
 * Created by Alex on 5/31/2015.
 */
/*Problem 5. Appearance count
Write a function that counts how many times given number appears in given array.
Write a test function to check if the function is working correctly.*/
function testAppearanceCount(arr, number, result) {
    var testArr1 = [1, 2, 3, 4, 5, 65, 5, 3, 2, 5, 3, 4, 5, 6],
        testArr2 = [1, 2, 3, 4, 3, 2, 1, 3, 4, 5, 6, 7, 4, 3, 5, 6],
        testArr3 = [1, 2, 3, 4, 2, 1, 2, 2, 3, 4, 5, 3, 2, 1, 3, 4, 5];

    return testArr1;
}

var arr = [1,3,2,1,2,3];


function appearanceCount(arr, number){

    var args = [].slice.apply(arguments),
        index = 0;

    if(args[0] instanceof Function){
            for(index; index < arr.length ; i++){

                appearanceCount(arr[index],number);
            }
    }

    var i,
        count = 0;
    for(i in arr){
        if(arr[i] === number){
            count += 1;
        }
    }
    console.log(count);
    count = 0;
}

appearanceCount(testAppearanceCount,1);