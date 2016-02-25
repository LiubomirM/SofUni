var app = app || {};

(function(eventsSystem){
    function Lecture(options, trainer, course){
        eventsSystem._Event.call(this, options);
        this._trainer = trainer;
        this._course = course;
    }

    Lecture.extend(eventsSystem._Event);

    eventsSystem.lecture = function(options, trainer, course) {
        return Lecture(options, trainer, course);
    }
})(app);