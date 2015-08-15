/*Problem 5. nbsp
 Write a function that replaces non breaking white-spaces in a text with &nbsp;*/

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
function substringInText( text){
    var regex = new RegExp( ' ' , 'mg');
    return text.replace(regex,'&nbsp');
}

console.log(substringInText(text));

