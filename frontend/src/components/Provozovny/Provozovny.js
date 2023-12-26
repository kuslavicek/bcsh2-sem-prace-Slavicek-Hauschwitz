import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Provozovny(){
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/provozovna", {mode:'cors'})
    .then((response) => response.json()) // Convert response to JSON
    .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatProvozovnu(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/provozovna/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/provozovna-form'}>Přidat novou Provozovnu</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Počet zaměstnanců</th>
                    <th>Address ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((provozovna) => (
                    <tr key={provozovna.idProvozovna}>
                    <td>{provozovna.idProvozovna}</td>
                    <td>{provozovna.nazev}</td>
                    <td>{provozovna.pocetZamestnancu}</td>
                    <td>{provozovna.idAdresa}</td>
                    <td><button onClick={(e)=>window.location.href=(`/provozovna-form?id=${provozovna.idProvozovna}`)}>Upravit</button><button onClick={(e)=>smazatProvozovnu(e, provozovna.idProvozovna)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Provozovny;