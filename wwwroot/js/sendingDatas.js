// scripts pour envoyer les données au controller pour l'inscription

function sendingDatas() {

    // récupérer le nom de l'utilisateur 
    var UserName = document.getElementById("UserName").value;
    //récupérer le prénom de l'utilisateur 
    var UserFirstName = document.getElementById("UserFirstName").value;
    // récupérer le courriel de l'utilisateur
    var UserEmail = document.getElementById("UserEmail").value;
    // récupérer le mot de passe de l'utilisateur
    var UserPassword = document.getElementById("UserPassword").value;
    //Hasher le mot de passe de l'utilisateur 
    var UserPasswordHash = sha256(UserPassword);

    //générer le JSON pour transporter les données
    var data = {
        UserName: UserName,
        UserFirstName: UserFirstName,
        UserEmail: UserEmail,
        UserPasswordHash: User
    }
    //envoyer les données au controller pour l'inscription

        async function sendingDatas() {
            //générer le JSON pour transporter les données
            var data = {
                UserName: UserName,
                UserFirstName: UserFirstName,
                UserEmail: UserEmail,
                UserPasswordHash: User
            };
            

            try {
                const response = await fetch('/api/YourController/YourAction', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(data)
                });

                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }

                const result = await response.json();
                console.log('Success:', result);
            } catch (error) {
                console.error('Error:', error);
            }
        }
    
}


