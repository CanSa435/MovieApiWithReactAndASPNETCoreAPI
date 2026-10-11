import type Movies from "./movie";

export default interface Category {
    categoryId:number;
    categoryName:string;
    movieId:number;
    movie:Movies
}