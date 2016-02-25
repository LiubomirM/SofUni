var app = app || {};

(function(eventsSystem){
    function Course(name, numberOfLectures) {
        this._name = name;
        this._numberOfLectures = numberOfLectures;
    }

    eventsSystem.course = function(name, numberOfLectures) {
        return Course(name, numberOfLectures);
    }
})(app);