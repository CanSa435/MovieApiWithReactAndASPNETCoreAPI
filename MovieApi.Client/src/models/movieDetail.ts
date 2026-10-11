

export default interface MovieModelDetail {
    movieId:number;
    movieTitle:string;
    originalTitle:string;
    releaseYear:number;
    posterImageUrl:string;
    releaseDate:string;
    movieSecond:string;
    movieReview:string;
    directorId:number;
    directorFullName:string;
    categories:Array<string>;
    actors:Array<string>;
}