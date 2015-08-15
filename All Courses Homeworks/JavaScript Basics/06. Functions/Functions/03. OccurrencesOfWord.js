/**
 * Created by Alex on 5/31/2015.
 */

var text = 'This is my text that repeat some word a couple of times. This text is designed to meet all the text requirements. The Text is awesome.',
    word = 'text';
// 3 times 1 Upper = 4 times

function wordCountInText(text, word){
    var words = text.split(/\s*[\s,.!? ]\s*/),
        timesRepeat = 0;

    for(var wo in words){
        if(words[wo].toUpperCase() === word.toUpperCase()){ //case unsensitive
            timesRepeat += 1;
        }
    }

    return timesRepeat;
}

console.log(wordCountInText(text,word));