import './App.css';
import Home from './Components/Home'
import Busqueda from './Components/Busqueda'
import { BrowserRouter, Routes, Route } from "react-router-dom"


function App() {
  return (
    <BrowserRouter>
      <div className="container">
         <Routes>
            <Route path="/" element={<Home/>}/>
            <Route path="/Busqueda" element={<Busqueda/>}/>
          </Routes>
      </div>
    </BrowserRouter>

  );
}

export default App;
