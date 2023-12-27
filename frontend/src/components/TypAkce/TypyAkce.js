import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function TypyAkce(){
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/typakce", {mode:'cors'})
    .then((response) => response.json()) // Convert response to JSON
    .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatTypAkce(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/typakce/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/typakce-form'}>Přidat nový typ akce</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((type) => (
                    <tr key={type.idTypAkce}>
                    <td>{type.idTypAkce}</td>
                    <td>{type.nazev}</td>
                    <td><button onClick={(e)=>window.location.href=(`/typakce-form?id=${type.idTypAkce}`)}>Upravit</button><button onClick={(e)=>smazatTypAkce(e, type.idTypAkce)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default TypyAkce;