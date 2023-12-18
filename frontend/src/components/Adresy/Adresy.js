import React, { useState, useEffect } from 'react';

function Adresy(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/Adresa",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  
    return(
        <div>
            <button>Přidat novou adresu</button>
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
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Adresy;