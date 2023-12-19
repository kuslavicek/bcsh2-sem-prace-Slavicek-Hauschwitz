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
        <div className="container">
        <form onSubmit={handleSubmit}>
            <div className="mb-3">
                <label htmlFor="jmeno" className="form-label">Jméno:</label>
                <input
                    type="text"
                    id="jmeno"
                    name="jmeno"
                    value={formData.jmeno}
                    onChange={handleInputChange}
                    placeholder="Zadejte jméno"
                    className="form-control"
                />
            </div>
            <div className="mb-3">
                <label htmlFor="ulice" className="form-label">Ulice:</label>
                <input
                    type="text"
                    id="ulice"
                    name="ulice"
                    value={formData.ulice}
                    onChange={handleInputChange}
                    placeholder="Zadejte ulici"
                    className="form-control"
                />
            </div>
            <div className="mb-3">
                <label htmlFor="mesto" className="form-label">Město:</label>
                <input
                    type="text"
                    id="mesto"
                    name="mesto"
                    value={formData.mesto}
                    onChange={handleInputChange}
                    placeholder="Zadejte město"
                    className="form-control"
                />
            </div>
            <div className="mb-3">
        <label htmlFor="cislo_popisne" className="form-label">Číslo popisné:</label>
        <input
            type="text"
            id="cislo_popisne"
            name="cislo_popisne"
            value={formData.cislo_popisne}
            onChange={handleInputChange}
            placeholder="Zadejte číslo popisné"
            className="form-control"
        />
    </div>
    <div className="mb-3">
        <label htmlFor="psc" className="form-label">PSČ:</label>
        <input
            type="text"
            id="psc"
            name="psc"
            value={formData.psc}
            onChange={handleInputChange}
            placeholder="Zadejte PSČ"
            className="form-control"
        />
    </div>
    <div className="mb-3">
        <label htmlFor="telefon" className="form-label">Telefon:</label>
        <input
            type="text"
            id="telefon"
            name="telefon"
            value={formData.telefon}
            onChange={handleInputChange}
            placeholder="Zadejte telefon"
            className="form-control"
        />
    </div>
    <div className="mb-3">
        <label htmlFor="email" className="form-label">Email:</label>
        <input
            type="text"
            id="email"
            name="email"
            value={formData.email}
            onChange={handleInputChange}
            placeholder="Zadejte email"
            className="form-control"
        />
        </div>
    <div className="mb-3">
    <label htmlFor="stat" className="form-label">Stát:</label>
    <input
        type="text"
        id="stat"
        name="stat"
        value={formData.stat}
        onChange={handleInputChange}
        placeholder="Zadejte stát"
        className="form-control"
    />
    </div>
            <button type="submit" className="btn btn-primary">{id === 0 ? 'Odeslat' : 'Upravit'}</button>
        </form>
    </div>
    );
}

export default ZakaznikForm;
