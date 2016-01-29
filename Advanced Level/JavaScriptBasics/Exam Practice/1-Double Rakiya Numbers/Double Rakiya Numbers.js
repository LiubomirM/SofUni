function solve(arr) {
    var start = arr[0];
    var end = arr[1];

    console.log('<ul>');
    for(var i = start; i <= end; i++) {
        var numToString = i.toString();
        if(numToString.length > 3) {
            var noRakiya = true;
            var twoDigitNums = [];
            for (var j = 0; j < numToString.length - 1; j++) {
                var num = numToString[j] + numToString[j + 1];
                twoDigitNums.push(num);
            }

            for (var k = 0; k < twoDigitNums.length - 1; k++) {
                var isRakiyq = false;
                for (var m = k + 1; m < twoDigitNums.length; m++) {
                    if (twoDigitNums[k] === twoDigitNums[m] && k + 1 != m) {
                        console.log("<li><span class='rakiya'>" + i + "</span><a href=\"view.php?id=" + i + ">View</a></li>");
                        isRakiyq = true;

                        break;
                    }
                }
                if (isRakiyq) {
                    break;
                }
            }
            if(!isRakiyq) {
                console.log("<li><span class='num'>" + i + "</span></li>")
            }
        }else {
            console.log("<li><span class='num'>" + i + "</span></li>");
        }
    }
    console.log('</ul>')
}

solve([999999910,
    1000000000]);