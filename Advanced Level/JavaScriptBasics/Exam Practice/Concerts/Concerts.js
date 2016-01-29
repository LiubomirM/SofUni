function solve(arr) {
    var input = {};

    for(var element in arr) {

        var line = arr[element].split('|');
        var band = line[0].trim();
        var town = line[1].trim();
        var date = line[2].trim();
        var venue = line[3].trim();

        if(!input[town]){
            input[town] = {};
        }
        if(!input[town][venue]) {
            input[town][venue] = [];
        }
        if(input[town][venue].indexOf(band) === -1) {
            input[town][venue].push(band);
        }
    }

    function orderBy(a, b) {
        return a < b;
    }

    var array = [];

    for(var town in input) {
        input[town] = sortObjectProperties(input[town]);
        for(var venue in input[town]){
            input[town][venue] = input[town][venue].sort();
        }
    }

    function sortObjectProperties(obj) {
        var keysSorted = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < keysSorted.length; i++) {
            var key = keysSorted[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }

    input = sortObjectProperties(input);

    console.log(JSON.stringify(input));

}

solve(['ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
])