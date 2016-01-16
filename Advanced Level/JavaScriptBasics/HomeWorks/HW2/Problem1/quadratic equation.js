function quadratic_equation(a, b, c) {
    var a, b, c;

    var d = Math.pow(b, 2)-(4 * a * c);
    var x1 = (-b + Math.sqrt(d))/(2*a);
    var x2 = (-b - Math.sqrt(d))/(2*a);

    if (d < 0) {
        console.log("No real roots");
    } else if (d == 0) {
        console.log("X = "  + x1);
    } else {
        console.log("X1 = " + x1 + "\nX2 = " + x2);
    }
}
quadratic_equation(3,4,5);
quadratic_equation(2,5,-3);
quadratic_equation(2,-4,2);
quadratic_equation(4,2,1);