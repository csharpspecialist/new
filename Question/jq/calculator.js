



$(".calcButton").on('click', function() {
if($(this).attr('data-role')!='operator') {
$(".display").val($(".display").val()+$(this).val());
}
else
{
if($('.display').val()!='') {
	$(".display").val($(".display").val()+$(this).val());
}
}

});

$(".clear").on('click', function() {
$(".display").val('').  $('.grid-item').tooltip({show:{effect: "highlight", duration:800}});

});

$(".calculate").on('click', function() {
	var expression = $(".display").val();
	$(".display").val(eval(expression)).substr(0, 1) + '$' + this1.val().substr(2);

	});









