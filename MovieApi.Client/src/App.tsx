 import { BrowserRouter, Route, Routes } from 'react-router-dom'
import './App.css'
import MovieList from './components/MovieList'
import Navbar from './components/Navbar'
import MovieDetail from './components/MovieDetail'
import ActorsList from './components/ActorsList'
import ActorDetail from './components/ActorDetail'
import DirectorList from './components/DirectorList'
import DirectorDetail from './components/DirectorDetail'

function App() {
 
  return (
    <BrowserRouter>
      <Navbar/>
      <Routes>
        <Route path='/' element={<MovieList/>} />
        <Route path='/movies' element={<MovieList/> }/>
        <Route path='/movies/:id' element={<MovieDetail/>} />
        <Route path='/actors' element={<ActorsList/>}/>
        <Route path='/actors/:id' element={<ActorDetail/>}/>
        <Route path='/directors' element={<DirectorList/>}/>
        <Route path='/directors/:id' element={<DirectorDetail/>}/>
      </Routes>
    </BrowserRouter>
  )
}

export default App
