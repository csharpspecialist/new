

    $("#fadeout").click(function() {
        /*Fades out whichever element to dissapear from the page.
        */
        $("#uno").fadeOut("2000");

            } );

    $("#fadein").click(function() {
        /*In order to user this function the element has to be hidden on the page from the start!!!
        */
        $("#dos").fadeIn(2000);

            } );

    $("#fadeover").click(function() {
        //fades out and fades in...only once. Must press button over and over
       $("#tres").fadeOut(2000).fadeIn(2000);

            } );

    $("#fadeamount").click(function() {
        //Toggles the fade on and off continuously
        $("#tres").fadeToggle(2000);

            } );

            $("#appending").click(function() {
                //Adds an element onto the page at the end
                // of the
            $("#quatro").append('<span id="mix"> NO WAY!!! </span>');
                    } );

    $("#prepping").click(function() {
        //Adds an element onto the page at the end
        // of the
    $("#cinco").prepend('<span id="purple"> Dude Whatever!!! </span>');

            } );

            $("#after").click(function() {
                //Adds an element onto the page at the end of that block of code
            $("#cinco").after('<span id="gold"> No More Mr.Nice Guy!!! </span>');

                    } );


    $("#before").click(function() {
        //Adds an element onto the page at the beginning of that block of code
    $("#cinco").before('<span id="nice"> Warriors come out and play!!! </span>');

            } );

            $("#repl").click(function() {
                //replaces the bold text in an element with whatever text you put inside of your replacewith parameter.
            $("#seis b").replaceWith('<span id="nice">Remember...You drew first blood!!! </span>');
        } );


        $("#rem").click(function() {
            //removes whatever is inside the parenthesis
            //does not take any params
        $("i").remove();
    } );








    $("#all").click(function() {
        //shows how to choose 2 divs/selectors at one time
        // plus shows all the divs/tags listed...no matter what!!!
            $("div, p, h").show();

        } );

    $('#alert').click(function() {
//alert popup box!!!!
        alert("You cannot hide!!!");
    });














