import logo from './logo.svg';
import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import Navbar from './components/Navbar.js';
import Zakaznici from './components/Zakaznici/Zakaznici.js'
import ZakaznikForm from './components/Zakaznici/ZakaznikForm.js'
import Zamestnanci from './components/Zamestnanci/Zamestnanci.js'
import Adresy from './components/Adresy/Adresy.js'
import Akce from './components/Akce/Akce.js'
import Pivovar from './components/Pivovar/Pivovar.js'
import PracovniPozice from './components/PracovniPozice/PracovniPozice.js'
import Objednavky from './components/Objednavky/Objednavky.js'

function App() {
  const savedUser = localStorage.getItem('user');
  if( savedUser!=null && savedUser != ''){
    return (
      <div className="App">
        <Navbar/>
        <BrowserRouter>
          <Routes>
            <Route path="zakaznik-form" element={<ZakaznikForm/>}></Route>
            <Route path="zakaznici" element={<Zakaznici/>}></Route>
            <Route path="zamestnanci" element={<Zamestnanci/>}></Route>
            <Route path="adresy" element={<Adresy/>}></Route>
            <Route path="akce" element={<Akce/>}></Route>
            <Route path="pivovar" element={<Pivovar/>}></Route>
            <Route path="pracovni_pozice" element={<PracovniPozice/>}></Route>
            <Route path="objednavka" element={<Objednavky/>}></Route>
            <Route></Route>
          </Routes>
        
        </BrowserRouter>
      </div>
    );
  }else{
    <div className="App">
        <Navbar/>
        <UserForm/>
    </div>
  }
  
}

export default App;
