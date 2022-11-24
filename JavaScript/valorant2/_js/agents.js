var listAgent = new Array();

addEventListener("load", () => {
  getApi(URL_API_AGENT, criaListaAgent);
});
$('#btn-filter-agent').click((e)=>{
    e.preventDefault();
})

const criaListaAgent = (data) => {
  let main = getElement("main");
  console.log(data);
  listAgent = new Array();

  data.data.forEach((agent) => {
    let html = document.createElement("div");
    let filterClick = getElement("#btn-filter-agent");
    html.classList.add('card', 'col-10', 'col-sm-2', 'my-4', 'bg-red', 'ms-1');
    html.addEventListener("click", () => mostraDetalhesAgent(agent));
    filterClick.addEventListener("click", () => filterAgent(agent));
    
    
    let htmlBody = `<div class="card-header">
                            <h2 class="text-dark text-center">${agent.displayName}</h2>
                        </div>
                        <div class="card-body">
                            <img class="card-img-top" src="${agent.displayIconSmall}" alt="${agent.displayName}">
                        </div>`;
    html.innerHTML = htmlBody;
    
    main.appendChild(html);
    listAgent.push(agent);
  });
};


const mostraDetalhesAgent = (agent) => {
  console.log(agent);
  let div = document.createElement("div");
  getElement("#modal-body").innerHTML = "";
  div.classList.add("card", "col-12", "my-4", "bg-dark");

  let cardBody = `
    <div class="card-header">
      <img class="img-fluid" class="card-img-top" src="${agent.displayIconSmall}" alt="${agent.displayName}">
    </div>
    <div class="card-body text-white">
      <h1 class="text-center">${agent.displayName}</h1>
      <article>
          <ul class="list-group">
              <li class="list-group-item bg-red">${agent.description}</li>
              <li class="list-group-item bg-red">
              <div class="accordion accordion-flush" id="accordionFlushExample">
                <div class="accordion-item bg-red">
                  <h2 class="accordion-header" id="flush-headingOne">
                    <button class="accordion-button bg-red text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                      Role
                    </button>
                  </h2>
                  <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                    <div class="accordion-body">
                        <article>
                            <ul class="list-group">
                                <li class="list-group-item text-white bg-dark">${agent.role.displayName}<li>
                                <li class="list-group-item text-white bg-dark">${agent.role.description}<li>
                                <li class="list-group-item text-white bg-dark"><img class="img-fluid" src="${agent.role.displayIcon}"><li>
                            </ul>
                        </article>
                    </div>
                  </div>
                </div>
              </div>
              </li>
              <li class="list-group-item bg-red">
              <div class="accordion accordion-flush" id="ability">
                <div class="accordion-item bg-red">
                  <h2 class="accordion-header" id="flush-headingTwo">
                    <button class="accordion-button bg-red text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                      Abilities
                    </button>
                  </h2>
                  <div id="flush-collapseTwo" class="accordion-collapse collapse" aria-labelledby="flush-headingTwo" data-bs-parent="#ability">
                    <div class="accordion-body">
                        <article>
                            <ul class="list-group">
                                <li class="list-group-item bg-white">
                                    <div class="accordion accordion-flush" id="ability1">
                                        <div class="accordion-item bg-white">
                                            <h2 class="accordion-header" id="flush-headingTwoOne">
                                                <button class="accordion-button bg-white text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwoOne" aria-expanded="false" aria-controls="flush-collapseTwoOne">
                                                ${agent.abilities[0].slot}
                                                </button>
                                            </h2>
                                            <div id="flush-collapseTwoOne" class="accordion-collapse collapse" aria-labelledby="flush-headingTwoOne" data-bs-parent="#ability1">
                                                <div class="accordion-body">
                                                    <article>
                                                        <ul class="list-group">
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[0].displayName}<li>
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[0].description}<li>
                                                            <li class="list-group-item text-dark bg-red"><img class="img-fluid" src="${agent.abilities[0].displayIcon}"><li>
                                                        </ul>
                                                    </article>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                                <li class="list-group-item bg-white">
                                    <div class="accordion accordion-flush" id="ability2">
                                        <div class="accordion-item bg-white">
                                            <h2 class="accordion-header" id="flush-headingTwoTwo">
                                                <button class="accordion-button bg-white text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwoTwo" aria-expanded="false" aria-controls="flush-collapseTwoTwo">
                                                ${agent.abilities[1].slot}
                                                </button>
                                            </h2>
                                            <div id="flush-collapseTwoTwo" class="accordion-collapse collapse" aria-labelledby="flush-headingTwoTwo" data-bs-parent="#ability2">
                                                <div class="accordion-body">
                                                    <article>
                                                        <ul class="list-group">
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[1].displayName}<li>
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[1].description}<li>
                                                            <li class="list-group-item text-dark bg-red"><img class="img-fluid" src="${agent.abilities[1].displayIcon}"><li>
                                                        </ul>
                                                    </article>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                                <li class="list-group-item bg-white">
                                    <div class="accordion accordion-flush" id="ability3">
                                        <div class="accordion-item bg-white">
                                            <h2 class="accordion-header" id="flush-headingTwoThree">
                                                <button class="accordion-button bg-white text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwoThree" aria-expanded="false" aria-controls="flush-collapseTwoThree">
                                                ${agent.abilities[2].slot}
                                                </button>
                                            </h2>
                                            <div id="flush-collapseTwoThree" class="accordion-collapse collapse" aria-labelledby="flush-headingTwoThree" data-bs-parent="#ability3">
                                                <div class="accordion-body">
                                                    <article>
                                                        <ul class="list-group">
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[2].displayName}<li>
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[2].description}<li>
                                                            <li class="list-group-item text-dark bg-red"><img class="img-fluid" src="${agent.abilities[2].displayIcon}"><li>
                                                        </ul>
                                                    </article>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                                <li class="list-group-item bg-white">
                                    <div class="accordion accordion-flush" id="ability4">
                                        <div class="accordion-item bg-white">
                                            <h2 class="accordion-header" id="flush-headingTwoFour">
                                                <button class="accordion-button bg-white text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwoFour" aria-expanded="false" aria-controls="flush-collapseTwoFour">
                                                ${agent.abilities[3].slot}
                                                </button>
                                            </h2>
                                            <div id="flush-collapseTwoFour" class="accordion-collapse collapse" aria-labelledby="flush-headingTwoFour" data-bs-parent="#ability4">
                                                <div class="accordion-body">
                                                    <article>
                                                        <ul class="list-group">
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[3].displayName}<li>
                                                            <li class="list-group-item text-dark bg-red">${agent.abilities[3].description}<li>
                                                            <li class="list-group-item text-dark bg-red"><img class="img-fluid" src="${agent.abilities[3].displayIcon}"><li>
                                                        </ul>
                                                    </article>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </article>
                    </div>
                  </div>
                </div>
              </div>
              </li>
          </ul>
      </article>
    </div>`;
  div.innerHTML = cardBody;
  getElement("#modal-body").appendChild(div);

  $("#charModal").modal("show");
};



const filterAgent = (agent) => {
    let filter = getElement("#filter-agent").value;
    if (agent.displayName.toLowerCase() == filter.toLowerCase()) {
        mostraDetalhesAgent(agent)
    }
}
