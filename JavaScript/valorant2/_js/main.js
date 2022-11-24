const LIST_NEWSLETTER = "list_newsletter";
var listAgent = new Array();
var listNewsletter = new Array();

$("#btn-newsletter").click((e)=>{
  e.preventDefault();
})

addEventListener("load", () => {
    getApi(URL_API_AGENT, criaNewAgent);
    listarComprados();

    let newsletter = getElement("#btn-newsletter");
    newsletter.addEventListener("click", () => salvaNewsletter());

  });

  const criaNewAgent = (data) => {
    let main = getElement("main");
    console.log(data);
    listAgent = new Array();
  
    data.data.forEach((agent) => {
      let html = document.createElement("div");
      let newAgent = 'Harbor';

      if (newAgent == agent.displayName) { 
          html.classList.add('card', 'col-10', 'col-sm-6', 'my-4', 'bg-red', 'ms-1');
          
          
          let htmlBody = `<div class="card-header">
          <h2 class="text-dark text-center">${agent.displayName}</h2>
          </div>
          <div class="card-body">
          <img class="card-img-top" src="${agent.displayIconSmall}" alt="${agent.displayName}">
          </div>`;
          html.innerHTML = htmlBody;
          
          main.appendChild(html);
      }

      listAgent.push(agent);
    });
  };
  
    const salvaNewsletter = () => {

      let emailAssinante  = getElement('#newsletter-email');
      let nameAssinante  = getElement('#newsletter-name');
      let assinante;

      if (listNewsletter == null) {
        listNewsletter = new Array();
      } else {
        listNewsletter = getJsonItem(LIST_NEWSLETTER) || [];
      }
    
  
      assinante = {email: emailAssinante .value,
                   name: nameAssinante .value};
  
     listNewsletter.push(assinante);
  
      
      setJsonItem(LIST_NEWSLETTER,listNewsletter);
      limpaNewsletter();
      console.log(listNewsletter);
  }

  const limpaNewsletter = () => {
    getElement('#newsletter-email').value = "";
    getElement('#newsletter-name').value = "";
  }
  
  const listarComprados = () => {
    let compradosHTML = getElement('#comprados');
    listComprados = new Array();
    listComprados = getJsonItem(LIST_COMPRADOS);
    
    if (listComprados == null || listComprados.length <= 0) return;
    
    listComprados.forEach((s) => {
      let html = document.createElement("div");
      html.classList.add(
        "card",
        "col-10",
        "col-sm-3",
        "my-4",
        "bg-red",
        "ms-1"
      );

      let htmlBody = `<div class="card-header">
                          <h2 class="text-dark text-center">${s.name}</h2>
                      </div>
                      <div class="card-body">
                        <article>
                          <ul class="list-group">
                            <li class="list-group-item bg-red"><img class="card-img-top" src="${s.image}" alt="${s.name}"></li>
                            <li class="list-group-item bg-red">${s.weapon}</li>
                        </article>
                      </div>`;
      html.innerHTML = htmlBody;
      compradosHTML.appendChild(html);
    });
  };


