import React, { useState, useEffect } from 'react';
import {redirect} from 'react-router-dom'

function ZakaznikForm({ id }) {
    const [formData, setFormData] = useState({
        jmeno: '',
        ulice: '',
        mesto: '',
        cislo_popisne: '',
        psc: '',
        telefon: '',
        email: '',
        stat: ''
    });

    const fetchZakaznikData = async () => {
        if (id !== 0) {
            try {
                const response = await fetch(`https://localhost:7043/api/zakaznik/${id}`);
                if (response.ok) {
                    const data = await response.json();
                    setFormData(data); // Nastavení dat získaných z API
                } else {
                    throw new Error('Nepodařilo se načíst data z API');
                }
            } catch (error) {
                console.error(error);
            }
        }
    };

    useEffect(() => {
        fetchZakaznikData();
    }, [id]);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData((prevData) => ({
            ...prevData,
            [name]: value
        }));
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            const requestOptions = {
                method: id === 0 ? 'POST' : 'PUT',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(formData)
            };

            const response = await fetch(
                id === 0
                    ? 'https://localhost:7043/api/zakaznik'
                    : `https://localhost:7043/api/zakaznik/${id}`,
                requestOptions
            );

            if (response.ok) {
                // Zde můžeš zpracovat odpověď, pokud je potřeba
                redirect("/zakaznici")
            } else {
                throw new Error('Nepodařilo se odeslat data');
            }
        } catch (error) {
            console.error(error);
        }
    };

    return (
        <div>
            <form onSubmit={handleSubmit}>
                <input type="text" name="jmeno" value={formData.jmeno} onChange={handleInputChange} />
                <input type="text" name="ulice" value={formData.ulice} onChange={handleInputChange} />
                <input type="text" name="mesto" value={formData.mesto} onChange={handleInputChange} />
                <input
                    type="text"
                    name="cislo_popisne"
                    value={formData.cislo_popisne}
                    onChange={handleInputChange}
                />
                <input type="text" name="psc" value={formData.psc} onChange={handleInputChange} />
                <input type="text" name="telefon" value={formData.telefon} onChange={handleInputChange} />
                <input type="text" name="email" value={formData.email} onChange={handleInputChange} />
                <input type="text" name="stat" value={formData.stat} onChange={handleInputChange} />

                <button type="submit">{id === 0 ? 'Odeslat' : 'Upravit'}</button>
            </form>
        </div>
    );
}

export default ZakaznikForm;
