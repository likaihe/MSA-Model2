var movieShow = (function () {
    function movieShow(name) {
        this.name = name;
        if (name == "SuicideSquad")
            this.src = "https://cdn.eventcinemas.co.nz/cdn/resources/movies/9620/images/skin.jpg";
        if (name == "BadMom")
            this.src = "https://cdn.eventcinemas.co.nz/cdn/resources/movies/9616/images/skin.jpg";
        if (name == "SausageParty")
            this.src = "https://cdn.eventcinemas.co.nz/cdn/resources/movies/9640/images/skin.jpg";
    }
    return movieShow;
}());
function display(Movie) {
    document.getElementById("movieimg").setAttribute("src", Movie.src);
}
function removedemo() {
    document.getElementById("demo").remove();
}
function Showimg(value) {
    var movie = new movieShow(value);
    display(movie);
    removedemo();
}
//# sourceMappingURL=test.js.map