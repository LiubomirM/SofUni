function printArgsInfo() {
    var arg = arguments;
    if(arg.length === 0){
        console.log('No args');
    }else {
        for (var i in arg) {
            if (arg[i] instanceof Array) {
                console.log(arg[i] + ' (array)');
            } else {
                console.log(arg[i] + ' (' + typeof arg[i] + ')');
            }
        }
    }

}
var args = [[1, [2, [3, [4, 5]]]], ["string", "array"], 23, 'Pesho', undefined];
console.log('Print Call without arguments');
printArgsInfo.call(this);

console.log('Print Call with arguments');
printArgsInfo.call(this,[23,23], 23, 'Gosho', undefined, {});

console.log('Print Aplly without arguments');
printArgsInfo.apply(this);

console.log('Print Call without arguments');
printArgsInfo.apply(this, args);


