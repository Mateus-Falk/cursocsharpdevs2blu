var listWeapon = new Array();

addEventListener('load', ()=>{
    getApi(URL_API_WEAPON, criaListaWeapon);
})

$('#btn-filter-weapon').click((e)=>{
  e.preventDefault();
})

const criaListaWeapon = (data) => {
    let main = getElement("main");
  console.log(data);
  listWeapon = new Array();

  data.data.forEach((weapon) => {
    let html = document.createElement("div");
    let filterClick = getElement("#btn-filter-weapon");
    html.classList.add('card', 'col-10', 'col-sm-3', 'my-4', 'bg-red', 'ms-1');
    html.addEventListener("click", () => mostraDetalhesWeapon(weapon));
    filterClick.addEventListener("click", () => filterWeapon(weapon));

    let htmlBody = `<div class="card-header">
                            <h2 class="text-dark text-center">${weapon.displayName}</h2>
                        </div>
                        <div class="card-body">
                            <img class="card-img-top" src="${weapon.displayIcon}" alt="${weapon.displayName}">
                        </div>`;
    html.innerHTML = htmlBody;
    main.appendChild(html);
    listWeapon.push(weapon);
  });
};

const mostraDetalhesWeapon = (weapon) => {
    console.log(weapon);
    let div = document.createElement("div");
    getElement("#modal-body").innerHTML = "";
    div.classList.add("card", "col-12", "my-4", "bg-dark");
  
    let cardBody = `
      <div class="card-header">
        <img class="img-fluid" class="card-img-top" src="${weapon.displayIcon}" alt="${weapon.displayName}">
      </div>
      <div class="card-body text-white">
        <h1 class="text-center">${weapon.displayName}</h1>
        <article>
            <ul class="list-group">
                <li class="list-group-item bg-red">${weapon.shopData.category}</li>
                <li class="list-group-item bg-red">
                <div class="accordion accordion-flush" id="accordionFlushExample">
                  <div class="accordion-item bg-red">
                    <h2 class="accordion-header" id="flush-headingOne">
                      <button class="accordion-button bg-red text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                        Weapon Stats
                      </button>
                    </h2>
                    <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                      <div class="accordion-body">
                          <article>
                              <ul class="list-group">
                                <li class="list-group-item text-dark bg-white">Fire Rate: ${weapon.weaponStats.fireRate}<li>
                                <li class="list-group-item text-dark bg-white">Magazine Size: ${weapon.weaponStats.magazineSize}<li>
                                <li class="list-group-item text-dark bg-white">Equip Time: ${weapon.weaponStats.runSpeedMultiplier}<li>
                                <li class="list-group-item text-dark bg-white">Reload Time: ${weapon.weaponStats.equipTimeSeconds}<li>
                                <li class="list-group-item bg-white">
                                    <div class="accordion accordion-flush" id="head-damage">
                                        <div class="accordion-item bg-white">
                                            <h2 class="accordion-header" id="flush-headingTwoOne">
                                                <button class="accordion-button bg-white text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwoOne" aria-expanded="false" aria-controls="flush-collapseTwoOne">
                                                    Damage
                                                </button>
                                            </h2>
                                            <div id="flush-collapseTwoOne" class="accordion-collapse collapse" aria-labelledby="flush-headingTwoOne" data-bs-parent="#head-damage">
                                                <div class="accordion-body">
                                                    <article>
                                                        <ul class="list-group">
                                                            <li class="list-group-item text-dark bg-red">Head: ${weapon.weaponStats.damageRanges[0].headDamage}<li>
                                                            <li class="list-group-item text-dark bg-red">Body: ${weapon.weaponStats.damageRanges[0].bodyDamage}<li>
                                                            <li class="list-group-item text-dark bg-red">Legs: ${weapon.weaponStats.damageRanges[0].legDamage}<li>
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
                <li class="list-group-item bg-red">
                <div class="accordion accordion-flush" id="shop">
                  <div class="accordion-item bg-red">
                    <h2 class="accordion-header" id="flush-shop">
                      <button class="accordion-button bg-red text-dark collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseShop" aria-expanded="false" aria-controls="flush-collapseShop">
                        Shop
                      </button>
                    </h2>
                    <div id="flush-collapseShop" class="accordion-collapse collapse" aria-labelledby="flush-headingShop" data-bs-parent="#shop">
                      <div class="accordion-body">
                          <article>
                              <ul class="list-group">
                                <li class="list-group-item text-dark bg-white">Cost: ${weapon.shopData.cost}<li>
                                <li class="list-group-item text-dark bg-white">Category: ${weapon.shopData.category}<li>
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

  const filterWeapon = (weapon) => {
    let filter = getElement("#filter-weapon").value;
    if (weapon.displayName.toLowerCase() == filter.toLowerCase()) {
        mostraDetalhesWeapon(weapon)
    } 
}
