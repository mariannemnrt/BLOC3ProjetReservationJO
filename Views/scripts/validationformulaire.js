// Scripts pour valider les champs du formulaire coté client
function validerMotDePasse() {
    var motDePasse = document.getElementById("UserPassword").value;

    // Utiliser une expression régulière pour valider le mot de passe
    var motif = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\\[\]{}|;:'"<>,.?/]).{8,}$/;

    if (!motif.test(motDePasse)) {
        alert("Le mot de passe doit contenir au moins 8 caractères, une majuscule, une minuscule, un chiffre et un caractère spécial.");
        return false;
    }
    return true;
}
var courriel = document.getElementById("UserEmail").value;
//fonction pour valider le courriel
function validerCourriel(courriel) {
   

    // Utiliser une expression régulière pour valider le courriel
    var motif = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;

    if (!motif.test(courriel)) {
        alert("Le courriel n'est pas valide.");
        return false;
    }
    return true;
}
//fonction pour valider la confirmation du mot de passe
function validerConfirmationMotDePasse() {
    var motDePasse = document.getElementById("password").value;
    var confirmationMotDePasse = document.getElementById("UserPasswordConfirm").value;

    if (motDePasse != confirmationMotDePasse) {
        alert("Les mots de passe ne correspondent pas.");
        return false;
    }
    return true;
}