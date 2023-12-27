import logo from './logo.svg';
import './App.css';
import {BrowserRouter, Routes, Route, Navigate} from 'react-router-dom';
import Navbar from './components/Navbar.js';
import Zakaznici from './components/Zakaznici/Zakaznici.js'
import ZakaznikForm from './components/Zakaznici/ZakaznikForm.js'
import Zamestnanci from './components/Zamestnanci/Zamestnanci.js'
import ZamestnanecForm from './components/Zamestnanci/ZamestnanecForm.js'
import Adresy from './components/Adresy/Adresy.js'
import AdresaForm from './components/Adresy/AdresaForm.js'
import Akce from './components/Akce/Akce.js'
import Pivovar from './components/Pivovar/Pivovar.js'
import PracovniPozice from './components/PracovniPozice/PracovniPozice.js'
import Objednavky from './components/Objednavky/Objednavky.js'
import Provozovny from './components/Provozovny/Provozovny.js'
import ProvozovnaForm from './components/Provozovny/ProvozovnaForm.js'
import UserForm from './components/UserForm.js';
import Main from './components/Main.js'



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
            <Route path="zamestnanec-form" element={<ZamestnanecForm/>}></Route>
            <Route path="adresy" element={<Adresy/>}></Route>
            <Route path="adresa-form" element={<AdresaForm/>}></Route>
            <Route path="akce" element={<Akce/>}></Route>
            <Route path="pivovar" element={<Pivovar/>}></Route>
            <Route path="pracovni_pozice" element={<PracovniPozice/>}></Route>
            <Route path="objednavka" element={<Objednavky/>}></Route>
            <Route path="provozovna" element={<Provozovny/>}></Route>
            <Route path="provozovna-form" element={<ProvozovnaForm/>}></Route>
            <Route path="/" element={<Main/>}></Route>
            <Route></Route>
          </Routes>
        
        </BrowserRouter>
      </div>
    );
  }else{
    return(
    <div className="App">
        <Navbar/>
        <BrowserRouter>
          <Routes>
            <Route path="user-form" element={<UserForm/>}></Route>
            <Route path="/" element={<Main/>}></Route>
            
          </Routes>
        
        </BrowserRouter>
    </div>
    )
  }
  
}

export default App;
