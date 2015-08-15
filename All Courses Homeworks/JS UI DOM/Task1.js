var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.shadowBlur=20;
ctx.shadowOffsetX=20;
ctx.shadowColor="black";
ctx.fillStyle = 'orange';
ctx.strokeRect(200,100,250,250);
ctx.fillRect(200,100,250,250);

ctx.strokeStyle="blue";
ctx.strokeRect(10,100,50,50);


ctx.beginPath();


ctx.lineTo(500,100);
ctx.lineTo(600,100);
ctx.lineTo(600,40);
ctx.fillStyle = 'green';
ctx.fill();
ctx.closePath();

ctx.stroke();

ctx.beginPath();

ctx.moveTo(500,200);
ctx.lineTo(600,200);
ctx.lineTo(600,500);
ctx.fillStyle = 'red';
ctx.fill();

ctx.closePath();

ctx.stroke();


ctx.moveTo(180,300);

ctx.beginPath();      //tezi sa vajni i razgranichavat obektite

var circleX = 100,
    circleY = 300,
    circleRadius = 80;

ctx.arc(circleX, circleY, circleRadius,Math.PI ,2*Math.PI);

ctx.fillStyle = 'yellow';
ctx.fill();

ctx.closePath();
ctx.stroke();

ctx.moveTo(180,500);

ctx.beginPath();

var circleX = 100,
    circleY = 500,
    circleRadius = 80;

ctx.arc(circleX, circleY, circleRadius, 0,2*Math.PI);

ctx.fillStyle = 'purple';
ctx.fill();

ctx.closePath();
ctx.stroke();


//quadratic curve

ctx.beginPath();
ctx.moveTo(10, 10);      // zapochva ot poziciqta, na koqto e
var controlPoint = {      // tazi, koqto durpa obekta
    x:20,
    y:200
    },
    endPoint = {
      x:600,
      y:10
    };


//ctx.quadraticCurveTo(controlPoint.x, controlPoint.y, endPoint.x, endPoint.y);
ctx.strokeStyle = '#000';
ctx.stroke();

//Sample Animation with quadratic curve


var i = 0;
var j = 0;

function animateCurve(){
    var controlPoint = {
            x:20,
            y:200
        },
        endPoint = {
            x:600,
            y:10
        };
    ctx.moveTo(10, 10);

    ctx.quadraticCurveTo(controlPoint.x + i, controlPoint.y, endPoint.x, endPoint.y);
    ctx.lineWidth=1;
    ctx.strokeStyle= 'rgb(' + j.toString() + ',' + (i-4).toString() + ',' + j.toString()  + ')';
        ctx.stroke();
        i += 5;
        j += 1;
    window.requestAnimationFrame(animateCurve);
}
//animateCurve();