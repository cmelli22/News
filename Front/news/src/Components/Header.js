import { Link } from "react-router-dom";

const Header = ({country}) => {
    return (
        <>
            <nav className="navbar navbar-expand-lg nav-bar">
                <div >
                    <h1>Portal Noticias</h1>
                    <div className="container-header">
                        <Link to={"/"}>
                            <h3>Ultimas Noticias</h3>
                        </Link>
                        <h3>/</h3>
                        <Link to={"/Busqueda"}>
                            <h3>Buscador</h3>
                        </Link>

                    </div>
                </div>
            </nav>
        </>
    )
}


export default Header;