import logo from './logo.svg';
import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import Navbar from './components/Navbar.js';
import Zakaznici from './components/Zakaznici/Zakaznici.js'
import Zamestnanci from './components/Zamestnanci/Zamestnanci.js'
import Adresy from './components/Adresy/Adresy.js'
import Akce from './components/Akce/Akce.js'
import Pivovar from './components/Pivovar/Pivovar.js'

function App() {
  return (
    <div className="App">
      <Navbar/>
      <BrowserRouter>
        <Routes>
          <Route></Route>
          <Route path="zakaznici" element={<Zakaznici/>}></Route>
          <Route path="zamestnanci" element={<Zamestnanci/>}></Route>
          <Route path="adresy" element={<Adresy/>}></Route>
          <Route path="akce" element={<Akce/>}></Route>
          <Route path="pivovar" element={<Pivovar/>}></Route>
          <Route></Route>
        </Routes>
      
      </BrowserRouter>
    </div>
  );
}

export default App;
