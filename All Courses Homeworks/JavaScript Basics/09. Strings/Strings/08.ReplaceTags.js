/*Problem 8. Replace tags
Write a JavaScript function that replaces in a HTML document given as string all the
tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].*/

var text = '<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>';
function substringInText( text){
    var regex = new RegExp( '(<\/a>)' , 'mg');
    var secondRe = new RegExp('(<a href=)','mg');
    text = text.replace(regex,'[/URL]');
    text = text.replace(secondRe,'[URL');
    return text;
}

console.log(substringInText(text));

