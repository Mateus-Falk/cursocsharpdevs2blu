const LIST_COMENTARIOS = "list_store";
const LIST_COMPRADOS = "list_comprados";
var listSkin = new Array();
var listComentarios = new Array();
var listComprados = new Array();

addEventListener("load", () => {
    getApi(URL_API_WEAPON, criaListaSkin);
    
});

$('#btn-filter-weapon-skin').click((e)=>{
    e.preventDefault();
  })

const criaListaSkin = (data) => {
  let main = getElement('#store');
  console.log(data);
  listSkin = new Array();
  
  
  data.data.forEach((weapon) => {
    
    weapon.skins.forEach((skins) => {
      let html = document.createElement("div");
      html.classList.add(
        "card",
        "col-10",
        "col-sm-3",
        "my-4",
        "bg-red",
        "ms-1"
        );
        
        html.addEventListener("click", () => mostraDetalhesSkin(weapon,skins));        
        
        let htmlBody = `<img src="${skins.displayIcon}" class="card-img-top pt-3" alt="${skins.displayName}">
                        <div class="card-body">
                          <h5 class="card-title">${skins.displayName}</h5>
                          <p class="card-text">${weapon.displayName}</p>
                        </div>`;
        html.innerHTML = htmlBody;
        main.appendChild(html);
      });
  });
};


const mostraDetalhesSkin = (weapon,skin)=> {
  let div = document.createElement('div');
  getElement('#modal-body').innerHTML = "";
  div.classList.add('card','col-12','my-4','bg-dark');

  let comprar = getElement('#btn-comprar');
  comprar.addEventListener('click', () => salvaCompra(skin))

  let comentar = getElement('#btn-comentar-store');
  comentar.addEventListener('click', () => salvaComentario(skin))

  let skinName = skin.displayName; 
  skinName = skinName.replace(/\s/g, ''); 
  skinName = skinName.replace( /:/g , ''); 
  skinName = skinName.replace( /[/]/g , ''); 
  skinName = skinName.replace( /[.]/g , ''); 
  skinName = skinName.replace( /[']/g , ''); 

  let cardBody = `
      <div class="card-header">
          <img class="img-fluid" src="${skin.displayIcon}" alt="${skin.displayName}">
      </div>
      <div class="card-body text-white">
          <h1 class="text-center">${skin.displayName}</h1>
          <article>
              <ul class="list-group">
                  <li class="list-item text-center">${weapon.displayName}</li>
              </ul>
              <div id="comentarios${skinName}">
              </div>
              <ul class="list-group">
                  <li class="list-item"><input id="nome${skinName}" class="form-control" type="text" placeholder="Informe seu nome"></li>
                  <li class="list-item"><input id="comentario${skinName}" class="form-control" type="text" placeholder="Insira um comentario"></li>
              </ul>
          </article> 
          <input type="hidden" id="nome-weapon${skinName}" value="${weapon.displayName}">
          <input type="hidden" id="nome-skin${skinName}" value="${skin.displayName}">
          <input type="hidden" id="image-skin${skinName}" value="${skin.displayIcon}">
      <div>`;
  div.innerHTML = cardBody;
  getElement("#modal-body").appendChild(div);
  addComentario(skin);
  $("#charModal").modal("show");
}


const salvaCompra = (skins) => {
  if (listComprados == null) {
      listComprados = new Array();
  } else {
    listComprados = getJsonItem(LIST_COMPRADOS) || [];
  }

  let skinName = skins.displayName; 
  skinName = skinName.replace(/\s/g, ''); 
  skinName = skinName.replace( /:/g , ''); 
  skinName = skinName.replace( /[/]/g , ''); 
  skinName = skinName.replace( /[.]/g , ''); 
  skinName = skinName.replace( /[']/g , ''); 



  let weaponName = getElement(`#nome-weapon${skinName}`);
  let name = getElement(`#nome-skin${skinName}`);
  let skinImage = getElement(`#image-skin${skinName}`);

  let skin
  skin = {weapon:weaponName.value,
          name:name.value,
          image:skinImage.value};

 listComprados.push(skin);

  
  setJsonItem(LIST_COMPRADOS,listComprados);
  console.log(listComprados);
}

const salvaComentario = (skin)=> { 
  let nomeSkin = skin.displayName; 
  nomeSkin = nomeSkin.replace(/\s/g, ''); 
  nomeSkin = nomeSkin.replace(/:/g, ''); 
  nomeSkin = nomeSkin.replace( /[/]/g , ''); 
  nomeSkin = nomeSkin.replace( /[.]/g , ''); 
  nomeSkin = nomeSkin.replace( /[']/g , ''); 
  


  let skinComentario = skin.displayName;
  let nome = getElement(`#nome${nomeSkin}`);
  let mensagem = getElement(`#comentario${nomeSkin}`);
  let comentario
  
  
  if (listComentarios == null) {
      listComentarios = new Array();
  } else {
    listComentarios = getJsonItem(LIST_COMENTARIOS) || [];
  }
  if (nome != "" && mensagem !="" && skinComentario != ""){
      comentario = {skin:skinComentario,
                  nome:nome.value,
                  mensagem:mensagem.value};
      listComentarios.push(comentario);
      setJsonItem(LIST_COMENTARIOS,listComentarios);
  }
  addComentario(skin);
  console.log(listComentarios);
}

const addComentario = (skin)=>{

  let nomeSkin = skin.displayName; 
  nomeSkin = nomeSkin.replace(/\s/g, ''); 
  nomeSkin = nomeSkin.replace(/:/g, ''); 
  nomeSkin = nomeSkin.replace( /[/]/g , ''); 
  nomeSkin = nomeSkin.replace( /[.]/g , ''); 
  nomeSkin = nomeSkin.replace( /[']/g , ''); 
  getElement(`#comentarios${nomeSkin}`).innerHTML = "";
  listComentarios.forEach((c) => {
    console.log('Teste');
    if (c.skin == skin.displayName) {
      let ul = document.createElement('ul');
      ul.classList.add('list-group');

      let conteudo = `<li class="list-group-item">${c.nome}</li>
                      <li class="list-group-item">${c.mensagem}</li>`;
      ul.innerHTML = conteudo;
      getElement(`#comentarios${nomeSkin}`).appendChild(ul);
      limpaComentarios(skin);
    }
  });
}

const limpaComentarios = (skin) => {
  let skinName = skin.displayName; 
  skinName = skinName.replace(/\s/g, ''); 
  skinName = skinName.replace( /:/g , ''); 
  skinName = skinName.replace( /[/]/g , ''); 
  skinName = skinName.replace( /[.]/g , ''); 
  skinName = skinName.replace( /[']/g , ''); 

  getElement(`#nome${skinName}`).value = "";
  getElement(`#comentario${skinName}`).value = "";
}