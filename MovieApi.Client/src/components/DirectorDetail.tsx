import { useEffect, useState } from "react"
import type DirectorModelDetail from "../models/directorModelDetail"
import { useParams } from "react-router-dom";
import axios from "axios";
import Box from '@mui/material/Box';
import Grid from '@mui/material/Grid';
 
const DirectorDetail = () => {
    const { id } = useParams();
    const [director,setDirector] = useState<DirectorModelDetail>();
    useEffect(() => {
        axios.get<DirectorModelDetail>(`https://localhost:44333/api/Directors/${id}`)
        .then((response:any) => {
            setDirector(response.data);
            console.log(response.data);
        })
        .catch((err:any) => console.error("Hata : " + err.message))
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
                        alt={director?.directorFullName}
                        src={director?.directorImage}
                        />
                    </Grid>
                    <Grid size={{xs:12,md:4}}>
                        <div className='flex flex-col items-center gap-2.5'>
                            <div className='bg-transparent mr-24'>
                                <span className='text-black text-[20px]'>
                                    {director?.directorFullName}
                                </span>
                                <h1 className='text-zinc-500 text-[15px] font-serif mt-2.5'>
                                    {director?.directorBornDate}
                                </h1>
                            </div>
                            <div className='bg-transparent mr-32'>
                                <div className='mt-1.5 pb-2.5'>
                                    <p className='text-zinc-500'>
                                        {
                                            director?.directorBiography
                                        }
                                    </p>
                                </div>
                                <div className='mt-2.5'>
                                  <Box sx={{fontSize:'15px', textTransform:'uppercase',color:'GrayText'}} component="h4">
                                    Filmler
                                  </Box>  
                                  <Box component="div" sx={{ display:'flex',flexDirection:'column',gap:'10px'}}>
                                    {
                                        director?.movies.map((item:any,index:any) =>(
                                            <div key={index} className="w-3xs">
                                                <img src={item}/>
                                            </div>
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

export default DirectorDetail