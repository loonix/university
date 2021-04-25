// https://github.com/firebase/quickstart-js/blob/master/auth/email-password.html

function registaUtilizador() {

    console.log("Função invocada!");

    var email = document.getElementById('texto-email').value;
    var password = document.getElementById('texto-password').value;

    // console.log(email);

    if (email.length < 4) {
        alert('Introduza um email válido');
        return;
    }

    if (password.length < 4) {
        alert('Introuduza uma password');
        return;
    }


    // Create user with email and pass.
    firebase.auth().createUserWithEmailAndPassword(email, password)
        .then(() => {
            // sucesso
            alert("Utilizador criado com sucesso!")

            document.getElementById("texto-email").value = "";
            document.getElementById("texto-password").value = "";
        })
        .catch((error) => {
            // Handle Errors here.
            var errorCode = error.code;
            var errorMessage = error.message;

            console.log(errorCode);

            if (errorCode == 'auth/weak-password') {
                alert('Password fraca!');
            } else {
                if (errorCode == 'auth/email-already-in-use') {
                    alert('Email já existe!');
                } else {
                    alert(errorMessage);
                }
            }
            console.log(error);
        });
}


function validaUtilizador() {

    if (firebase.auth().currentUser) { // se já fez login
        firebase.auth().signOut();
    } else {
        var email = document.getElementById('texto-email').value;
        var password = document.getElementById('texto-password').value;

        console.log(email);
        console.log(password);

        if (email.length < 4) {
            alert('Introduza um email válido');
            return;
        }
        if (password.length < 4) {
            alert('Introuduza uma password');
            return;
        }

        // Sign in with email and pass.
        firebase.auth().signInWithEmailAndPassword(email, password)
            .then(() => {
                //alert("Sucesso!");
                $("#DivLogin").hide();
                $("#DivLugar").show();

                sessionStorage.setItem("login", true)
            })
            .catch(function (error) {
                // Handle Errors here.

                alert("Entrada negada!");
                sessionStorage.setItem("login", false)

                var errorCode = error.code;
                var errorMessage = error.message;
                if (errorCode === 'auth/wrong-password') {
                    alert('Wrong password.');
                } else {
                    alert(errorMessage);
                }
                console.log(error);

            });
    }

}