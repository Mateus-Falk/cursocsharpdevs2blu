
addEventListener('load',(e) => {
    $('#aba1').style.display = 'block';
    $('#aba2').style.display = 'none';
    $('#aba3').style.display = 'none';
    $('#aba4').style.display = 'none';

    $('#menu-aba1').addEventListener('click', (e) => {
        $('#aba1').style.display = 'block';
        $('#aba2').style.display = 'none';
        $('#aba3').style.display = 'none';
        $('#aba4').style.display = 'none';
    })
    $('#menu-aba2').addEventListener('click', (e) => {
        $('#aba1').style.display = 'none';
        $('#aba2').style.display = 'block';
        $('#aba3').style.display = 'none';
        $('#aba4').style.display = 'none';
    })
    $('#menu-aba3').addEventListener('click', (e) => {
        $('#aba1').style.display = 'none';
        $('#aba2').style.display = 'none';
        $('#aba3').style.display = 'block';
        $('#aba4').style.display = 'none';
    })
    $('#menu-aba4').addEventListener('click', (e) => {
        $('#aba1').style.display = 'none';
        $('#aba2').style.display = 'none';
        $('#aba3').style.display = 'none';
        $('#aba4').style.display = 'block';
    })
})



function $(querySelector) {
    return document.querySelector(querySelector);
}