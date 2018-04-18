



    $("input").change(function() {

        let sum = 0;

        $("input[name=gid]").each(function() {

            sum = sum + parseInt($(this).val());
        })

        $("input[name=topgid]").val(sum);


                } );






    $("#smooth").click(function() {

let sum = 150;



            $("#comp").text(sum);

        } );



        $(".price").blur(function (){
            var sumData =0;
                $(".price").each(function (){
                    if($(this).val() != "" || ($(this).val() !=0))
                    {
            sumData +=parseFloat($(this).val());
                    }

            } );

            $("#sum").html(sumData);

            })


//     $("#all").click(function() {
//         //shows how to choose 2 divs/selectors at one time
//         // plus shows all the divs/tags listed...no matter what!!!
//             $("div, p, h").hide();

//         } );

//     $('#alert').click(function() {
// //alert popup box!!!!
//         alert("You cannot hide!!!");
//     });







