
$(document).ready(()=>{
    console.log('JQuery is load');
    
    // Inicializa parametros do sistema
    init();
});

const init = ()=>{
    // Carregar Views
    getView('home','#root');
    
    // Carregar Serviços
    initializeServices();

    // Carregar Eventos
    initializeEvents();
}

const initializeServices = () => {
    // Carregar/Armazenar Pokemons da API
    atualizarListaPKMNStorage();
   
    // * Destaques
    getAPI(URL_API_PKMN, fillDestaques)
    
}

const initializeEvents = () => {
    // # Meus Pokémons
    $('#pag-meus-pokemons').click(()=>getView('meus-pokemons','#root'));
    
    // Botao Pesquisar
    $('#btn-pesquisa').click((e)=>{
        e.preventDefault();
        let valorPesquisa = $('#input-pesquisa').val();
        // Realizar Pesquisa
    })
    
}

