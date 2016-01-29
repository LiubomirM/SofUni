function solve(arr) {
    var rotate = Number(arr[0].match(/\d+/g));
    var matrix = [];
    var maxLenhgt = 0;

    for (var i = 1; i < arr.length; i++) {
        matrix[i - 1] = arr[i];

        if (maxLenhgt < arr[i].length) {
            maxLenhgt = arr[i].length;
        }
    }

    for (var element in matrix) {
        while (matrix[element].length < maxLenhgt) {
            matrix[element] = matrix[element].concat(' ');
        }
    }


    if (rotate >= 360) {
        rotate = rotate % 360;
    }

    var output = [];

    switch (rotate) {
        case 0:
                for (var element in matrix) {
                    output.push(matrix[element]);
                }
            break;
        case 90:
                for (var i = 0; i < maxLenhgt; i++) {
                    var row = '';
                    for (var j = matrix.length - 1; j >= 0; j--) {

                        row += matrix[j][i];
                    }
                    output.push(row);
                }
            break;
        case 180:
               for (var element in matrix) {
                   output.push(matrix[element].split('').reverse().join(''));
               }
               output = output.reverse();
            break;
        case 270:
               for (var i = maxLenhgt - 1; i >= 0; i--) {
                   var row = '';
                   for (var j = 0; j < matrix.length; j++) {

                       row += matrix[j][i];
                   }
                   output.push(row);
               }
            break;
    }
    for (var element in output) {
        console.log(output[element]);
    }

}

solve(['Rotate(180)',
       'hello',
       'softuni',
       'exam'
      ]);