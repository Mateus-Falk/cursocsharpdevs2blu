listMap = new Array();

addEventListener('load',()=>{
    getApi(URL_API_MAP,criaListaMap);
})

$('#btn-filter-map').click((e)=>{
    e.preventDefault();
})

const criaListaMap = (data) => {
    let main = getElement('Main');
    console.log(data);
    listMap = new Array();

    data.data.forEach(map => {
        let html = document.createElement('div');
        let filterClick = getElement("#btn-filter-map");
        html.classList.add('card','col-10','col-sm-5','my-4','bg-red','ms-1');
        html.addEventListener('click', () => mostraDetalhesMap(map))
        filterClick.addEventListener("click", () => filterMap(map));
        let htmlBody = `
        <div class="card-header">
            <h2 class="text-dark text center">${map.displayName}</h2>
        </div>
        <div class="card-body">
            <img class="img-fluid" src="${map.splash}" alt="${map.displayName}">
        </div>`;
    
    html.innerHTML = htmlBody;
    main.appendChild(html);
    listMap.push(map);
    });
}

const mostraDetalhesMap = (map)=> {
    console.log(map);
    let div = document.createElement('div');
    getElement('#modal-body').innerHTML = "";
    div.classList.add('card','col-12','my-4','bg-dark');

    let cardBody = `
        <div class="card-header">
            <img class="img-fluid" src="${map.splash}" alt="${map.displayName}">
        </div>
        <div class="card-body text-white">
            <h1 class="text-center">${map.displayName}</h1>
            <article>
                <ul class="list-group">
                    <li class="list-item text-center">${map.coordinates}</li>
                    <li class="list-item"><img class="img-fluid" src="${map.displayIcon}"><li>
                </ul>
            </article>        
        <div>`;

    div.innerHTML = cardBody;
    getElement("#modal-body").appendChild(div);

    $("#charModal").modal("show");
}
const filterMap = (map) => {
    let filter = getElement("#filter-map").value;
    if (map.displayName.toLowerCase() == filter.toLowerCase()) {
        mostraDetalhesMap(map)
    } 
}