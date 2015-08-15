/*Problem 10. Find palindromes
Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

var text = '"ABBA", "lamal", "exe", "sos", "not", "palindrome", "test"';

console.log('palindromes are :' + extractPalindromes(text));

function extractPalindromes(text){
    var endResult = [];
    var result = text.split(' ');

    for(var w in result) {
        var word = result[w];
        var palindrome = true;
        var cycleLength = (word.length - 1) / 2;

        for (var i = 0; i < cycleLength; i++) {
            var fDigit = word[i];
            var eDigit = word[word.length - 2 - i];
            if (fDigit !== eDigit) {
                palindrome = false;
            }
        }
        if (palindrome) {
            endResult.push(word);
        }
    }

    return endResult;
}