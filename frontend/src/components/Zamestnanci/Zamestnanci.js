import React, { useState, useEffect } from 'react';

function Zamestnanci(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/zamestnanec",{mode:'cors'})
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
                    <th>Name</th>
		    <th>Surname</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>Provozovna ID</th>
                    <th>Pracovni_pozice ID</th>
                    <th>Address ID</th>
                    <th>Editations</th>
                </tr>
                </thead>
                <tbody>
                {data.map((employee) => (
                    <tr key={employee.idZamestnanec}>
                    <td>{employee.idZamestnanec}</td>
                    <td>{employee.jmeno}</td>
                    <td>{employee.prijmeni}</td>
                    <td>{employee.email}</td>
                    <td>{employee.telefon}</td>
                    <td>{employee.idProvozovna}</td>
                    <td>{employee.idPracovniPozice}</td>
                    <td>{employee.idAdresa}</td>
                    <td><button>Upravit</button><button>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Zamestnanci;