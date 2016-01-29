function solve(arr) {
    var numbers = arr.map(Number);
    var prev = undefined;
    console.log('<table>');
    console.log('<tr><th>Price</th><th>Trend</th></tr>');
    for (var i in numbers) {
        var currentNum = numbers[i];
        var current = currentNum.toFixed(2);
        if (prev === undefined || prev === current) {
            var trend = 'fixed.png';
        }else if (currentNum < prev) {
            var trend = 'down.png';
        }else {
            var trend = 'up.png';
        }
        prev = current;
        console.log("<tr><td>" + current + "</td><td><img src=\"" + trend + "\"/></td></tr>");

    }
    console.log('</table>');
}

var arr = [ '1.33',
    '1.334',
    '2.25',
    '13.00',
    '0.5',
    '0.51',
    '0.5',
    '0.5',
    '0.33',
    '1.05',
    '1.346',
    '20',
    '900',
    '1500.1',
    '1500.10',
    '2000'];

solve(arr);