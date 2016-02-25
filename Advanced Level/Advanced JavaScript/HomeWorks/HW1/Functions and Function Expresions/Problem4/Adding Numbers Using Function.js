var addTwo;

function add(a) {

    var sum = a;

    function f(b) {
        sum += b;
        return f;
    }

    f.toString = function() { return sum }

    return f;
}
console.log(add(1)(2).toString());
