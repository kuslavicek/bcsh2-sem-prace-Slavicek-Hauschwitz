import React, { useState, useEffect } from 'react';

function PracovniPozice(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/pracovni_pozice",{mode:'cors'})
      .then((response) => response.json())
      .then((result) => setData(result))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  
    return(
        <div>
            <button>Přidat novou pracovní pozici</button>
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
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default PracovniPozice;