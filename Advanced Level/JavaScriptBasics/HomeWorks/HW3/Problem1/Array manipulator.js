function filter(arr) {
    var numbers = new Array;

    for(var arg in arr) {
        if(typeof arr[arg] === "number") {
            numbers = numbers.concat(arr[arg]);
        }
    }

    function sortByDescending(a,b){
        return a < b;
    }

    numbers.sort(sortByDescending);

    var n = max = 1, maxNum = numbers[0], prevValue, curentValue;

    for(var i = 0; i < numbers.length; i++) {
        prevValue = numbers[i-1];
        curentValue = numbers[i];
        if (prevValue == curentValue) {
            if (++n >= max) {
                max = n;
                maxNum = curentValue;
            }
        } else {
            n = 1;
        }
    }

    console.log('Min number: ' + numbers[numbers.length-1]);
    console.log('Max number: ' + numbers[0]);

    if(max === 1 || numbers.length === 1) {
        console.log('Most frequent number: None');
    } else {
        console.log('Most frequent number: ' + maxNum);
    }
    console.log(numbers);
}

filter(["Pesho", 2, "Gosho", 12, 12, 2, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]);
filter([1,2,3,4]);
filter([1]);