var Shape = {
    init: function(color){
        this._color = color;
    },
    toString: function() {
        return "color = " + this._color;
    }
};

var Circle = Object.create(Shape);
Circle.init = function(x, y, r, color){
    Shape.init.call(this, color);
    this._x = x;
    this._y = y;
    this._r = r;
}
Circle.toString = function(){
    var result = "O(" + this._x + "," + this._y + ")";
    result += " radius = " + this._r;
    result += " " + Shape.toString.call(this);
    return result;
}

var Rectangle = Object.create(Shape);
Rectangle.init = function(x, y, width, height, color){
    Shape.init.call(this, color);
    this._x = x;
    this._y = y;
    this._width = width;
    this._height = height;
}
Rectangle.toString = function(){
    var result = "A(" + this._x + "," + this._y + ")";
    result += " width = " + this._width;
    result += " height = " + this._height;
    result += " " + Shape.toString.call(this);
    return result;
}

var Triangle = Object.create(Shape);
Triangle.init = function(x, y, x1, y1, x2, y2, color) {
    Shape.init.call(this, color);
    this._x = x;
    this._y = y;
    this._x1 = x1;
    this._y1 = y1;
    this._x2 = x2;
    this._y2 = y2;
}
Triangle.toString = function(){
    var result = "A(" + this._x + "," + this._y + ")";
    result += " B(" + this._x + "," + this._y + ")";
    result += " C(" + this._x + "," + this._y + ")";
    result += " " + Shape.toString.call(this);
    return result;
}

var Line = Object.create(Shape);
Line.init = function(x, y, x1, y1, color) {
    Shape.init.call(this, color);
    this._x = x;
    this._y = y;
    this._x1 = x1;
    this._y1 = y1;
}
Line.toString = function() {
    var result = "A(" + this._x + "," + this._y + ")";
    result += " B(" + this._x1 + "," + this._y1 + ")";
    result += " " + Shape.toString.call(this);
    return result;
}

var krug = Object.create(Circle);
krug.init(2,4,5,'AAA');
console.log(krug.toString());

var kvadrat = Object.create(Rectangle);
kvadrat.init(1,3,11,22,'ASD');
console.log(kvadrat.toString());

var triugulnik = Object.create(Triangle);
triugulnik.init(9,8,7,6,5,4,'BBB');
console.log(triugulnik.toString());

var liniq = Object.create(Line);
liniq.init(11,12,22,23,'ABB');
console.log(liniq.toString());