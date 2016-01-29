function solve(arr) {

    var start = arr[0];
    var end = arr[1];

    console.log('<table>');
    console.log('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');

    for (var i = start; i <= end; i++) {

        var isFib;
        var fib1 = 0;
        var fib2 = 1;
        do {
            var saveFib1 = fib1;
            fib1 = fib2;
            fib2 = saveFib1 + fib2;
        }
        while (fib2 < i);

        if (fib2 === i){
            isFib = 'yes';
        } else {
            isFib = 'no';
        }

        console.log('<tr><td>'+i+'</td><td>'+i*i+'</td><td>'+isFib+'</td></tr>')

    }

    console.log('</table>');
}

solve([2,6]);