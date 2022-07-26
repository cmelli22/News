import React, { useParams, useState, useEffect } from "react";
import Header from './Header'
import CardContainer from '../Card/CardContainer'
import Buscador from '../Buscador/Buscador'

const Busqueda = () => {

    let[news, setNews] =  useState([]);
    let[keyword, setKeyword] = useState("bitcoin");
    let[pageSize, setPageSize] = useState(10);
    let[dateFrom, setDateFrom] = useState("");
    let[dateTo, setDateTo] = useState("");

    useEffect(()=>{
        getApiData();
    },[keyword])

    const getApiData = async () => {
        const response = await fetch(
        `https://localhost:44317/api/news/search?Keyword=${keyword}&pageSize=${pageSize}`
        ).then((response) => response.json());

        console.log(response);
        if(response.articles != null){
            setNews(response.articles);
        }

      };

      const onChangeFunction = (e) =>{
        console.log(e)
        switch(e.target.name){
            case 'from':
                setDateFrom(e.target.value)
                break;
            case 'to':
                setDateTo(e.target.value)
                break;
            case 'keyword':
                setKeyword(e.target.value)
                break;
        }
      }

    return(
        <>
            <Header>
            </Header>
            <Buscador onChangeFunction= {onChangeFunction}>
            </Buscador>
            {
                news.length != 0?(
                    <CardContainer data={news}>
                    </CardContainer>
                ):null
            }

        </>
    )
};

export default Busqueda;