var imdb = imdb || {};

(function(scope){
    var id = 1;
    function Theatre(name, lenght, rating, country, isPuppet) {
        this._id = id++;
        scope._Movie.call(this, name, lenght, rating, country)
        this.isPuppet = isPuppet || false;
    }

    Theatre.extend(scope._Movie);
    scope.getTheatre = function(name, lenght, rating, country, isPuppet) {
        return new Theatre(name, lenght, rating,country, isPuppet);
    }
})(imdb);