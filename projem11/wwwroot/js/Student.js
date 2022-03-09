
document.getElementById('EklemeFormu').addEventListener('submit', function () {
    document.getElementById('btnEkleme').innerHTML = 'Ekleniyor!';
    document.getElementById('btnEkleme').disabled = 'Ekleniyor!';
    
});

 
$('#NameAndSecondName').blur(function () {
    if ($(this).val() == '') {
        document.getElementById('lblNameAndSecondName').innerHTML = 'Boş Geçilemez!';
    }
    

});

$('#Mobile').blur(function () {
    if ($(this).val().substring(0,1) != '5') {
        document.getElementById('lblNameAndSecondName').innerHTML = 'Telefon 5 ile başlamalı!';
    }


});