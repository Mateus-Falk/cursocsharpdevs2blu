const URL_API_AGENT = 'https://valorant-api.com/v1/agents?isPlayableCharacter=true';
const URL_API_MAP = 'https://valorant-api.com/v1/maps';
const URL_API_WEAPON = 'https://valorant-api.com/v1/weapons';
// #Functions

const getElement = (q) => {
    return document.querySelector(q);
}

const getApi = (url,functionCallback) => {
    fetch(url).then((response) => response.json(),
                    (error) => console.log(erro))
              .then(dataJson => functionCallback(dataJson),
                    erro => console.error(erro));
}