import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function Zamestnanci(){
    
    const [data, setData] = useState([]);

  useEffect(() => {
    // Replace 'API_ENDPOINT' with your actual API endpoint
    fetch("https://localhost:7043/api/zamestnanec",{mode:'cors'})
      .then((response) => response.json()) // Convert response to JSON
      .then((data) => setData(data))
      .catch((error) => console.error('Error fetching data:', error));
  }, []);

  function smazatZamestnance(e, id){
    e.preventDefault();
    fetch("https://localhost:7043/api/zamestnanec/"+id, { mode: 'cors', method: 'DELETE' }).then((response)=> console.log(response)).then( window.location.reload());
  };
    return(
        <div>
            <button onClick={(e)=> window.location.href='/zamestnanec-form'}>Přidat nového zaměstnance</button>
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
                    <td><button onClick={(e)=>window.location.href=(`/zamestnanec-form?id=${employee.idZamestnanec}`)}>Upravit</button><button onClick={(e)=>smazatZamestnance(e, employee.idZamestnanec)}>Smazat</button></td>
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Zamestnanci;