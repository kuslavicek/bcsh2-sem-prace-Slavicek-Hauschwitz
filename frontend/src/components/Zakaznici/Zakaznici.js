import React, { useState, useEffect } from 'react';

function Zakaznici(){
    
    const data = fetch("localhost:7043/api/zakaznik");
    console.log(data);  
  
    return(
        <div>
            <table>
                <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Phone</th>
                    <th>Email</th>
                    <th>Address ID</th>
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
                    </tr>
                ))}
                </tbody>
            </table>
        </div>
    )

}
export default Zakaznici;