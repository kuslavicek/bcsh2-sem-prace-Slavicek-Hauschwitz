import logo from './logo.svg';
import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom';
import Navbar from './components/Navbar.js';
import Zakaznici from './components/Zakaznici/Zakaznici.js'

function App() {
  return (
    <div className="App">
      <Navbar/>
      <BrowserRouter>
        <Routes>
          <Route></Route>
          <Route path="zakaznici" element={<Zakaznici/>}></Route>
          <Route></Route>
          <Route></Route>
        </Routes>
      
      </BrowserRouter>
    </div>
  );
}

export default App;
