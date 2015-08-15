//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function P(x, y) {
	this.X = x;
	this.Y = y;
}

var P1 = new P(-2, -3);
var P2 = new P(-4, 4);

var L = { 'Beginning': P1, 'Ending': P2 };

function CalculateDistance(firstPoint, secondPoint) {
	var differenceX = Math.pow((secondPoint.X - firstPoint.X), 2);
	var differenceY = Math.pow((secondPoint.Y - firstPoint.Y), 2);
	var interval = Math.sqrt(differenceX + differenceY).toFixed(2);
	return interval ;
}

console.log(CalculateDistance (P1, P2));