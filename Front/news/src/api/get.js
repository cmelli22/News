
  export const getApiData = async () => {
    const response = await fetch(
      "https://localhost:44317/api/news"
    ).then((response) => response.json());
    return response;
  };