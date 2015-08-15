/*Write a function that finds all the prime numbers in a range
It should return the prime numbers in an array
It must throw an Error if any of the range params is not convertible to Number
It must throw an Error if any of the range params is missing*/

function primeNumbersInRange(start, end){
    var args = [].slice.apply(arguments);
    if(args[0] === undefined || args[1] === undefined){
        throw new Error('Some of the vaaarguments is missing');
    }
    var isConvertable = args.every(function(number){
        number = parseInt(Number);
        return typeof number == 'number';
    });

    if(!isConvertable){
        throw new Error('the arguments should be convertible to int')
    }
    var arr = [];
    for (var i = start; i <= end; i++) {
        if(isPrime(i)){
            arr.push(i);
        }
    }
    function isPrime(number){
        if (number == 1 || number <= 0){
            return false;
        }
        var numSqrt = Math.sqrt(number);
        var isPrime = true;

        for (var i = 2; i <= numSqrt; i++) {
            if(i === number){
                continue;
            }

            if(number % i === 0) {
                isPrime = false;
                return isPrime;
            }
        }
        return isPrime;
    }
    return arr;
}

module.exports = primeNumbersInRange;
//console.log(primeNumbersInRange("1","5"));