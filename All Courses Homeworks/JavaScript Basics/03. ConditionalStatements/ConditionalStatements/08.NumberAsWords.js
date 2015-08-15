/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 8. Number as words
Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.*/

var numberAsDigit = 791;

var numberLength = numberAsDigit.toString().length;
var shouldAdd = true;
var result = '';

//Main logic
if(numberLength == 3){
    if (shouldAdd === true) {
        var hundreds = ((numberAsDigit / 100) % 10) | 0;
        oneNine(hundreds);
        result += ' ' + 'Hundred' + ' ';
        shouldAdd = true;
    }

    var decimals = ((numberAsDigit / 10) % 10) | 0;
    var singles = ((numberAsDigit % 10) | 0);

    if(decimals === 0 && singles === 0){
        shouldAdd = false;
    }
    var numberWithoutHundreds = ((numberAsDigit % 100) | 0);

    if (shouldAdd === true && decimals !== 0) {
        twentyNinety(numberWithoutHundreds);
    }

    if (shouldAdd === true) {
        tenTwenty(numberWithoutHundreds);
    }

    if (shouldAdd === true) {
        if(decimals !== 0){
        twentyNinety(decimals);
        }
        result += ' ';
        oneNine(singles);
    }
}
if(numberLength == 2){

    if (shouldAdd === true){
    tenTwenty(numberAsDigit);
    }

    if (shouldAdd === true) {
        twentyNinety(numberAsDigit);
        result += ' ';
    }

    if (shouldAdd === true) {
        var decimals = ((numberAsDigit / 10) % 10) | 0;
        twentyNinety(decimals);
        result += ' ';
        var singles = (numberAsDigit % 10) | 0;
        oneNine(singles);
    }
}
if(numberLength == 1){
    oneNine(numberAsDigit);
}

//printingResult
result = result.trim();
result = result.split(/\s+/);
result = result.join(' ');
console.log(result);

//Functions
function oneNine (digit){
    switch(digit){
        case 1: shouldAdd = false; shouldAdd = false; result += 'One';   break;
        case 2: shouldAdd = false; shouldAdd = false; result += 'Two';   break;
        case 3: shouldAdd = false; shouldAdd = false; result += 'Three'; break;
        case 4: shouldAdd = false; shouldAdd = false; result += 'Four';  break;
        case 5: shouldAdd = false; shouldAdd = false; result += 'Five';  break;
        case 6: shouldAdd = false; shouldAdd = false; result += 'Six';   break;
        case 7: shouldAdd = false; shouldAdd = false; result += 'Seven'; break;
        case 8: shouldAdd = false; shouldAdd = false; result += 'Eight'; break;
        case 9: shouldAdd = false; shouldAdd = false; result += 'Nine';  break;
    }
};
function tenTwenty (num){
    switch(num){
        case 10: shouldAdd = false; result += 'Ten';  break;
        case 11: shouldAdd = false; result += 'Eleven';   break;
        case 12: shouldAdd = false; result += 'Twelve';   break;
        case 13: shouldAdd = false; result += 'Thirteen'; break;
        case 14: shouldAdd = false; result += 'Fourteen';  break;
        case 15: shouldAdd = false; result += 'Fifteen';  break;
        case 16: shouldAdd = false; result += 'Sixteen';   break;
        case 17: shouldAdd = false; result += 'Seventeen'; break;
        case 18: shouldAdd = false; result += 'Eighteen'; break;
        case 19: shouldAdd = false; result += 'Nineteen';  break;
        case 20: shouldAdd = false; result += 'Twelve';  break;
    }
}
function twentyNinety (digit){
    switch(digit){

        case 2: shouldAdd = false; result += 'Twenty';  break;
        case 3: shouldAdd = false; result += 'Thirty';   break;
        case 4: shouldAdd = false; result += 'Forty';   break;
        case 5: shouldAdd = false; result += 'Fifty'; break;
        case 6: shouldAdd = false; result += 'Sixty';  break;
        case 7: shouldAdd = false; result += 'Seventy';  break;
        case 8: shouldAdd = false; result += 'Eighty';   break;
        case 9: shouldAdd = false; result += 'Ninety'; break;

        case 20: shouldAdd = false; result += 'Twenty';  break;
        case 30: shouldAdd = false; result += 'Thirty';   break;
        case 40: shouldAdd = false; result += 'Forty';   break;
        case 50: shouldAdd = false; result += 'Fifty'; break;
        case 60: shouldAdd = false; result += 'Sixty';  break;
        case 70: shouldAdd = false; result += 'Seventy';  break;
        case 80: shouldAdd = false; result += 'Eighty';   break;
        case 90: shouldAdd = false; result += 'Ninety'; break;
    }
};
function hundrets (num){
    switch(num){
        case 100: shouldAdd = false; result += 'Twenty';  break;
        case 200: shouldAdd = false; result += 'Twenty';  break;
        case 300: shouldAdd = false; result += 'Thirty';   break;
        case 400: shouldAdd = false; result += 'Forty';   break;
        case 500: shouldAdd = false; result += 'Fifty'; break;
        case 600: shouldAdd = false; result += 'Sixty';  break;
        case 700: shouldAdd = false; result += 'Seventy';  break;
        case 800: shouldAdd = false; result += 'Eighty';   break;
        case 900: shouldAdd = false; result += 'Ninety'; break;
    }
};
