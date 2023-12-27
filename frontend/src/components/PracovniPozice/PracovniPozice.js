import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function PracovniPozice(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/pracpozice",{mode:'cors'})
      .then((response) => response.json()) // Convert response to JSON
      .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatPracovniPozici(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/pracpozice/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/pracpozice-form'}>Přidat novou pracovní pozici</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
		    <th>Sallary</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((job) => (
                    <tr key={job.idPracovniPozice}>
                    <td>{job.idPracovniPozice}</td>
                    <td>{job.nazev}</td>
                    <td>{job.plat}</td>
                    <td><button onClick={(e)=>window.location.href=(`/pracpozice-form?id=${job.idPracovniPozice}`)}>Upravit</button><button onClick={(e)=>smazatPracovniPozici(e, job.idPracovniPozice)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default PracovniPozice;