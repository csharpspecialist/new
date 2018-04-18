


    $("#update").click(function() {
        /*changes the text inside the li tags on the page to
         whatever you place inside of your p tags!!!  You must put some type of html tag inside of the parenthesis below!!!!
        */
        $("li").each (function(){
// the .each 1 line above is a foreach loop
            $(this).html("<p> Dogs Are Bullies!!! </p>");
//we could use the word'this'or li in the line above.
                  });

            });


$('#slup').click(function() {
    //sliding #kitty ul up!!!!
            $("#kitty").slideUp();
        });


    $('#sldown').click(function() {
    //sliding #kitty ul down!!!!
    $("#kitty").slideDown();
            });


    $('#slToggle').click(function() {
        //sliding #kitty ul up or down!!!!
        $("#kitty").slideToggle();
                });

//thats all the code below to use the datepicker
    $('#dates').datepicker();


//expands the month choice to 3 months in html window
    $('#dates2').datepicker({numberOfMonths:3});

//changeMonth puts dropdown month picker inside of the datepicker. Boolean option
$('#dates3').datepicker({changeMonth:true});

//changeMonth puts dropdown month picker inside of the datepicker + shows # of the week of year. Boolean option for both
$('#dates4').datepicker({changeMonth:true, showWeek: true});

//showOtherMonths shows you the days of prev + next months in this months calendar
$('#dates5').datepicker({showOtherMonths:true});

//chooses min & max dates that can be chosen
$('#dates6').datepicker({minDate:new Date(2018, 0, 15), maxDate:new Date(2018, 6,15)});

//shows 2 buttons on bottom of calendar
$('#dates7').datepicker({showButtonPanel: true});

//custom button text in buttons on bottom of calendar
$('#dates8').datepicker({showButtonPanel:true, currentText:"Never", closeText: "Close Me"});

//places custom word after date on/in top of calendar.
//make sure to put a space after first " !!!!
$('#dates9').datepicker({yearSuffix: " Whatever!!"});

//enhances the default tooltip, makes tooltip text larger.
//for whichever element you specify inside 1st set of ()
$('button, li').tooltip();



            $('.alert').click(function() {
                //alert popup box!!!!
                        alert("Get to the choppa!!!");
                    });


        $("#all").click(function() {
            //shows how to choose 2 divs/selectors at one time
            // plus shows all the divs/tags listed...no matter what!!!
                $("div, p, h").show();

            } );









