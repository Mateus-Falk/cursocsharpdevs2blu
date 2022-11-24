//  # Confs
const URL_API_CHARACTER = 'https://rickandmortyapi.com/api/character'

//  # Functions
function getElement(q) {
    return document.querySelector(q);
}

const getAPI = (url, functionCallback) => {
    fetch(url).then(
                (response) => response.json(), //resolve (retorno ok)
                (error) => console.log(error)) //reject (erro no retorno)
              .then(
                dataJson => functionCallback(dataJson), //resolve (retorno ok)
                erro => console.error(erro)); //reject (erro no retorno)
}


//  # Services

