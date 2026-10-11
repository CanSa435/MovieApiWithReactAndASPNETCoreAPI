import { useParams } from 'react-router-dom'
import Box from '@mui/material/Box';
import Grid from '@mui/material/Grid';
import { useEffect, useState } from 'react';
import axios from 'axios';
import type MovieModelDetail from '../models/movieDetail';


const MovieDetail = () => {
    const { id } = useParams();
    const [movie,setMovie] = useState<MovieModelDetail>();
    useEffect(() => {
        axios.get<MovieModelDetail>(`https://localhost:44333/api/Movies/${id}`).then((response) => {
            setMovie(response.data);
            console.log(response.data)
        }).catch((err:any) =>{
            console.log(err.message);
        })
    },[])
    return (
        <div className='container mx-auto mt-32'>
            <Box sx={{flexGrow:1}}>
                <Grid container spacing={2}>
                    <Grid size={{xs:12,md:8}}>
                        <Box
                        component="img"
                        sx={{
                            height:600,
                            width:650,
                            maxHeight:{xs:233,md:600},
                            maxWidth:{xs:350,md:660},
                            borderRadius:2,
                            boxShadow:3
                        }}
                        alt={movie?.originalTitle}
                        src={movie?.posterImageUrl}
                        />
                    </Grid>
                    <Grid size={{xs:12,md:4}}>
                        <div className='flex flex-col items-center gap-2.5'>
                            <div className='bg-transparent mr-24'>
                                <span className='text-black text-[20px]'>
                                    {movie?.movieTitle}
                                </span>
                                <h1 className='text-zinc-500 text-[15px] font-serif mt-2.5'>
                                    {movie?.originalTitle}
                                </h1>
                            </div>
                            <div className='bg-transparent mr-32'>
                                <div className='mt-1.5 pb-2.5'>
                                    <p className='text-zinc-500'>
                                        Yönetmen : <strong>{movie?.directorFullName}</strong>
                                    </p>
                                </div>
                                <div className='mt-2.5'>
                                  <Box sx={{fontSize:'15px', textTransform:'uppercase',color:'GrayText'}} component="h4">
                                    Oyuncular
                                  </Box>  
                                  <Box component="ul" sx={{ display:'flex',flexDirection:'column',gap:'10px' ,listStyle:'none'}}>
                                    {
                                        movie?.actors.map((item:any,index:any) => (
                                          <li key={index} className='mt-2.5'>
                                             {item}
                                          </li>   
                                        ))
                                    }
                                  </Box>
                                </div>
                                <div className='mt-2.5'>
                                  <Box sx={{fontSize:'15px', textTransform:'uppercase',color:'GrayText'}} component="h4">
                                    Filmin Kategorileri
                                  </Box>  
                                  <Box component="ul" sx={{ display:'flex',flexDirection:'column',gap:'10px' ,listStyle:'none'}}>
                                    {
                                        movie?.categories.map((item:any,index:any) => (
                                          <li key={index} className='mt-2.5'>
                                             {item}
                                          </li>   
                                        ))
                                    }
                                  </Box>
                                </div>
                            </div>
                        </div>
                    </Grid>
                </Grid>
            </Box> 
        </div>
       
    )
}

export default MovieDetail