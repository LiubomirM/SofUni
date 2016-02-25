
    function Person(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
        return {name: this.firstName + " " + this.lastName,
        firstName: this.firstName,
        lastName: this.lastName
        }
    }


var peter = new Person("Peter", "Jackson");
console.log(peter.name);
console.log(peter.firstName);
console.log(peter.lastName);