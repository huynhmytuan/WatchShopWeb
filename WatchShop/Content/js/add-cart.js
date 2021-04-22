//Add Cart
$(function () {
	$(".add-to-cart").click(function () {
		pid = $(this).attr("data-id");
		$.ajax({
			url: "/Cart/Add",
			data: { id: pid },
			success: function (response) {
				$("#nn-cart-count").html(response.Count);
				$("#nn-cart-total").html(response.Total);
			}
		});

		// hieu ung bay vao gio
		cssfly = ".fly-effect {background:url(?);background-size:100% 100%;}";
		src = $("#i" + pid).attr("src");
		newcssfly = cssfly.replace("?", src);
		$("#cart-fly").html(newcssfly);

		options = { to: "#nn-cart-image", className: "fly-effect" };
		$("#i" + pid).effect("transfer", options, 500, function () { });
	});
});