import React, { useState, useEffect } from 'react';

function Objednavky(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/objednavka",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  
    return(
        <div>
            <button>Přidat nového zamestnance</button>
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
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Objednavky;