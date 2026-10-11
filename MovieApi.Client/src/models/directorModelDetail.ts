
export default interface DirectorModelDetail{
    directorID:number;
    directorFullName:string;
    directorBornDate:string;
    directorImage:string;
    directorBiography:string;
    movies:Array<string>[] 
}