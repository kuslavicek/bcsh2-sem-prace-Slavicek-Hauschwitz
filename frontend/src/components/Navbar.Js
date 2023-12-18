import './Navbar.css'

function Navbar(){
    return(
        <div class="navigation">
            <span class="nazev">Aplikace</span>
            <a href="/zakaznici">Zákazníci</a>
            <a href="/zamestnanci">Zaměstnanci</a>
        </div>
    )
}
export default Navbar