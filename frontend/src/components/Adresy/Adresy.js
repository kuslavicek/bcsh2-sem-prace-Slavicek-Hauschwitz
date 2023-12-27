import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Adresy(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/Adresa",{mode:'cors'})
      .then((response) => response.json()) // Convert response to JSON
      .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatAdresu(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/adresa/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/adresa-form'}>Přidat novou adresu</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Street</th>
		    <th>City</th>
                    <th>PSC</th>
                    <th>number of descriptive</th>
                    <th>Country</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((adress) => (
                    <tr key={adress.idAdresa}>
                    <td>{adress.idAdresa}</td>
                    <td>{adress.ulice}</td>
                    <td>{adress.mesto}</td>
                    <td>{adress.psc}</td>
                    <td>{adress.cisloPopisne}</td>
                    <td>{adress.stat}</td>
                    <td><button onClick={(e)=>window.location.href=(`/adresa-form?id=${adress.idAdresa}`)}>Upravit</button><button onClick={(e)=>smazatAdresu(e, adress.idAdresa)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Adresy;