/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 6. Point in Circle
 Write an expression that checks if given point P(x, y) is within a circle K(O, 5).*/

var point = {x:4, y:-3};

var checkIfIsInCircle = function(point){
    if(point.x <= 5 && point.x >= -5 && point.y <=5 && point.y >= -5){
        return console.log('It is in the circle');
    }
    else{
        return console.log('It is not in the circle');
}
};

checkIfIsInCircle(point);
