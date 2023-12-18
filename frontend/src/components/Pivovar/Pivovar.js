import React, { useState, useEffect } from 'react';

function Pivovar(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/pivovar",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  
    return(
        <div>
            <button>Přidat nový pivovar</button>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
		    <th>Category</th>
                    <th>Address ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((pivovar) => (
                    <tr key={pivovar.idPivovar}>
                    <td>{pivovar.idPivovar}</td>
                    <td>{pivovar.nazev}</td>
                    <td>{pivovar.kategorie}</td>
                    <td>{pivovar.idAdresa}</td>
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Pivovar;