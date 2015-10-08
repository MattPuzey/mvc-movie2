var ViewModel = function () {
    var self = this;
    self.movies = ko.observableArray();
    self.error = ko.observable();

    var moviesUri = '/api/movies/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    function getAllMovies() {
        ajaxHelper(moviesUri, 'GET').done(function (data) {
            self.movies(data);
        });
    }

    // Fetch the initial data.
    getAllMovies();

    self.detail = ko.observable();

    self.getMovieDetail = function (item) {
        ajaxHelper(moviesUri + item.Id, 'GET').done(function (data) {
            self.detail(data);
        });
    }

    self.Movies = ko.observableArray();
    self.newMovie = {
        Title: ko.observable(),
        ReleaseDate: ko.observable(),
        Genre: ko.observable(),
        Price: ko.observable(),
        Rating: ko.observable()
    }

    self.addMovie = function (formElement) {
        var movie = {
            Title: self.newMovie.Title(),
            ReleaseDate: self.newMovie.ReleaseDate(),
            Genre: self.newMovie.Genre(),
            Price: self.newMovie.Price(),
            Rating: self.newMovie.Rating()
        };

        ajaxHelper(moviesUri, 'POST', movie).done(function (item) {
            self.movies.push(item);
        });
    }

};


ko.applyBindings(new ViewModel());