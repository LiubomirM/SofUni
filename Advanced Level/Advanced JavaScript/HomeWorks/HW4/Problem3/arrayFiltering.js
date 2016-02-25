Array.prototype.flatten = function() {
    function getArrayElements(array, result) {
        if(!result) {
            result = [];
        }
        for (var i=0; i<array.length; i++) {
            if(Array.isArray(array[i])) {
                getArrayElements(array[i], result);
            }else {
                result.push(array[i]);
            }
        }
        return result;
    }
    return getArrayElements(this);
}

var array = [1, 2, 3, 4];
console.log(array.flatten());

var array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());

var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());

