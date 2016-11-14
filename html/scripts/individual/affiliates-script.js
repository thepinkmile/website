(function($){
	$(document).ready(function() {
		$(".login").dialog({
			dialogClass: "no-close",
			position: {
				my: "center",
				at: "center",
				of: ".content-box"
			},
			draggable: false,
			closeOnEscape: false,
			resizable: false,
			width: 350,
			height: 205,
			buttons: {
				Login: doLogin
			}
		});
		
		$(".marquee").marquee({
			duration: 15000,
			pauseOnHover: true,
			duplicated: true
		});
		
		$(".content button[type=submit]").button();
		var deleteButtons = $(".profile.document-list button.delete").button();
		/*deleteButtons.click(function() {
				var self $(this);
				var action = self.data("action");
				var method = self.data("method");
				if (method === "post") {
					// do post
				} else {
					// do get
				}
			});*/
		
		$("textarea.wysiwyg").htmlarea({
			toolbar: [
				["html"],
				["increasefontsize", "decreasefontsize"],
				["bold", "italic", "underline"],
				["h1", "h2", "h3", "h4", "h5", "h6"],
				["justifyleft", "justifycenter", "justifyright"],
				["orderedlist", "unorderedlist"],
				["horizontalrule"],
				["link", "unlink"], ["image"],
				["indent", "outdent"],
			],
			css: "../styles/jHtmlArea.Editor.min.css"
		});
		$("textarea.wysiwyg-small").htmlarea({
			toolbar: [
				["html"],
				["bold", "italic", "underline"]
			],
			css: "../styles/jHtmlArea.Editor.min.css"
		});
	});
	
	function doLogin() {
		$(".login form").submit();
	}
})(jQuery);

(function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
(i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
})(window,document,'script','//www.google-analytics.com/analytics.js','ga');
ga('create', 'UA-68997488-1', 'auto');
ga('send', 'pageview');