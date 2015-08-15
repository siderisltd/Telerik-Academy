/**
 * Created by Alex on 5/22/2015.
 */


var p = {x:2.5, y:1.5};
var isInCircleAndOutsideRectangle = "No";

var isInCircleAndOutsideRectangleFunction = function(point){
    if((p.x <= 4 && p.x >= -2) && (p.y <= 4 && p.y >= -2)){
        //already is in the circle
        if((p.x <= 5 && p.x >= -1) && (p.y <= 1 && p.y >= -1)){
            //is also in the rectangle
            isInCircleAndOutsideRectangle = "No";
        }
        else {
            isInCircleAndOutsideRectangle = "Yes";
        }
    }
    return isInCircleAndOutsideRectangle;
};
console.log(isInCircleAndOutsideRectangleFunction(p));
