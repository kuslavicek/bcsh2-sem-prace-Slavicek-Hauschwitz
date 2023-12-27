import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Objednavky(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/objednavka",{mode:'cors'})
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

   function smazatObjednavku(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/objednavka/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/objednavka-form'}>Přidat novou objednávku</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Creation date</th>
		    <th>Price</th>
                    <th>Address ID</th>
                    <th>Customer ID</th>
                    <th>Employee ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((order) => (
                    <tr key={order.idObjednavka}>
                    <td>{order.idObjednavka}</td>
                    <td>{order.datumZalozeni}</td>
                    <td>{order.cena}</td>
                    <td>{order.idAdresa}</td>
                    <td>{order.idZakaznik}</td>
                    <td>{order.idZamestnanec}</td>
                    <td><button onClick={(e)=>window.location.href=(`/objednavka-form?id=${order.idObjednavka}`)}>Upravit</button><button onClick={(e)=>smazatObjednavku(e, order.idObjednavky)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Objednavky;