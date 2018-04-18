

    $("#what").click(function() {

        $("#one").css("color", "blue");     
        
    } ); 

    $("#meta").click(function() {
//notice the curly braces below...we need them if we r going to 
//choose multiple styles!!!!
        $("#two").css({"color": "green", "font-size":"25px", "border" : "solid 3px red"});     
        
    } ); 

    $("#textaroo").click(function() {
        /*changes the text inside the p tags on the page to
         whatever you place inside of your p tags!!!  You must put some type of html tag inside of the parenthesis below!!!!
        */
        $("p").html("<p> Hello dog  </p>");   
                
            } ); 

    $("#change").click(function() {
        /*changes the text inside the selector on the page to
            whatever parameter you pass to the .text function below!!!  No need to put any html tags inside of the .text function!!
        */
        $("#three").text(" Here kitty kitty!!! ");   
                
            } );

    $("#chain").click(function() {
        /*below we chaing 3 diff functions together.
        notice the 60000 has "" around it!!!
        */
        $("#four").text(" The Pirates are gone!!! ").
        css("color", "blue").fadeOut("60000");   
                
            } ); 

        $("#classy").click(function() {
            /*adds a class named para,which is in the second.css file, to the first paragraph on the page!!!!
            */
            $("p:first").addClass("para");   
                    
                } ); 

    $("#remclassy").click(function() {
        /*Obviously toggles the first h3 class on and off!!!!
        */
        $("h3:first").toggleClass("para");   
                
            } ); 
    

        