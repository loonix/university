function load() {
    var isLoggedIn = sessionStorage.getItem("login");
    divLogin = $("#DivLogin");
    divLugar = $("#DivLugar");
    isLoggedIn

    if (isLoggedIn) {
        divLogin.hide();
        divLugar.show();
        console.log('Is logged in');
    } else {
        console.log('Is not logged in');
        divLogin.show();
        divLugar.hide();
    }

}

function registaLugar() {
    console.log('aa');
}