var app = app || {};

(function(eventsSystem){
    if (this.constructor === Event) {
        throw new Error("Can't instantiate abstract class!");
    }
    function Event(options) {
        this._title = options.title;
        this._type = options.type;
        this._duration = options.duration;
        this._time = options.time;
    }

    eventsSystem._Event = Event;

    return this;
})(app);