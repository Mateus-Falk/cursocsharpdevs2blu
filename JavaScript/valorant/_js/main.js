var listAgent = new Array();

addEventListener("load", () => {
    getApi(URL_API_AGENT, criaNewAgent);
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