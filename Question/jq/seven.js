



/*make sure you have {} to use this JQ Element
        */
$('img').tooltip({track:true});


    $('.alert').click(function() {
        //alert popup box!!!!
                alert("Get to the choppa!!!");
            });


$("#all").click(function() {
    //shows how to choose 2 divs/selectors at one time
    // plus shows all the divs/tags listed...no matter what!!!
        $("div, p, h").show();

    } );


    $('#panel').accordion();


function nice(){

    let num1 = document.getElementById("val1").value;

    let num2 = document.getElementById("val2").value;



var c = (num1 * num2);
// return c;
// document.getElementById('wall').innerHTML = nice(4,10);
 document.getElementById('wall').innerHTML = c;
}

function timing(){
    let num1 = document.getElementById("val1").value;

    let num2 = document.getElementById("val2").value;
var c = (num1 * num2);
 return c;
// document.getElementById('wall').innerHTML = nice(4,10);
 document.getElementById('wall').innerHTML = c;
}

function fizz () {


    let num1 = document.getElementById("val1").value;
if( val1 % 3 == 0 && val1 % 5 == 0)
document.getElementById('wall').innerHTML = "";

}


