/**
 * Created by Alex on 5/30/2015.
 */

/*var arr = [
    56,67,87,89,56,4,2,12,43,56,78,876
];*/
//shte tursim 78

var arr = [
 1,5,6,9,12,18,45,56,79,83,94,99
 ];

var searchedNumber = 94;

function binarySearch (array, searchedNumber, aMin, aMax){
    //duno na rekursiqta
    if (aMax < aMin)
    // set is empty, so return value showing not found
        return 'KEY_NOT_FOUND';

    var mid = (aMin + aMax + 1 )/ 2 | 0; //(arr.length / 2) | 0;
    var itemAtMidPosition = arr[mid];  //45

    if(searchedNumber == itemAtMidPosition){
        return mid;
    }

    if(searchedNumber > itemAtMidPosition){
        //mid stava nachaloto i se tursi do kraq
        return binarySearch(arr, searchedNumber, mid + 1, aMax);

    }
    if(searchedNumber < itemAtMidPosition){
        //mid stava kraq i se tursi ot nachaloto
        return binarySearch(arr, searchedNumber, aMin, mid - 1);
    }
}

console.log(binarySearch(arr,searchedNumber, 0,arr.length - 1));
