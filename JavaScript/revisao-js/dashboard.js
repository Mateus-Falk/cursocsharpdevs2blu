const listaContatos = [];
listaContatos.push({nome:'Mateus', email:'mateus@gmail.com'})
listaContatos.push({nome:'Luis', email:'luis@gmail.com'})
listaContatos.push({nome:'Carlos', email:'carlos@gmail.com'})
listaContatos.push({nome:'João', email:'joao@gmail.com'})



const listarContatos = () => {
    var listaHTML = $('#lista-contatos');

    listaContatos.forEach(c => {
        var linha = document.createElement('tr');
        var colNome = document.createElement('td');
        var colEmail = document.createElement('td');
        console.log(c);
        $(colNome).html(c.nome);
        $(colEmail).html(c.email);
        $(linha).append(colNome).append(colEmail);
        $('#lista-contatos').append(linha);
    });
}

$(document).ready(()=>{
    console.log('Dashboard')
    if(!verificaLogin()){
        window.location.href = 'index.html';
    }

    listarContatos();
})