const LIST_FEEDBACK = "list_feedback";
var listFeedback = new Array();

$("#btn-feedback").click((e)=>{
  e.preventDefault();
})

addEventListener("load", () => {
    let enviaFeedback = getElement("#btn-feedback");
    enviaFeedback.addEventListener("click", () => salvaFeedback());
    listarFeedback();
});

const salvaFeedback = () => {

    let emailFeedback = getElement('#feedback-email');
    let nameFeedback = getElement('#feedback-name');
    let avaliacaoFeedback = getElement('#feedback-avaliacao');
    let feedback;

    if (listFeedback == null) {
        listFeedback= new Array();
    } else {
        listFeedback = getJsonItem(LIST_FEEDBACK) || [];
    }
  

    feedback = {email: emailFeedback.value,
                name: nameFeedback.value,
                avaliacao: avaliacaoFeedback.value};

    listFeedback.push(feedback);

    
    setJsonItem(LIST_FEEDBACK,listFeedback);
    limpaFeedback();
    listarFeedback();
    console.log(listFeedback);
}

const listarFeedback = () => {
  let feedbacksHTML = getElement('#feedbacks');
  getElement('#feedbacks').innerHTML = "";
  listFeedbacks = new Array();
  listFeedback = getJsonItem(LIST_FEEDBACK);
  
  if (listFeedback == null || listFeedback.length <= 0) return;
  
  listFeedback.forEach((f) => {
    let html = document.createElement("tr");
    html.classList.add(
      "text-white",
      "col-12",
      "col-sm-12",
      "bg-red"
    );

    let htmlBody = `<td class="col-3 col-sm-3">${f.name}</td>
                    <td class="col-3 col-sm-3">${f.email}</td>
                    <td class="col-6 col-sm-6">${f.avaliacao}</td>`;
    html.innerHTML = htmlBody;
    feedbacksHTML.appendChild(html);
  });
};

const limpaFeedback = () =>{
  getElement('#feedback-email').value = "";
  getElement('#feedback-name').value = "";
  getElement('#feedback-avaliacao').value = "";
}

