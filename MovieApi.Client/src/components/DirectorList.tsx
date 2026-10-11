 import { useEffect, useState } from "react"
import type Director from "../models/director"
import axios from "axios";
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import { Link } from "react-router-dom";
const DirectorList = () => {
     const [directors,setDirectors] = useState<Director[]>([]);
    useEffect(() => {
        axios.get<Director[]>("https://localhost:44333/api/Directors")
        .then((response) => {
            setDirectors(response.data)
            console.log(response.data)
        })
        .catch((err:any) => {
            console.error("Hata : " + err.message)
        })
    })
    return (
        <>
                 <section className="pt-32">
        <div className="container mx-auto">
            <div className="grid grid-cols-1 md:grid-cols-2 gap-5 place-items-center">
                {
                    directors.map((director:Director) => (
                        <Card sx={{ maxWidth: 645 }}>
                            <CardMedia
                            sx={{ height: 245,width:245 }}
                            image={director.directorImage}
                            title={director.directorFullName}
                            />
                            <CardContent>
                                <Typography gutterBottom variant="h5" component="div">
                                   {director.directorFullName}
                                </Typography>
                                <Typography variant="body2" sx={{ color: 'text.secondary' }}>
                                    {director.directorBornDate}
                                </Typography>
                            </CardContent>
                            <CardActions>
                                <Link to={`/directors/${director.directorID}`}>
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

export default DirectorList