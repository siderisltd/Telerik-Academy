/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element   //
  * The provided id does not select anything (there is no element that has such an id) //
  * Any of the function params is missing //
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

function solve (element, contents) {

  var validator = {
    checkUndefined: function (element) {
      if (typeof element === 'undefined') {
        throw new Error(element + ' cannot be undefined');
      }
    },
    checkIfString: function (element) {
      if (typeof element !== 'string'){
        throw new Error(element + ' must be string');
      }
    },
    checkIfNumberOrString: function (element) {
      if(typeof element !== 'number' && typeof element !== 'string')
      throw new Error(element + ' must be number or string');
    },
    checkIfItIsExistingDomElement: function(element) {
      if(document.getElementById(element) === null) {
        throw new Error(element + ' is not existing DOM element');
      }
    }
  };
   return (element, contents) {
    var args = [].slice.apply(arguments),
        domElement = args[0],
        contentArr = args[1];
    //check if every parameters are passed
    if(args.length <= 1){
      throw new Error('Cannot call this function without parameters or with only 1/2 params');
    }
    validator.checkIfString(domElement);
    validator.checkIfItIsExistingDomElement(domElement);

    contentArr.map(function (content){
      validator.checkIfNumberOrString(content);
    });

    var element = document.getElementById(domElement);

    while(element.firstChild){
      element.removeChild(element.firstChild);
    }

    var fragment = document.createDocumentFragment();
    contentArr.map(function(content){
      var div = document.createElement('div');
      div.innerHTML = content;
      fragment.appendChild(div);
    });

    element.appendChild(fragment);
  }
}


module.exports = solve;
//getEl('testId', ['1', '2', '3', '4']);