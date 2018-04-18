



    $(".grid-item").click(function() {
        //shows how to choose 2 divs/selectors at one time
        // plus shows all the divs/tags listed...no matter what!!!
        //    $("div, p, h").hide();

         $('.grid-item').tooltip({show:{effect: "highlight", duration:800}});
        // $("div, p, h").hide();

        // alert("we r definitely Worthy!!!");
        } );


// $(document).ready(function (e)
// {

// $("button").change(function ()  {
//   var sum = 0;
// $("button[name=pressMe]").each (function (){
// sum = sum + parseFloat($(this).val());

// })
//    //     $("div[name=total]").val(sum);

//         $("input[name=totalSum]").val(sum);

// });

// })

















    $("#all").click(function() {
        //shows how to choose 2 divs/selectors at one time
        // plus shows all the divs/tags listed...no matter what!!!
            $("div, p, h").hide();

        } );

    $('#alert').click(function() {
//alert popup box!!!!
        alert("You cannot hide!!!");
    });








