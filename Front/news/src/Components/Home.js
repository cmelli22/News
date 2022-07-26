import React, { useParams, useState, useEffect } from "react";
import Header from './Header'
import CardContainer from '../Card/CardContainer'
const Home = () => {

    const[news, setNews] =  useState([]);
    let[pais,setPais] = useState();


    useEffect(()=>{
        getApiData();
    },[])

    const getApiData = async () => {

        const response = await fetch(
          "https://localhost:44317/api/news/top-headlines?pageSize=10"
        ).then((response) => response.json());
        console.log(response);

        if(response.articles != null){
            setNews(response.articles);
        }
      };


    return(
        <>
            <Header>
            </Header>
            {
                news.length != 0?(
                    <CardContainer data={news}>
                    </CardContainer>
                ):null
            }
        </>
    )
};

export default Home;