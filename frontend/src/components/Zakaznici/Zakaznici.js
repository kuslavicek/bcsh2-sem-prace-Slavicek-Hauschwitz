import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Zakaznici(){
    
    const [data, setData] = useState([]);
    setData(fetch("https://localhost:7043/api/zakaznik",{mode:'cors'}));
    console.log(data);
  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/zakaznik",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatZakaznika(id){
    fetch("https://localhost:7043/api/zakaznik/"+toString(id), { mode: 'cors', method: 'DELETE' });
  };
    return(
        <div>
            <button onclick={(e)=> redirect("/zakaznik-form")}>Přidat nového zákazníka</button>
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
                    <td><button onclick={(e)=> redirect("/zakaznik-form/:"+toString(customer.idZakaznik))}>Upravit</button><button onclick={(e)=> smazatZakaznika(customer.idZakaznik)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Zakaznici;