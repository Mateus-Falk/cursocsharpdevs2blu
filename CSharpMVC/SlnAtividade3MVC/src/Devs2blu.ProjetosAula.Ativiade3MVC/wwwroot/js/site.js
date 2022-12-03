$(document).ready(() => {
    $('#btn-search').click(() => {
        let nameInput = $('#input-search').val();
        $.ajax({
            url: `/table/search/${nameInput}`,
            dataType: 'html',
            success: (htmlPartialView) => {
                $('#content-list').html(htmlPartialView);
            }
        });
    })
});
