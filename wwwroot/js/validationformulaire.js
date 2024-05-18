// Scripts pour valider les champs du formulaire coté client

// le nom d'utilisateur et le prénom doivent contenir au max 30 caractères 

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

function validerCourriel(courriel) {
   
    var courriel = document.getElementById("UserEmail").value;
    // teste le format de l'email à l'aide d'une expression régulière 

    var motif = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;


    if (!motif.test(courriel)) {
        alert("Le courriel n'est pas valide.");
        return false;
    };
    return true;

}
//fonction pour valider la confirmation du mot de passe
function validerConfirmationMotDePasse() {
    var motDePasse = document.getElementById("UserPassword").value;
    var confirmationMotDePasse = document.getElementById("UserPasswordConfirm").value;

    if (motDePasse != confirmationMotDePasse) {
        alert("Les mots de passe ne correspondent pas.");
        return false;
    }
    return true;
}

//fonction pour vérifier que tous les champs sont complétés et rendre le bouton cliquable 
function validerChamps() {
    var nom = document.getElementById("UserName").value;
    var prenom = document.getElementById("UserFirstName").value;
    var courriel = document.getElementById("UserEmail").value;
    var motDePasse = document.getElementById("UserPassword").value;
    var confirmationMotDePasse = document.getElementById("UserPasswordConfirm").value;

    if (nom != "" && prenom != "" && courriel != "" && motDePasse != "" && confirmationMotDePasse != "") {
        document.getElementById("validateCreation").disabled = false;
    }
}

//fonction pour valider le formulaire connection et rendre le bouton cliquable 
function validerChampsConnection() {
    var nom = document.getElementById("UserName").value;
    var password = document.getElementById("UserPassword").value;

    if (nom != "" && motDePasse != "") {
        document.getElementById("connect").disabled = false;

    }
}

    //fonction pour envoyer le lien de double authentification 
    function doubleAuth() {
        var maDiv = document.getElementById('lienDoubleAuthentification');

        maDiv.style.display = 'block';
    }

