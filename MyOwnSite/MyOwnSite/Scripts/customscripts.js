function UpdateTest() {
    console.log("TEST");
    $("#Posts").hide();
};



function PopUpCreate() {
    var options = { "backdrop": "static", keyboard: true };
    $.ajax({
        type: 'GET',
        url: '/Post/Create',
        contentType: "application/json; charset=utf-8",

        success: function (data) {
            
            $('#myModalContent').html(data);
            $('#myModal').modal(options);
            $('#myModal').modal('show');

        },
        error: function () {
            alert("Dynamic content load failed.");
        }

        


    });
    $("#close").click(function () {
        $('#myModal').modal('hide');
    });


};

function CreatePost() {
    event.preventDefault();
    var data = $("form").serialize();
   
    
    
    $.ajax({
        type: 'POST',
        url: '/api/POSTAPI',
        //url: '/POST/Create',
        data: data,
        success: function () { UpdateMain(), $('#myModal').modal('hide'); }

});



};

//function UpdateTest() {

//    $("#Posts").modal('hide');
//};

function UpdateMain() {
    $.ajax({
        type: 'GET',
        url: '/post/PartialPost',
        contentType: "application/json; charset=utf-8",
        success: function(res) { $('.table').html(res) }
    });


};

