import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Zakaznici(){
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/zakaznik", {mode:'cors'})
    .then((response) => response.json()) // Convert response to JSON
    .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatZakaznika(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/zakaznik/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/zakaznik-form'}>Přidat nového zákazníka</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Phone</th>
                    <th>Email</th>
                    <th>Address ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((customer) => (
                    <tr key={customer.idZakaznik}>
                    <td>{customer.idZakaznik}</td>
                    <td>{customer.jmeno}</td>
                    <td>{customer.telefon}</td>
                    <td>{customer.email}</td>
                    <td>{customer.idAdresa}</td>
                    <td><button onClick={(e)=>window.location.href=(`/zakaznik-form?id=${customer.idZakaznik}`)}>Upravit</button><button onClick={(e)=>smazatZakaznika(e, customer.idZakaznik)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Zakaznici;