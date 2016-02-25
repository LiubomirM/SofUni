var app = app || {};

(function(eventsSystem){
    function Hall(name, capacity, parties, lectures) {
        this._name = name;
        this._capacity = capacity;
        this.patries = [];
        this.lectures = [];
    }

    Hall.prototype.addEvent = function(addEv) {
        this.patries.push(addEv);
    }

    eventsSystem.hall = function(name, capacity, parties, lectures) {
        return Hall(name, capacity, parties, lectures);
    }
})(app);