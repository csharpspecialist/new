


// $(".form-group").on("input", ".prc", function () {

// let totalSum = 0;

// $(".form-group .prc").each(function() {
// let inputVal = $(this). val();
// if($.isNumeric(inputVal)) {
//     totalSum += parseFloat(inputVal);
// }
// else if($.isNumeric(inputVal < 0)) {
//     totalSum += parseFloat(inputVal);
// }

// } );
// $("#result").text(totalSum);
//   });



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





var totalAmt =function () {

var sum = 0;

$(".amount").each(function () {

var num = $(this).val().replace(',','');

if(num != 0)
{
sum += parseFloat(num);

}
  });

$("#allAmt").val(sum.toFixed(2));

  }

$(".amount").keyup(function () {
totalAmt();
} );



    $("#all").click(function() {
        //shows how to choose 2 divs/selectors at one time
        // plus shows all the divs/tags listed...no matter what!!!
            $("div, p, h").hide();

        } );

    $('#alert').click(function() {
//alert popup box!!!!
        alert("You cannot hide!!!");
    });







