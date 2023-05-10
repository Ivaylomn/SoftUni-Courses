function movies(arr) {
    let allMovies = [];
    for (const el of arr) {
        if (el.includes('addMovie')) {
            let obj = {};
            obj.name = el.substring(9);
            allMovies.push(obj);
        } else if (el.includes('directedBy')){
            let [movieName, directorName] = el.split(' directedBy ');
            allMovies.find(x => {
                if (x.name === movieName) {
                    x.director = directorName; 
                }
            })
        } else {
            let [movieName, date] = el.split(' onDate ');
            let currentMovie =  allMovies.find(x => x.name === movieName);
            if(currentMovie){
                currentMovie.date = date;
            }
        }
    }
    allMovies.forEach(movie => {
        if(movie.name && movie.date && movie.director){
            console.log(JSON.stringify(movie));
        }
    })
}

movies([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
]);