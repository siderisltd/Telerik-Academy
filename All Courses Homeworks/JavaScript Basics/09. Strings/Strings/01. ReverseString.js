/*01.Write a JavaScript function that reverses a string and returns it.*/

function reverseString(inputStr){
    var result = inputStr.split('');
    return result.reverse().join('');
}

console.log(reverseString('sample'));