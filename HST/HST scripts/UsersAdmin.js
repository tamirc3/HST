function AddUser() {

    var addUserRequest = {
        "userName": document.getElementById("userName").value,
        "password": document.getElementById("password").value,
        "userType": document.getElementById("userType").value
    };


    $.ajax({
        type: "POST",
        contentType: "application/json;charset =utf-8",
        data: JSON.stringify(addUserRequest),
        url: "/UserAdmin/AddUser",
        success: function (response) {

            if (response.result === "Redirect")
                window.location = response.url;

            //  if (data.redirect) {
            // data.redirect contains the string URL to redirect to
            //  window.location.replace(data.redirect);
            //  }
        },
        error: function () {
            alert("unable to ad task request");
        }
    });
}