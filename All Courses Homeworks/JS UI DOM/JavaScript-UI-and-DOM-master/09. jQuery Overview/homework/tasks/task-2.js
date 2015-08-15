/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
        if (typeof selector !== 'string') {
            throw new Error(selector + ' must be string');
        }

        var $domElement = $(selector);

        if (!($domElement instanceof jQuery)) {
            throw new Error($domElement + ' is not instance of jQuery');
        }

        function showContent($element) {
            var $previousElement = $element.prev();

            if ($previousElement.hasClass('button')) {
                return;
            }

            while (true) {

                if ($previousElement.hasClass('content')) {
                    var $grangPreviousElement = $previousElement.prev();

                    if ($grangPreviousElement.hasClass('content')) {
                        $previousElement = $grangPreviousElement;
                    }
                    else {
                        $previousElement.show();
                        break;
                    }

                }
            }

        }

        function hideContent($element) {

            var $previousElement = $element.prev();

            if ($previousElement.hasClass('button')) {
                return;
            }

            while (true) {

                if ($previousElement.hasClass('content')) {
                    var $grangPreviousElement = $previousElement.prev();

                    if ($grangPreviousElement.hasClass('content')) {
                        $previousElement = $grangPreviousElement;
                    }
                    else {
                        $previousElement.hide();
                        break;
                    }

                }
            }

        }

        var childs = $domElement.children();

        for (var i = 0; i < childs.length; i++) {

            var $currentChild = $(childs[i]);
            if ($currentChild.hasClass('button')) {
                $currentChild.html('hide');
                $currentChild.click(function (ev) {
                    if ($(this).html() === 'hide') {
                        hideContent($(this));
                        $(this).html('show')
                    }
                    else {
                        showContent($(this));
                        $(this).html('hide');
                    }
                }), false;
            }
        }
    };
}

//module.exports = solve;