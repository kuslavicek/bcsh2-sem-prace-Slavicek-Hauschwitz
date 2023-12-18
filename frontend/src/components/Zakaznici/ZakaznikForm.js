function ZakaznikForm(i=0){
    
    const url = "https://localhost:7043/api/zakaznik?jmeno=Pepa&ulice=Vrchní&mesto=Pardubice&cislo_popisne=532&psc=53509&telefon=732732512&email=pepa@gmail.com&stat=ČR"

    if(i=0){
        return(
        <div>
            <form>



            </form>

        </div>
    )
    }else{
        return(
            <div>
                <form>


                
                </form>
            </div>
        )
    }
}
export default ZakaznikForm;