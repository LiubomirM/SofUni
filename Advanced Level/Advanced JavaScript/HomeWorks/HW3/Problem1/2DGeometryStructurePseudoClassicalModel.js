var Shape = (function(){
    function Shape(x, y, color) {
        this._x = x;
        this._y = y;
        this._color = color;
    }
    Shape.prototype.toString = function() {
        return "(" + this._x + "," + this._y + ")" +" color = " + this._color;
    }
    return Shape;
})();

var Circle = (function (){
    function Circle(x, y, r, color){
        Shape.call(this, x, y, color);
        this._r = r;
    }
    Circle.prototype = Object.create(Shape.prototype);
    Circle.prototype.constructor = Circle;
    Circle.prototype.toString = function() {
        return "O" + Shape.prototype.toString.call(this) + " r = " + this._r;
    }
    return Circle;
})();

var Rectangle = (function() {
    function Rectangle(x, y, width, height, color) {
        Shape.call(this, x, y, color);
        this._width = width;
        this._height = height;
    }
    Rectangle.prototype = Object.create(Shape.prototype);
    Rectangle.constructor = Rectangle;
    Rectangle.prototype.toString = function(){
        return "A" + Shape.prototype.toString.call(this) + " width = " + this._width + " height = " +this._height;
    }
    return Rectangle;
})();

var Triangle = (function() {
    function Triangle(x1, y1, x2, y2, x, y, color) {
        Shape.call(this,x, y, color);
        this._x1 = x1;
        this._y1 = y1;
        this._x2 = x2;
        this._y2 = y2
    }
    Triangle.prototype = Object.create(Shape.prototype);
    Triangle.constructor = Triangle;
    Triangle.prototype.toString = function() {
        return "A(" + this._x1 + "," + this._y1 + ")" + " B(" + this._x2 + "," + this._y2 + ")" + " C" + Shape.prototype.toString.call(this);
    }
    return Triangle;
})();

var Line = (function() {
    function Line(x1, y1, x, y, color) {
        Shape.call(this, x, y, color);
        this._x1 = x1;
        this._y1 = y1;
    }
    Line.prototype = Object.create(Shape.prototype);
    Line.constructor = Line;
    Line.prototype.toString = function() {
        return "A(" + this._x1 + "," + this._y1 + ")" + " B" + Shape.prototype.toString.call(this);
    }
    return Line;
})();

var Segment = (function() {
    function Segment(x1, y1, x, y, color) {
        Shape.call(this, x, y, color);
        this._x1 = x1;
        this._y1 = y1;
    }
    Segment.prototype = Object.create(Shape.prototype);
    Segment.constructor = Segment;
    Segment.prototype.toString = function() {
        return "A(" + this._x1 + "," + this._y1 + ")" + " B" + Shape.prototype.toString.call(this);
    }
    return Segment;
})();

var o = new Circle(1,2,5,'ff');
console.log(o.toString());

var r = new Rectangle(2,4,5,6,12);
console.log(r.toString())

var t = new Triangle(3,6,6,1,3,8,'ff');
console.log(t.toString());

var l = new Line(11, 5, 3, 6, 'fe');
console.log(l.toString());

var s = new Segment(21,32,43,12,'aa');
console.log(s.toString());