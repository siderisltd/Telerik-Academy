/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
    var $domElement = $(selector);
    var $ul = $('<ul />').addClass('items-list');

    if(typeof count === 'number' && count <= 1) {
      throw new Error('Count parameter must be integer greater or equal to 1')
    }

    if($domElement.length === 0){
      throw new Error('There is no element with this selector : ' + selector)
    }

    if(typeof count === 'undefined' || isNaN(parseInt(count))){
      throw new Error('Count is eather missing or it is not convertable to Number');
    }

    for (var i = 0; i < count; i++) {
      var $li = $('<li />')
          .addClass('list-item')
          .html('List item #' + i);
      $ul.append($li);
    }
    $domElement.append($ul);
  }

}

//solve('gosho',3);
//module.exports = solve;