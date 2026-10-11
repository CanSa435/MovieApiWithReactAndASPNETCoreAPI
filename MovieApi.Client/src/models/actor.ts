import type Movies from "./movie";

export default interface Actor {
    actorId : number;
    actorFullName:string;
    bornDate:string;
    actorImage:string;
    actorBiography:string;
    movieId:number;
    movie:Movies
}