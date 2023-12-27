import React, { useState, useEffect } from 'react';

function ObjednavkaForm({ id=0 }) {
    const searchParams = new URLSearchParams(document.location.search)
    searchParams.get('id') != undefined ? id=searchParams.get('id') : id=0;
    console.log(id);
    const [formData, setFormData] = useState({
        datum: '',
        cena: '',
        ulice: '',
        mesto: '',
        cislo_popisne: '',
        psc: '',
        stat: '',
    });

    const fetchObjednavkaData = async () => {
        if (id !== 0) { 
            try {
                const response = await fetch(`https://localhost:7043/api/objednavka/${id}`);
                if (response.ok) {
                    var data = await response.json();
                    const adresaId = data.idAdresa;
                    const adresa = await fetch(`https://localhost:7043/api/adresa/${adresaId}`).then((response1)=> response1.json());
                    console.log(adresa);
                    data = Object.assign({}, data,adresa);
                    data.cislo_popisne = adresa.cisloPopisne;
                    setFormData(data); // Nastavení dat získaných z API
                } else {
                    alert('Nepodařilo se načíst data z API');
                }
            } catch (error) {
                console.error(error);
            }
        }
    };

    useEffect(() => {
        fetchObjednavkaData();
    }, [id]);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData((prevData) => ({
            ...prevData,
            [name]: value
        }));
    };

    function validInputs(){
        if(formData.cislo_popisne.match(/^\d+$/) && formData.psc.match(/^\d+$/)){
            return true;
        }
        return false;
    }
    const handleSubmit = async (e) => {
        e.preventDefault();
        if(validInputs()){
            try {
            
                const response = null;
                const text = `datum=${formData.datum}&cena=${formData.cena}&ulice=${formData.ulice}&mesto=${formData.mesto}&cislo_popisne=${formData.cislo_popisne}&psc=${formData.psc}&stat=${formData.stat}`
                id===0 ? response=fetch(`https://localhost:7043/api/objednavka?${text}`, {method: 'POST', mode: 'cors'}): 
                response =fetch(`https://localhost:7043/api/objednavka/${id}?${text}`,{method: 'PUT', mode: 'cors'});
                
    
                if (response.ok) {
                    // Zde můžeš zpracovat odpověď, pokud je potřeba
                    
                } else {
                    alert('Nepodařilo se odeslat data');
                }
            
            
        } catch (error) {
            console.error(error);
        }
        window.location.href="/objednavky";
        }
        
    };

    return (
        <div className="container">
        <form onSubmit={handleSubmit}>
            <div className="mb-3">
                <label htmlFor="datum" className="form-label">Datum:</label>
                <input
                    type="date"
                    id="datum"
                    name="datum"
                    value={formData.datum}
                    onChange={handleInputChange}
                    placeholder="Zadejte datum"
                    className="form-control"
                />
            </div>
            <div className="mb-3">
                <label htmlFor="cena" className="form-label">Cena:</label>
                <input
                    type="text"
                    id="cena"
                    name="cena"
                    value={formData.cena}
                    onChange={handleInputChange}
                    placeholder="Zadejte cenu"
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
            <button type="submit" className="btn btn-primary">{id == 0 ? 'Odeslat' : 'Upravit'}</button>
        </form>
    </div>
    );
}

export default ObjednavkaForm;
