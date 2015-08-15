//Problem 1. Format with placeholders
//Write a function that formats a string. The function should have placeholders, as shown in the example
//Add the function to the String.prototype

String.prototype.format = function (obj) {
    var text = this;

    for (var property in obj) {
        var regExp = new RegExp('#{' + property + '}', 'g');
        text = text.replace(regExp, obj[property]);
    }
    return text;
}

var options = { name: 'John' };
var sentance = 'Hello, there! Are you #{name}?';

console.log(sentance.format(options));