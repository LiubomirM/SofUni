var app = app || {};

(function(eventsSystem){
    function Party(options, isCatered, isBirthday, organiser){
        eventsSystem._Event.call(this, options);
        this._isCatered = isCatered;
        this._isBirthday = isBirthday;
        this._organiser = organiser;
    }

    Party.extend(eventsSystem._Event);

    eventsSystem.party = function(options, isCatered, isBirthday, organiser) {
        return Party(options, isCatered, isBirthday, organiser);
    }
})(app);