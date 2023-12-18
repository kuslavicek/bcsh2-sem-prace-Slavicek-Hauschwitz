import React, { useState, useEffect } from 'react';

function Akce(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/akce",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  
    return(
        <div>
            <button>Přidat novou akci</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
		    <th>Number of persons</th>
                    <th>Date</th>
                    <th>Type ID</th>
                    <th>Order ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((event) => (
                    <tr key={event.idAkce}>
                    <td>{event.idAkce}</td>
                    <td>{event.pocetOsob}</td>
                    <td>{event.datum}</td>
                    <td>{event.idTypAkce}</td>
                    <td>{event.idObjednavka}</td>
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Akce;