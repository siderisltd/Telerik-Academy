(function () {
	var Shape = (function () {

		function Shape(x, y) {
			this._x = x;
			this._y = y;
		}

		Shape.prototype.move = function (to) {
			this._x += to || this._x;
			this._y += to || this._y;
		};

		return Shape;
	}());

	var Rect = (function () {

		function Rect(x, y, width, height) {
			Shape.call(this, x, y);
			this._width = width;
			this._height = height;
		}

	    Rect.prototype = new Shape();

		Rect.prototype.calcArea = function () {
			return this._width * this._height;
		};

		return Rect;
	}());

	console.log(new Rect(1, 2, 30, 30).move(10));
}());
