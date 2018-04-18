

        $("#update").click(function() {
      /* this is to 1 specify the tag(img)
      2 choose the attribute(src) and 3 replace whatever
      is in the src with the last parameter...Otire3.jpg */
       $("img").attr("src","pics/0tire3.jpg");

    } );

    $("#rem").click(function() {
        /* this removes an attribue
in this case it would be the src attribute we r
trying to remove.  */

          $("img").removeAttr("src");
        } );


          $("#blast").mouseover(function() {
            /* on mouse over changes #talks text to
      to whats in the last parenthesis*/

              $("#talk").text("Get to The Choppa!!!");

            } );

    $("#blah").mouseover(function() {
        /* on mouse over changes #talks css below
    */
            $("#talk").css("color", "red");
        } );


$("#blah").hover(function() {
    /* hover takes 2 functions, function # 1  */
        $("#talk").css("color", "red");},

    function() {
    /* hover takes 2 functions, function # 2*/
        $("#talk").css("color", "green");
    } );


$("#blah").hover(function() {
    /* hover takes 2 functions, function # 1  */
        $("#jeden").fadeOut(2500);},

    function() {
    /* hover takes 2 functions, function # 2*/
        $("#jeden").fadeIn(2500);
    } );


$("#rem").hover(function() {
    /* hover takes 2 functions, function # 1  */
        $("#foto").show();},

    function() {
    /* hover takes 2 functions, function # 2*/
        $("#foto").hide();
    } );



          $('.alert').click(function() {
            //alert popup box!!!!
                    alert("Get to the choppa!!!");
                });



    $("#all").click(function() {
        //shows how to choose 2 divs/selectors at one time
        // plus shows all the divs/tags listed...no matter what!!!
            $("div, p, h").show();

        } );







