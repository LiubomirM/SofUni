function solve(arr) {

    var area = [];
    for (var i = 0; i < arr.length; i++) {
        area.push(arr[i]);
    }

    var symJ = 0;
    var symI = 0;
    var symL = 0;
    var symS = 0;
    var symO = 0;
    var symZ = 0;
    var symT = 0;
    var width = area[0].length;
    var height = area.length;
    for (var row = 0; row <= area.length; row++) {

        for (var col = 0; col <= width; col++) {
            if (col+1 < width && row+2 < height &&
                area[row][col+1] === 'o' && area[row+1][col+1] === 'o' && area[row+2][col+1] === 'o' && area[row+2][col] === 'o') {
                symJ++;
            }
            if (col+1 < width && row+1 < height &&
                area[row][col] === 'o' && area[row][col+1] === 'o' && area[row+1][col] === 'o' && area[row+1][col+1] === 'o') {
                symO++;
            }
            if (col+1 < width && row+2 < height &&
                area[row][col] === 'o' && area[row+1][col] === 'o' && area[row+2][col] === 'o' && area[row+2][col+1] === 'o') {
                symL++;
            }
            if (col < width && row+3 < height &&
                area[row][col] === 'o' && area[row+1][col] === 'o' && area[row+2][col] === 'o' && area[row+3][col] === 'o') {
                symI++;
            }
            if (col+2 < width && row+1 < height &&
                area[row][col] === 'o' && area[row][col+1] === 'o' && area[row+1][col+1] === 'o' && area[row+1][col+2] === 'o') {
                symZ++;
            }
            if (col+2 < width && row+1 < height &&
                area[row][col+1] === 'o' && area[row][col+2] === 'o' && area[row+1][col+1] === 'o' && area[row+1][col] === 'o') {
                symS++;
            }
            if (col+2 < width && row+1 < height &&
                area[row][col] === 'o' && area[row][col+1] === 'o' && area[row][col+2] === 'o' && area[row+1][col+1] === 'o') {
                symT++;
            }
        }
    }

    console.log('{"I":' + symI + ',"L":' + symL + ',"J":' + symJ + ',"O":' + symO + ',"Z":' + symZ + ',"S":' + symS +',"T":' + symT + '}');
}

var arr = [ '--o--o-', '--oo-oo', 'ooo-oo-', '-ooooo-', '---oo--' ];

solve(arr);