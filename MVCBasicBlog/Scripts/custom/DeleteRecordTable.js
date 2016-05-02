function Delete(url, id) {
    $.ajax({
        url: url +id,
        type: "POST",
        success: function (result) {
          
            $("#a_" + id).fadeOut();
        },
        error: function (msg) {
        
            console.log(msg)
        }
    })
}