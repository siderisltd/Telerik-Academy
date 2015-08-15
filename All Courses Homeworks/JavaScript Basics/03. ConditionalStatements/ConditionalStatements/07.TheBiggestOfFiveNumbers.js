/**
 * Created by Alex on 5/22/2015.
 */
/*Problem 7. The biggest of five numbers
 Write a script that finds the greatest of given 5 variables. Use nested if statements.*/

var a = 3,
    b = 2,
    c = 3 ,
    d = 0,
    e = 2;
if (a === b || a === c || a === d || a === e || b === c || b === d || b === e || c === d || c === e || d === e) {
    if (a === b) {
        if (a > c && a > d && a > e) {
            console.log(a);
        }
        if (c > a && c > b && c > d && c > e) {
            console.log(c);
        }
        if (d > a && d > b && d > c && d > e) {
            console.log(d);
        }
        if (e > a && e > b && e > c && e > d) {
            console.log(e);
        }
    }
    if (a === c) {
        if (a > b && a > d && a > e) {
            console.log(a);
        }
        if (b > a && b > c && b > d && b > e) {
            console.log(b)
        }
        if (d > a && d > b && d > c && d > e) {
            console.log(d);
        }
        if (e > a && e > b && e > c && e > d) {
            console.log(e);
        }
    }
    if (a === d) {
        if (a > b && a > c && a > e) {
            console.log(a);
        }
        if (b > a && b > c && b > d && b > e) {
            console.log(b);
        }
        if (c > a && c > b && c > d && c > e) {
            console.log(c);
        }
        if (e > a && e > b && e > c && e > d) {
            console.log(e);

        }
        if (a === e) {
            if (a > b && a > c && a > d ) {
                console.log(a);
            }
            if (b > a && b > c && b > d && b > e) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
            if (e > b && e > c && e > d) {
                console.log(e);
            }
        }
        if (b === c) {
            if (a > b && a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > d && b > e) {
                console.log(b);
            }
            if (c > a && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
            if (e > a && e > b && e > c && e > d) {
                console.log(e);
            }
        }
        if (b === d) {
            if (a > b && a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > c && b > e) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > c && d > e) {
                console.log(d);
            }
            if (e > a && e > b && e > c && e > d) {
                console.log(e);
            }
        }
        if (b === e) {
            if (a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > c && b > d) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
        }
        if (c === d) {
            if (a > b && a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > c && b > d && b > e) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
            if (e > a && e > b && e > c && e > d) {
                console.log(e);
            }
        }
        if (c === e) {
            if (a > b && a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > c && b > d && b > e) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
            if (e > a && e > b && e > c && e > d) {
                console.log(e);
            }
        }
        if (d === e) {
            if (a > b && a > c && a > d && a > e) {
                console.log(a);
            }
            if (b > a && b > c && b > d && b > e) {
                console.log(b);
            }
            if (c > a && c > b && c > d && c > e) {
                console.log(c);
            }
            if (d > a && d > b && d > c && d > e) {
                console.log(d);
            }
            if (e > a && e > b && e > c && e > d) {
                console.log(e);
            }
        }

    }
}
if (a > b && a > c && a > d && a > e) {
    console.log(a);
}
if (b > a && b > c && b > d && b > e) {
    console.log(b);
}
if (c > a && c > b && c > d && c > e) {
    console.log(c);
}
if (d > a && d > b && d > c && d > e) {
    console.log(d);
}
if (e > a && e > b && e > c && e > d) {
    console.log(e);
}
