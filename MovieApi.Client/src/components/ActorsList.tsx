import { useEffect, useState } from "react"
import type Actor from "../models/actor"
import axios from "axios";
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { Link } from "react-router-dom";
const ActorsList = () => {
    const [actors,setActors] = useState<Actor[]>([]);
    useEffect(() => {
        axios.get<Actor[]>("https://localhost:44333/api/Actors")
        .then((res:any) => {
            setActors(res.data);
            console.log(res.data)
        })
        .catch((err:any) => console.error("Hata : " + err.message))
    })
    return (
       <>
        <section className="pt-32">
        <div className="container mx-auto">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-5 place-items-center">
                {
                    actors.map((actor:Actor) => (
                        <Card sx={{ maxWidth: 645 }}>
                            <CardMedia
                            sx={{ height: 245,width:245 }}
                            image={actor.actorImage}
                            title={actor.actorFullName}
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                   {actor.actorFullName}
                                </Typography>
                                <Typography variant="body2" sx={{ color: 'text.secondary' }}>
                                    {actor.bornDate}
                                </Typography>
                            </CardContent>
                            <CardActions>
                                <Link to={`/actors/${actor.actorId}`}>
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

export default ActorsList