



//enhances the default tooltip, makes tooltip text larger.
//for whichever element you specify inside 1st set of ()
$('li').tooltip();

//make sure you have {} to use this JQ Element
$('img').tooltip({track:true});


//make sure you have {} to use this JQ Element
$('button').tooltip({show:{effect: "pulsate", duration:800}});

//make sure you have {} to use this JQ Element
$('h2').tooltip({show:{effect: "bounce", duration:800}});

//make sure you have {} to use this JQ Element
$('div').tooltip({show:{effect: "highlight", duration:800}});

//make sure you have {} to use this JQ Element
$('b').tooltip({show:{effect: "blind", duration:800}});

//make sure you have {} to use this JQ Element
//cannot get this one to work!!!!
$('h3').tooltip({show:{effect: "fadeIn", duration:900}},
{hide:{effect: "blind", duration:900}}
);

            $('.alert').click(function() {
                //alert popup box!!!!
                        alert("Get to the choppa!!!");
                    });


        $("#all").click(function() {
            //shows how to choose 2 divs/selectors at one time
            // plus shows all the divs/tags listed...no matter what!!!
                $("div, p, h").show();

            } );









