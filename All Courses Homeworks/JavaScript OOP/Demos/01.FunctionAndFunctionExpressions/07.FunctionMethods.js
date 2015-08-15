function factorial(n) {
    if (n === 0) {
        return 1;
    }
    return n * factorial(n - 1);
}

var factorialNum = factorial(5);
console.log(factorialNum);
console.log(factorial(12));