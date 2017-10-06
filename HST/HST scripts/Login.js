
function Login() {

    var loginRequest = {
        "userName": document.getElementById("userName").value,
        "password": document.getElementById("password").value,
        "robot": document.getElementById("robot").checked
    };


    $.ajax({
        type: "POST",
        contentType: "application/json;charset =utf-8",
        data: JSON.stringify(loginRequest),
        url: "/Login/Login",
        success: function (response) {

            if (response.result === "Redirect")
                window.location = response.url;

          //  if (data.redirect) {
                // data.redirect contains the string URL to redirect to
              //  window.location.replace(data.redirect);
          //  }
        },
        error: function() {
            alert("unable to send login request");
        }
    });
}