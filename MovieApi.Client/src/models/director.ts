import type Movies from "./movie";

export default interface Director{
    directorID:number;
    directorFullName:string;
    directorBornDate:string;
    directorImage:string;
    directorBiography:string;
    movies:Movies[] 
}