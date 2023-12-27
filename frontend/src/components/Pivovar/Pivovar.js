import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Pivovar(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/pivovar",{mode:'cors'})
      .then((response) => response.json()) // Convert response to JSON
      .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatPivovar(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/pivovar/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/pivovar-form'}>Přidat nový pivovar</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
		    <th>Category</th>
                    <th>Address ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((pivovar) => (
                    <tr key={pivovar.idPivovar}>
                    <td>{pivovar.idPivovar}</td>
                    <td>{pivovar.nazev}</td>
                    <td>{pivovar.kategorie}</td>
                    <td>{pivovar.idAdresa}</td>
                    <td><button onClick={(e)=>window.location.href=(`/pivovar-form?id=${pivovar.idPivovar}`)}>Upravit</button><button onClick={(e)=>smazatPivovar(e, pivovar.idPivovar)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Pivovar;