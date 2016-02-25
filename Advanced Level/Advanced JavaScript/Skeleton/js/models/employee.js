var app = app || {};

(function(eventsSystem){
    function Employee(name, workHours) {
        this._name = name;
        this._workHours = workHours;
    }

    eventsSystem._Employee = Employee;
    eventsSystem.employee = function(name, workHours) {
        return Employee(name, workHours);
    }
})(app);