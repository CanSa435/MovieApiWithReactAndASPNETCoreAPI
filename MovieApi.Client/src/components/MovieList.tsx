import { useEffect, useState } from "react"
import type Movies from "../models/movie"
import axios from "axios";
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { Link } from "react-router-dom";

const MovieList = () => {

    const [movies,setMovies] = useState<Movies[]>([]);
    useEffect(() => {
        axios.get<Movies[]>("https://localhost:44333/api/Movies")
        .then((response) => {
            setMovies(response.data);
            console.log(response.data)
        })
        .catch((err) => console.error(err.message))
    },[movies])

  return (
   <> 
   <section className="h-screen bg-[url('/src/assets/backgroundImage.jpg')] -mt-18.75 pb-17.5">
        <div className="container mx-auto h-screen">
            <div className="flex flex-col gap-4 items-center justify-center">
                <div className="flex-1 m-5 p-52.5 text-start mr-152.5">
                    <span className="text-white text-4xl">MovieApi</span>
                    <p className="text-white text-2xl">
                        MovieApi üzerinden güncel sinema dünyasına dair pek çok bilgiye tek bir yerden ulaşabilirsiniz.
                    </p>
                </div>
            </div>
        </div>
    </section>
    <section className="pt-32">
        <div className="container mx-auto">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-5 place-items-center">
                {
                    movies.map((movie:Movies) => (
                        <Card sx={{ maxWidth: 645 }}>
                            <CardMedia
                            sx={{ height: 545,width:545 }}
                            image={movie.posterImageUrl}
                            title={movie.movieTitle}
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                {movie.originalTitle}
                                </Typography>
                                <Typography variant="body2" sx={{ color: 'text.secondary' }}>
                                    {movie.releaseDate}
                                </Typography>
                            </CardContent>
                            <CardActions>
                                <Link to={`/movies/${movie.movieId}`}>
                                    <Button size="small">
                                    Detaylar
                                    </Button>
                                </Link>
                                 
                            </CardActions>
                        </Card>
                    ))
                }
            </div>
        </div>
    </section>
    </>
  )
}

export default MovieList