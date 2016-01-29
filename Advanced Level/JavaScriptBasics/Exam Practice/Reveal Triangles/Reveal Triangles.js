function solve(arr) {

    var output = [];
    for (var row = 0; row < arr.length; row++) {
        output[row] = arr[row].split('');
    }

    for (var row = 1; row < arr.length; row++) {
        var maxCol = Math.min(
            arr[row - 1].length - 2,
            arr[row].length - 3);
        for (var col = 0; col <= maxCol; col++) {
            var a = arr[row][col];
            var b = arr[row][col + 1];
            var c = arr[row][col + 2];
            var d = arr[row - 1][col + 1];
            if (a == b && b == c && c == d) {
                output[row][col] = '*';
                output[row][col + 1] = '*';
                output[row][col + 2] = '*';
                output[row - 1][col + 1] = '*';
            }
        }
    }

    for (var row = 0; row < arr.length; row++) {
        console.log(output[row].join(''));
    }
}

solve(['abcdexgh',
       'bbbdxxxh',
       'abcxxxxx'
      ]);