const URL_API = "https://zoo-animal-api.herokuapp.com/animals/rand/6";
const LISTA_ANIMALS = "lista_animals";

$(document).ready(() => {
  $("#btn-home").ready((e) => {
    getPagina("home.html", "main");
  });

  $("#btn-galeria").click((e) => {
    $("#destaque").hide();
    getPagina("galeria.html", "main");
  });

  $("#btn-home").click((e) => {
    $("#destaque").show();
    getPagina("home.html", "main");
  });

  $("#btn-home-logo").click((e) => {
    $("#destaque").show();
    getPagina("home.html", "main");
  });
});

const getAnimal = (url) => {
  getPagina("galeria.html", "main");
  $.ajax({
    url: url,
    dataType: "json",
    success: (data) => {
      let listAnimal = document.createElement("div");
      $(listAnimal).addClass("row");
      $("#getAnimal").html(listAnimal);
      listaAnimals = new Array();
      data.forEach((p, i) => {
        let li = document.createElement("div");
        let card = document.createElement("div");
        let cardHeader = document.createElement("div");
        let cardBody = document.createElement("div");

        $(li).addClass("col-4");
        $(li).addClass("hvr-grow");
        $(card).addClass("card");
        $(cardHeader).addClass("card-header");
        $(cardBody).addClass("card-body");

        $(cardBody).attr("id", `${p.id}`);

        $(cardHeader).html(`<h1>${p.name}</h1>`);
        $(cardBody).html(`<img src='${p.image_link} '>`);

        $(card).append(cardHeader).append(cardBody);
        $(li).append(card);
        $(listAnimal).append(li);
        $(cardBody).click(() => {
          console.log(`${p.id}`);

          let msg = `*** ADDITIONAL INFORMATIONS ***
Name: ${p.name}
Scientific Name: ${p.latin_name}               
Type: ${p.animal_type}
Length min: ${p.length_min}
Length max: ${p.length_max}
Weight min: ${p.weight_min}
Weight max: ${p.weight_max}
Lifespan: ${p.lifespan}
Habitat: ${p.habitat}
Diet: ${p.diet}
Region: ${p.geo_range}`;
          alert(msg);
        });

        animal = {
          id: p.id,
          name: p.name,
          animal_type: p.animal_type,
          length_min: p.length_min,
          length_max: p.length_max,
          weight_min: p.weight_min,
          weight_max: p.weight_max,
          lifespan: p.lifespan,
          habitat: p.habitat,
          diet: p.diet,
          geo_range: p.geo_range,
        };
        listaAnimals.push(animal);
      });
      salvarAnimal(listaAnimals);
    },
  });

  // const buscarAnimal(){

  // }

  const salvarAnimal = (listaAnimals) => {
    setJsonItem(LISTA_ANIMALS, listaAnimals);
  };
};
/*
var getPagina = (page, target) => {
  $.ajax({
    url: page,
    datatype: "html",
    success: (data) => {
      $(target).html(data);
    },
  });
};
*/