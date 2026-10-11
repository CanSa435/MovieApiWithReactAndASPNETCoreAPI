import type Actor from "./actor";
import type Category from "./category";
import type Director from "./director";

export default interface Movies {
    movieId:number;
    movieTitle:string;
    originalTitle:string;
    releaseYear:number;
    posterImageUrl:string;
    releaseDate:string;
    movieSecond:string;
    movieReview:string;
    directorId:number;
    director:Director;
    categories:Category[];
    actors:Actor[];
}