import React, { useState, useEffect } from 'react';

function PracovniPoziceForm({ id=0 }) {
    const searchParams = new URLSearchParams(document.location.search)
    searchParams.get('id') != undefined ? id=searchParams.get('id') : id=0;
    console.log(id);
    const [formData, setFormData] = useState({
        nazev: '',
        plat: '',
    });

    const fetchPracovniPoziceData = async () => {
        if (id !== 0) { 
            try {
                const response = await fetch(`https://localhost:7043/api/pracpozice/${id}`);
                if (response.ok) {
                    var data = await response.json();
                    data = Object.assign({}, data);
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
        fetchPracovniPoziceData();
    }, [id]);

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData((prevData) => ({
            ...prevData,
            [name]: value
        }));
    };

    function validInputs(){
        if(formData.nazev!=null & formData.plat!=null){
            return true;
        }
        return false;
    }
    const handleSubmit = async (e) => {
        e.preventDefault();
        if(validInputs()){
            try {
            
                const response = null;
                const text = `nazev=${formData.nazev}&plat=${formData.plat}`
                id===0 ? response=fetch(`https://localhost:7043/api/pracpozice?${text}`, {method: 'POST', mode: 'cors'}): 
                response =fetch(`https://localhost:7043/api/pracpozice/${id}?${text}`,{method: 'PUT', mode: 'cors'});
                
    
                if (response.ok) {
                    // Zde můžeš zpracovat odpověď, pokud je potřeba
                    
                } else {
                    alert('Nepodařilo se odeslat data');
                }
            
            
        } catch (error) {
            console.error(error);
        }
        window.location.href="/pracovni_pozice";
        }
        
    };

    return (
        <div className="container">
        <form onSubmit={handleSubmit}>
            <div className="mb-3">
                <label htmlFor="nazev" className="form-label">Název:</label>
                <input
                    type="text"
                    id="nazev"
                    name="naze"
                    value={formData.nazev}
                    onChange={handleInputChange}
                    placeholder="Zadejte název"
                    className="form-control"
                />
            </div>
            <div className="mb-3">
                <label htmlFor="plat" className="form-label">Plat:</label>
                <input
                    type="text"
                    id="plat"
                    name="plat"
                    value={formData.plat}
                    onChange={handleInputChange}
                    placeholder="Zadejte plat"
                    className="form-control"
                />
            </div>
            <button type="submit" className="btn btn-primary">{id == 0 ? 'Odeslat' : 'Upravit'}</button>
        </form>
    </div>
    );
}

export default PracovniPoziceForm;
