(function($) {
	$(document).ready(function() {
		$(".photos ul").cycle({
			fx: 'fadeZoom',
			speed: 'slow'
		});
		
		var sliders = $(".photo-slider ul");
		sliders.flexisel({
			visibleItems: 5,
			animationSpeed: 1000,
			autoPlay: true,
			autoPlaySpeed: 3000,            
			pauseOnHover: false,
			enableResponsiveBreakpoints: true,
			responsiveBreakpoints: { 
				portrait: { 
					changePoint:480,
					visibleItems: 1
				}, 
				landscape: { 
					changePoint:640,
					visibleItems: 2
				},
				tablet: { 
					changePoint:768,
					visibleItems: 3
				}
			}
		}).magnificPopup({
			delegate: 'a',
			type: 'image',
			closeOnContentClick: true,
			closeBtnInside: false,
			tLoading: 'Loading image #%curr%...',
			mainClass: 'mfp-img-mobile',
			gallery: {
				enabled: true,
				navigateByImgClick: true,
				preload: [0,1] // Will preload 0 - before current, and 1 after the current image
			},
			image: {
				verticalFit: true,
				tError: '<a href="%url%">The image #%curr%</a> could not be loaded.',
				titleSrc: function(item) {
					var img = $("img", item.el);
					return img.attr('alt') + '<small>' + img.data('photographer') + '</small>';
				}
			},
			zoom: {
				enabled: true,
				duration: 300
			},
			callbacks: {
				open: function() {
					sliders.flexisel("pause");
				},
				close: function() {
					sliders.flexisel("pause");
				}
			}
		});
		
		$(".spinner").spinner({
			min: 0,
			max: 100,
			page: 5,
			incremental: false
		});
		
		$("a", ".basket-button-panel").button();
		$(".content input[type=submit]").button();
		$(".search-box button[type=submit]").button({
			icons: {
				primary: "ui-icon ui-icon-carat-1-e"
			},
			text: false
		});
		$(".addToBasket").click(function( event ) {
			event.preventDefault();
			$.post('add-to-basket.asp', $(this).closest("form").serialize())
				.done(function (data) {
					//custom_alert("Item was added to your basket", "Success");
					// update the menu item "MyBasket" with new item count
					alert("Success");
				})
				.fail(function (data) {
					//custom_alert("Failed to add item to your basket. Please try again later.", "Error", "alert");
					alert("Failed");
				});
		});
		
		$(".marquee").marquee({
			duration: 15000,
			pauseOnHover: true,
			duplicated: true
		});
		
		$(".basket").DataTable({
			ordering: false,
			info: false,
			"lengthMenu": [[5, 10, 15, 20, 25, -1], [5, 10, 15, 20, 25, "All"]]
		});
	});
	
	function custom_alert(output_msg, title_msg, title_icon)
	{
		if (!title_icon)
			title_icon = 'info';
		
		if (!title_msg)
			title_msg = 'Alert';
		
		if (!output_msg)
			output_msg = 'No Message to Display.';
		
		$("<div></div>").html(output_msg).dialog({
			title: title_msg,
			resizable: false,
			modal: true,
			dialogClass: "no-close",
			autoOpen: true,
			buttons: {
				text: "Ok",
				click: function() 
				{
					$( this ).dialog( "close" ).dialog( "destroy" );
				}
			},
			open: function(event, ui){
                $(this).closest('.ui-dialog-titlebar').prepend('<span class="ui-icon ui-icon-' + title_icon + '"></span>');
            }
		});
	}
})(jQuery);

window.fbAsyncInit = function() {
	FB.init({
		appId      : '1782802615279919',
		xfbml      : true,
		version    : 'v2.5'
	});
};
(function(d, s, id){
	var js, fjs = d.getElementsByTagName(s)[0];
	if (d.getElementById(id)) {return;}
	js = d.createElement(s); js.id = id;
	js.src = "//connect.facebook.net/en_GB/sdk.js";
	fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));

!function(d,s,id){var js,fjs=d.getElementsByTagName(s)[0],p=/^http:/.test(d.location)?'http':'https';if(!d.getElementById(id)){js=d.createElement(s);js.id=id;js.src=p+"://platform.twitter.com/widgets.js";fjs.parentNode.insertBefore(js,fjs);}}(document,"script","twitter-wjs");

(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
})(window,document,'script','//www.google-analytics.com/analytics.js','ga');
ga('create', 'UA-68997488-1', 'auto');
ga('send', 'pageview');