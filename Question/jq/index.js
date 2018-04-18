

$(document).ready(function () {

    $("#button").click(function() {

        $("#right").hide();     
        
    } ); 

    //shows how to choose 2 divs/selectors at one time
        $("#slow, #new").hide();  


$("#what").click(function() {
//make sure you put the # sign inside the  ( ) !!!!!!
    $("#left").hide();  
    
} ); 



$("#show").click(function() {

    $("#slow, #new").show();  
    
} ); 

$("#disappear").click(function() {
//shows how to choose 2 divs/selectors at one time
    $("#slow, #new").hide();  
    
} ); 

$("#flo").click(function() {
    //shows how to choose 1st paragraph tag
        $("p:first").hide();  
        
    } ); 

        
    $("#last").click(function() {
        //shows how to choose 2 divs/selectors at one time
            $("div:last").hide();  
            //could also do div:first
            
        } ); 

        $("#even").click(function() {
            //hides the even divs starting at 0
                $("div:even").hide();  
                //could also do div:odd
                
            } ); 

        $("#not").click(function() {
            //hides everyting BUT the right + center divs
                $("div:not(#right, #center)").hide();  
                //could also do div:first
                
            } ); 


            $("#yellow").click(function() {
                //hides everthing in a paragraph that contains
                //the word yellow which is in 1st paragraph!!!
                    $("p:contains('Yellow')").hide();  
                    
                } ); 
       
            $("#bold").click(function() {
                //hides everthing in a paragraph that contains
                //the bold tag which is the..2nd paragraph!!!
                    $("p:has('b')").hide();  
                    
                } );
                
            $("#span").click(function() {
                //hides everthing in a paragraph that contains
                //the li tag which is empty!!!
                    $("li:empty").hide();  
                    
                } ); 

    
    $("#all").click(function() {
        //shows how to choose 2 divs/selectors at one time
            $("div, p").show();  
            
        } ); 


}); 
