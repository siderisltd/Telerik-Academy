/*** Created by Alex on 5/23/2015.*/
/*Problem 4. Lexicographically smallest
Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.*/

function slDoc(){
    var max = '',
        min = new Array(10001).join('a'),
        result = '';


    for(var property in document){
        if(property.length > max.length){
            max = property;
        }

        if(property.length < min.length){
            min = property;
        }
    }
console.log( result = 'In document \r\nMin:' + min +'\r\nMax:'+ max);

}


function slWin(){
    var max = '',
        min = new Array(10001).join('a'),
        result = '';


    for(var property in window){
        if(property.length > max.length){
            max = property;
        }

        if(property.length < min.length){
            min = property;
        }
    }
    console.log( result = 'In window \r\nMin:' + min +'\r\nMax:'+ max);
}

function slNav(){
    var max = '',
        min = new Array(10001).join('a'),
        result = '';


    for(var property in navigator){
        if(property.length > max.length){
            max = property;
        }

        if(property.length < min.length){
            min = property;
        }
    }
    console.log( result = 'In navigator \r\nMin:' + min +'\r\nMax:'+ max);
}


