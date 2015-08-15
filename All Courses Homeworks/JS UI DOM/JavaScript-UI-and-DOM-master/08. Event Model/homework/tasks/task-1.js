/* globals $ */

/* 

 Create a function that takes an id or DOM element and:


 */

function solve(element) {

    var validator = {
        checkUndefined: function (element) {
            if (typeof element === 'undefined') {
                throw new Error(element + ' cannot be undefined');
            }
        },
        checkIfString: function (element) {
            if (typeof element !== 'string') {
                throw new Error(element + ' must be string');
            }
        },
        checkIfNumberOrString: function (element) {
            if (typeof element !== 'number' && typeof element !== 'string')
                throw new Error(element + ' must be number or string');
        },
        checkIfItIsExistingDomElement: function (element) {
            if (document.getElementById(element) === null) {
                throw new Error(element + ' is not existing DOM element');
            }
        }
    };

    return function (selector) {
        validator.checkUndefined(selector);
        validator.checkIfString(selector);
        validator.checkIfItIsExistingDomElement(selector);

        var element = document.getElementById(selector);

        var nodes = element.childNodes;
        var specificChildNodes = [];

        function clickedOnButtonElement(ev) {

            function checkUpSiblings(prevSibling, displayStyle){
                var grandSibling = prevSibling.previousElementSibling;

                if (grandSibling.className === 'content') {
                    prevSibling = grandSibling;
                    checkUpSiblings(prevSibling);
                }
                else{
                    prevSibling.style.display = displayStyle;
                }
            }

            var prevSibling = this.previousElementSibling;

            if (this.innerHTML === 'show') {
                this.innerHTML = 'hide';

                if (prevSibling.className === 'button') {
                    return;
                }
                else if (prevSibling.className === 'content') {
                    checkUpSiblings(prevSibling, '');
                }
            }

            else if (this.innerHTML === 'hide') {
                this.innerHTML = 'show';


                if (prevSibling.className === 'button') {
                    return;
                }

                else if (prevSibling.className === 'content') {
                    checkUpSiblings(prevSibling, 'none');
                }
            }
        }

        for (var i = 0; i < nodes.length; i += 1) {
            if (nodes[i].className === 'button' || 'content') {
                specificChildNodes.push(nodes[i]);

                if (nodes[i].className === 'button') {
                    nodes[i].innerHTML = 'hide';
                    nodes[i].addEventListener('click', clickedOnButtonElement, false);
                }
            }
        }


    };
}

//module.exports = solve;