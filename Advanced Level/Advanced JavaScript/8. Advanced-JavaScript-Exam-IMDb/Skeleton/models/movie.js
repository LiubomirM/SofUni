var imdb = imdb || {};

(function(scope){
    var id = 1;
    function Movie(title, lenght, rating, country){
        this._id = id++;
        this.title = title;
        this.length = lenght;
        this.rating = rating;
        this.country = country;
        this._actors = [];
        this._reviews = [];
    }

    Movie.prototype.addActor = function(actor){
        this._actors.push(actor);
    };

    Movie.prototype.getActors = function(){
        return this._actors;
    };

    Movie.prototype.addReview = function(review){
        this._reviews.push(review);
    };

    Movie.prototype.deleteReviw = function(review){
        this._reviews = this._reviews.filter(function(currentReview){
            return currentReview !== review;
        })
    };

    Movie.prototype.deleteReviwById = function(id){
        this._reviews = this._reviews.filter(function(review) {
            return review._id !== id;
        })
    };

    Movie.prototype.getReviews = function(){
        return this._reviews;
    };

    scope._Movie = Movie;

    scope.getMovie = function(title, lenght, rating, country) {
        return new Movie(title, lenght, rating, country);
    }
})(imdb);