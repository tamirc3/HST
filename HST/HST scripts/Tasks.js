
function AddTask() {

    var addTaskRequest = {
        "assignedTo": document.getElementById("assignedTo").value,
        "description": document.getElementById("description").value,
        "status": document.getElementById("status").value
    };


    $.ajax({
        type: "POST",
        contentType: "application/json;charset =utf-8",
        data: JSON.stringify(addTaskRequest),
        url: "/Tasks/AddTaskForUser",
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