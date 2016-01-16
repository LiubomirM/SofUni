function scoreMod(arr) {
    var reducedArray = new Array;

    function between(arr) {
        if(arr >= 0 && arr <= 400){
            return arr;
        }
    }
    var newArrey = arr.filter(between);

    function sortByDescending(a,b){
        return a > b;
    }

    newArrey = newArrey.sort(sortByDescending);

    for(var i in newArrey) {
        reducedArray = reducedArray.concat(newArrey[i]-newArrey[i]*0.2);
    }

    console.log(reducedArray);
}

scoreMod([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);