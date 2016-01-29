function solve(arr) {
    var data = [];
    for (var row = 2; row < arr.length-1; row++) {
        var regex = /<tr><td>(.+)<\/td><td>(.+)<\/td><td>(.+)<\/td><\/tr>/g;
        var match = regex.exec(arr[row]);
        data.push([match[1], match[2], match[3]]);
    }

    console.log(arr[0]);
    console.log(arr[1]);
    for (var i in data) {
        data.sort(function(a, b) { return a[1] - b[1] || a[0] > b[0]} );

        console.log('<tr><td>' + data[i][0] + '</td><td>' + data[i][1] + '</td><td>' + data[i][2] + '</td></tr>');
    }
    console.log(arr[arr.length - 1]);
}

var arr = [ '<table>',
    '<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
    '<tr><td>Vodka Finlandia 1 l</td><td>11.99</td><td>+12</td></tr>',
    '<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
    '<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
    '<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
    '<tr><td>Cofee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
    '</table>' ];
solve(arr)