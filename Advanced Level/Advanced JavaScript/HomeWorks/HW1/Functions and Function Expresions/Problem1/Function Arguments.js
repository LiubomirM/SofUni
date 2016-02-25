function printArgsInfo() {
    var arg = arguments;
    for (var i in arg){
        if(arg[i] instanceof Array) {
            console.log(arg[i] + ' (array)');
        }else {
            console.log(arg[i] + ' (' + typeof arg[i] + ')');
        }
    }
}

printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]]);