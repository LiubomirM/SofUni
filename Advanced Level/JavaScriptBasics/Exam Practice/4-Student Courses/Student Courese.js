function solve(arr) {
    var ouput = {};

    for (var i in arr) {
        var line = arr[i].split('|');
        var student = line[0].replace(/\s+/g, ' ').trim();
        var course = line[1].replace(/\s+/g, ' ').trim();
        var grade = Number(line[2].replace(/\s+/g, ''));
        var visits = Number(line[3].replace(/\s+/g, ''));

        if(!ouput[course]) {
            ouput[course] = createObj();
        }

        for (var courseName in ouput) {
            if(courseName === course){
                ouput[courseName].avgGrade += grade;
                ouput[courseName].avgVisits += visits;
                ouput[courseName].countGraduates++;
                ouput[courseName].countVisits++;
                if (ouput[courseName].students.indexOf(student) === -1) {
                    ouput[courseName].students.push(student);
                }
            }
        }
    }

    for(var course in ouput) {
        ouput = sortObjectProperties(ouput);
        ouput[course].students = ouput[course].students.sort();
        var avgVis = ouput[course].avgVisits / ouput[course].countVisits;
        avgVis = avgVis.toFixed(2);
        var avgGr = ouput[course].avgGrade / ouput[course].countGraduates;
        avgGr = avgGr.toFixed(2);
        ouput[course].avgVisits = Number(avgVis);
        ouput[course].avgGrade = Number(avgGr);

        delete ouput[course].countVisits;
        delete ouput[course].countGraduates;
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

    console.log(JSON.stringify(ouput));

    function createObj() {
        return {
            avgGrade: 0,
            avgVisits: 0,
            countGraduates: 0,
            countVisits: 0,
            students: []
        }
    }
}

var arr =[ 'Milen Georgiev|PHP|2.02|2',
        'Ivan Petrov|C# Basics|3.20|22',
        'Peter Nikolov|C#|5.522|18',
        'Maria Kirova|C# Basics|2.20|4',
        'Stanislav Peev|C#|4.12|15',
        'Ivan Petrov|PHP|5.120|6',
        'Ivan Goranov|SQL|5.926|12',
        'Todor Kirov|PHP|5.50|0',
        'Maria Ivanova|Java|5.83|37',
        'Maria Ivanova|C#|1.823|4',
        'Stanislav Peev|C#|4.122|15',
        'Ivan Petrov|PHP|5.11|6',
        'Ivan Petrov|SQL|5.926|12',
        'Peter Nikolov|Java|5.9996|9',
        'Stefan Nikolov|Java|4.00|9' ];

solve(arr);
