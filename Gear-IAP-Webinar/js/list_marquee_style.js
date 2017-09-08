/*global tau */
(function() {
	var page = document.getElementById("optionList"),
		elScroller,
		listHelper;

	/**
	 * pagebeforeshow event handler
	 * Do preparatory works and adds event listeners
	 */
	page.addEventListener( "pagebeforeshow", function() {
		var list;

		elScroller = page.querySelector(".ui-scroller");
		if (elScroller) {
			list = elScroller.querySelector(".ui-listview");
		}

		if (elScroller && list) {
			listHelper = tau.helper.SnapListMarqueeStyle.create(list, {
				marqueeDelay: 1000,
				marqueeStyle: "endToEnd"
			});

			tau.widget.SnapListview(list);

			elScroller.setAttribute("tizen-circular-scrollbar", "");
		}
	});

	/**
	 * pagehide event handler
	 * Destroys and removes event listeners
	 */
	page.addEventListener( "pagebeforehide", function() {
		if (listHelper) {
			listHelper.destroy();
			listHelper = null;
			if(elScroller) {
				elScroller.removeAttribute("tizen-circular-scrollbar");
			}
		}
	});

}());
