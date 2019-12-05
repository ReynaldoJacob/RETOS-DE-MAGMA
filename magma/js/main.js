//*Funcion para mantener la barra de menu*//

$(document).ready(function(){
	var altura = $('.menu').offset().top;
	

	$(window).on('scroll', function(){

		if($(window).scrollTop() > altura){

				$('.menu').addClass('menu-fixed');
				$('.men-fixed').slideDown('slow');




		}else{

			$('.menu').removeClass('menu-fixed');

		}
	});

});


$(document).ready(function(){
  $(".seleccionado").mouseenter(function(){
    $("#panel").slideDown("slow");
    
  });
});

$(document).ready(function(){
  $(".seleccionado").mouseleave(function(){
    $("#panel").slideUp("slow");
  });
});





