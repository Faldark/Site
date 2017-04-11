function UpdateTest() {
    console.log("TEST");
    $("#Posts").hide();
};

$(function () {
    $(".ui-dialog").dialog({
        autoOpen: false,
        modal: true,
        beforeClose: function () {
            $("form").trigger("reset");
        }
        
        
    });

});



function FunctionForm() {

    var data = $("form").serialize();
    
            $.ajax({
                type: 'POST',
                url: '/api/POSTAPI',
                data: data,
                success: function () { UpdateMain(), $("#createdialog").dialog('close'); }
            });
}
   



//function PopUpCreate(url) {
//    var options = { "backdrop": "static", keyboard: true };
//    $.ajax({
//        type: 'GET',
//        url: url,
//        contentType: "application/json; charset=utf-8",

//        success: function (data) {

//            $('#myModalContent').html(data);
//            $('#myModal').modal(options);
//            $('#myModal').modal('show');

//        },
//        error: function () {
//            alert("Dynamic content load failed.");
//        }

//    });
//    $("#close").click(function () {
//        $('#myModal').modal('hide');
//    });


//};

//function PopUpGeneral(url, id) {
//    var options = { "backdrop": "static", keyboard: true };
//    console.log(id);
//    $.ajax({
//        type: 'GET',
//        url: url,
//        data: { 'id': id },
//        success: function (data) {

//            $('#myModalContent').html(data);
//            $('#myModal').modal(options);
//            $('#myModal').modal('show');

//        },
//        error: function () {
//            alert("Dynamic content load failed.");
//        }




//    });
//    $("#close").click(function () {
//        $('#myModal').modal('hide');
//    });


//};


function CreatePost() {


    var data = $("form").serialize();
    console.log("From Second");
    

        $.ajax({
            type: 'POST',
            url: '/api/POSTAPI',
            //url: '/POST/Create',
            data: data,
            success: function () { UpdateMain(), $('#myModal').modal('hide'); }

    });



};


function UpdateMain() {
    $.ajax({
        type: 'GET',
        url: '/post/PartialPost',
        contentType: "application/json; charset=utf-8",
        success: function (res) { $('.table').html(res) }
    });


};

