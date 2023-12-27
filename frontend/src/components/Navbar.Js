import './Navbar.css'

function Navbar(){
    return(
        <div class="navigation">
            <span class="nazev">Aplikace</span>
            <a href="/">Hlavní stránka</a>
            <a href="/zakaznici">Zákazníci</a>
            <a href="/zamestnanci">Zaměstnanci</a>
            <a href="/adresy">Adresy</a>
            <a href="/akce">Akce</a>
            <a href="/pivovar">Pivovary</a>
            <a href="/pracovni_pozice">Pracovní pozice</a>
            <a href="/objednavka">Objednávky</a>
            <a href="/provozovna">Provozovny</a>
            <a href="/typakce">Typy akce</a>
        </div>
    )
}
export default Navbar