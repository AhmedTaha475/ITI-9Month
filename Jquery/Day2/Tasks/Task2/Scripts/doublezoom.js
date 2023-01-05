(function ($) {
    $.fn.doublezoom = function () {
        /* define working variables */
        var stop1 = false,
            stop2 = true;
        var img = $(this);

        /* Create lens: */
        var jLens = jQuery("<div>", {
            class: "overlay",
            title: "Lens overlay",
        });
        /* Insert lens: */
        img.parent().parent().append(jLens);

        /* get the result DIV images */
        var resultLeft = img
            .parent()
            .parent()
            .parent()
            .find(".doublezoom-landing-left");
        var resultRight = img
            .parent()
            .parent()
            .parent()
            .find(".doublezoom-landing-right");

        /* Calculate the ratio between result DIV and lens: */
        /* Left ratios */
        var cxl = resultLeft.outerWidth() / jLens.outerWidth();
        var cxr = resultRight.outerWidth() / jLens.outerWidth();
        /* Right ratios */
        var cyl = resultLeft.outerHeight() / jLens.outerHeight();
        var cyr = resultRight.outerHeight() / jLens.outerHeight();
        
        /* set the result DIV images */
        resultLeft.css("background-image", "url(" + img.attr("src") + ")");
        resultRight.css("background-image", "url(" + img.attr("src") + ")");
        
        /* set the dimensions of the result DIV images */
        resultLeft.css(
            "background-size",
            img.width() * cxl + "px " + img.height() * cyl + "px"
        );
        resultRight.css(
            "background-size",
            img.width() * cxr + "px " + img.height() * cyr + "px"
        );

        /* Add event listeners for mousemove and click events */
        $(this).mousemove(function (e) {
            move(e);
        });

        $(jLens).mousemove(function (e) {
            move(e);
        });

        $(this).click(function (e) {
            trottle(e);
        });

        $(jLens).click(function (e) {
            trottle(e);
        });

        /* mouse move */
        function move(e) {
            /* calculare x and y for lens movement*/
            var x = e.pageX - img.offset().left - jLens.width() / 2;
            var y = e.pageY - img.offset().top - jLens.height() / 2;

            /* set lens border limits */
            if (x < 0) {
                x = 0;
            }
            if (y < 0) {
                y = 0;
            }
            if (x > img.width() - jLens.outerWidth()) {
                x = img.width() - jLens.outerWidth();
            }
            if (y > img.height() - jLens.outerHeight()) {
                y = img.height() - jLens.outerHeight();
            }

            /* Set the position of the lens: */
            jLens.css({ top: y, left: x });

            /* handle clicks */
            if (!stop1) {
                resultLeft.css(
                    "background-position",
                    "-" + x * cxl + "px -" + y * cyl + "px"
                );
            }
            if (!stop2) {
                resultRight.css(
                    "background-position",
                    "-" + x * cxr + "px -" + y * cyr + "px"
                );
            }
        }

        /* handle stop'n'go on mouse click */
        function trottle(e) {
            if (stop2) {
                stop1 = !stop1;
            }
            if (stop1) {
                stop2 = !stop2;
            }
        }
    };
})(jQuery);
