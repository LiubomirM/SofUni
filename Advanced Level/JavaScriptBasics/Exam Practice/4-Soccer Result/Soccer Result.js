function solve(arr) {
    var output = [];

    for (var line in arr){
        var matchInfo = arr[line].replace(/\s+/g, ' ').trim().split('/');
        var homeTeam = matchInfo[0].trim();
        var info = matchInfo[1].trim().split(':');
        var awayTeam = info[0].trim();
        var result = info[1].trim().split('-');
        var homeResult = Number(result[0]);
        var awayResult = Number(result[1]);

        if (output.length === 0){
            output.push(resultInfo(homeTeam));
        }

        for (var i in output) {
            var isHomeIn = false;
            if (output[i].name == homeTeam) {
                isHomeIn = true;
                break;
            }

        }
        for (var i in output) {
            var isAwayIn = false;
            var currentAway = i;
            if (output[i].name == awayTeam) {
                isAwayIn = true;
                break;
            }
        }

        if (!isHomeIn) {
            output.push(resultInfo(homeTeam));
        }
        if (!isAwayIn) {
            output.push(resultInfo(awayTeam));
        }

        for (var i in output) {
            if (output[i].name === homeTeam) {
                output[i].goalsScored += homeResult;
                output[i].goalsConceded += awayResult;
                output[i].matchesPlayedWith.push(awayTeam);
                output[i].matchesPlayedWith.sort();
            }
            if (output[i].name === awayTeam) {
                output[i].goalsScored += awayResult;
                output[i].goalsConceded += homeResult;
                output[i].matchesPlayedWith.push(homeTeam);
                output[i].matchesPlayedWith.sort();
            }

            output[i].matchesPlayedWith = output[i].matchesPlayedWith.filter(function(item, pos) {
                return output[i].matchesPlayedWith.indexOf(item) == pos;
            })
        }
    }

    function resultInfo(name) {
        return {
            name:name,
            goalsScored: 0,
            goalsConceded: 0,
            matchesPlayedWith: []
        }
    }

    output = output.sort(function(a, b){return a.name > b.name});

    var jsonOut = '';
    for (var i in output) {
        jsonOut += '"' + output[i].name +'":{"goalsScored":' + output[i].goalsScored + ',"goalsConceded":' + output[i].goalsConceded
        + ',"matchesPlayedWith":' + JSON.stringify(output[i].matchesPlayedWith) + '},';
    }
    jsonOut = jsonOut.substring(0, jsonOut.length-1);

    console.log('{' + jsonOut + '}');
}

var arr = [ 'Levski / CSKA: 0-2',
            'Pavlikeni / Loko Gorna: 4-2',
            'Loko Gorna / Levski: 1-4',
            'Litex / Loko Gorna: 0-0',
            'Beroe / Botev Plovdiv: 2-1',
            'Loko Gorna / Beroe: 3-1',
            'CSKA / Marek: 3-2',
            'Pavlikeni / Ludogorets: 0-2',
            'Loko Sofia / Litex: 0-2',
            'Pavlikeni / Marek: 1-1',
            'Litex / Levski: 0-0',
            'Beroe / Litex: 3-2',
            'Litex / Beroe: 1-0',
            'Ludogorets / Litex: 3-0',
            'Litex / Ludogorets: 1-0',
            'CSKA / Beroe: 1-0',
            'Botev Plovdiv / CSKA: 1-1',
            'Ludogorets / Loko Sofia: 1-0',
            'Litex / CSKA: 0-1',
            'Marek / Haskovo: 0-1',
            'Levski / Loko Gorna: 1-1',
            'Pavlikeni / Ludogorets: 0-2',
            'Loko Sofia / Litex: 0-2',
            'Pavlikeni / Marek: 1-1',
            'Litex / Levski: 0-0',
            'Beroe / Litex: 3-2',
            'Litex / Beroe: 1-0',
            'Ludogorets / Litex: 3-0' ];

solve(arr);