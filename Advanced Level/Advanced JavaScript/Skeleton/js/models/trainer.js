var app = app || {};

(function(eventsSystem) {
    function Trainer(name, workHours, courses, feedbacks) {
        eventsSystem._Employee.call(this, name, workHours);
        this.courses = [];
        this.feedbacks = [];
    }

    Trainer.extend(eventsSystem._Employee);

    Trainer.prototype.addFeedback = function(feedback) {
        this.feedbacks.push(feedback);
    }

    Trainer.prototype.addCourse = function(course) {
        this.courses.push(course);
    }

    eventsSystem.trainer = function(name, workHours, courses, feedbacks) {
        return Trainer(name, workHours, courses, feedbacks);
    }
})(app);