var scripts = $('#scripts').clone();


/* # Functions*/
const getPagina = (url, target) => {
    $.ajax({
        url: `_html/${url}`,
        dataType: 'html',
        success: (pagina) => {
            $(target).html(pagina);
        }
    });
}