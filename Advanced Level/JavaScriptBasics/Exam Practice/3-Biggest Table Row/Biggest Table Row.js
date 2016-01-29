function solve(arr) {
    var out = -9000000000;
    for (var i = 2; i < arr.length - 1; i++) {
        var regex = /([\d.-]+)/g;
        var line = arr[i].match(regex);
        var store1 = Number(line[0]);
        var store2 = Number(line[1]);
        var store3 = Number(line[2]);
        var sum = new Number();

        if(!isNaN(store1)){
            sum += store1;
        }
        if(!isNaN(store2)) {
            sum += store2;
        }
        if(!isNaN(store3)) {
            sum += store3;
        }

        if((out < sum) && (typeof sum != 'object')) {
            var outString = '';
            out = sum;
            var nums = line;
            for (var number in nums) {
                if(nums[number] != '-') {
                    outString += nums[number] + ' + ';
                }
            }
            outString = outString.slice(0, outString.length - 3);
        }
    }
    if(out === -9000000000) {
        console.log('no data');
    }
    else {
        console.log(out + ' = ' + outString);
    }
}

var arr = [ '<table>',
        '<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
        '<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
        '<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
        '</table>' ]
    ;

solve(arr)