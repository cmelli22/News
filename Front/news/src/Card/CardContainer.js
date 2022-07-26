
import { Link } from "react-router-dom";

const Card = ({data}) => {

    return(
        <>
        {data.map((news , i) => {
            return (
                <div className="card-container border" key={i}>
                    <img className="border" src={news.urlToImage} width="250" />
                    <div className="container-info">
                        <h5 className="titulo border">{news.title}</h5>
                        <p className="descripcion">{news.description}</p>
                        <div className="footer-card">
                           <span className="border">{news.publishedAt}</span>
                           <Link to={"/"}>
                            <span className="border">Ver Mas..</span>
                           </Link> 
                        </div>
                    </div>      

                </div>
            )
        })
        
        }
        </>
    )
}

export default Card;