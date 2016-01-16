function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

function orderedBy(argument) {

    var x = {};
    var i = 0;

    while (i < people.length) {
        var key = 'Group ' + people[i][argument].toString();
        if (typeof(x[key]) === "undefined") {
            x[key] = [];
        }
        x[key].push(people[i].firstName + ' ' + people[i].lastName + '(age ' + people[i].age + ')');
        i++;
    }

    for (var a in x) {
        console.log(a + ': [' + x[a] + ']');
    }
}

orderedBy('firstName');