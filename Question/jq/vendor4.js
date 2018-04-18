


$(function() {
    $("#firstNo, #secondNo").on("keydown keyup", totalsum);


	function totalsum() {
	$("#totalsum").val(Number($("#firstNo").val()) + Number($("#secondNo").val()));
	$("#substraction").val(Number($("#firstNo").val()) - Number($("#secondNo").val()));
	}
});



// $(document).ready(function()  {


//     sum();

// $("#num1", "#num2").on("keydown keyup", function() {
// sum();
// });
// });

// function sum() {
//  var num1 = document.getElementById('num1').value;
//  var num2 = document.getElementById('num2').value;

//  var result = parseFloat(num1)+parseFloat(num2);

// if(!isNaN(result)){
// document.getElementById("done").value = result;
//     }
//     // else{
//     // alert("Please choose an item..Ya big dummy!!")
//     //   }
// }




//     $("#all").click(function() {
//         //shows how to choose 2 divs/selectors at one time
//         // plus shows all the divs/tags listed...no matter what!!!
//             $("div, p, h").hide();

//         } );

//     $('#alert').click(function() {
// //alert popup box!!!!
//         alert("You cannot hide!!!");
//     });







