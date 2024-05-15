// fichier javascript pour transmettre le choix de l'event à la page controller et demander affichage de la page correspondante des offres

document.getElementById('XXX').onclick = function () {
    // Récupérer la valeur de l'élément sélectionné
    var event = this;
    // Récupérer l'id de l'élément cliqué
    var eventId = event.id;
}
// transmettre le choix de l'event au controller 
$.ajax({
    url: '/Offres/EventSelection',
    type: 'POST',
    data: { id: eventId},
},
    error: function (xhr, status, error) {
    console.log('error');
})
