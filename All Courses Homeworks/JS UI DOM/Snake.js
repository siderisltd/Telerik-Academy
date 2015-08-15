//var img = new Image();
//
//img.onload = function() {
//    var ctx = document.getElementById('the-canvas').getContext('2d');
//    ctx.drawImage(img, 20, 150);
//};
//img.src = 'snake.gif';

var img_obj = {
    'source': 'snake.png',
    'current': 0,
    'total_frames': 16,
    'width': 50,
    'height': 50
};

var img = new Image();
img.onload = function () { // Triggered when image has finished loading.
    img_obj.source = img;  // we set the image source for our object.
};
img.src = 'snake.png';


function draw_anim(context, x, y, iobj) { // context is the canvas 2d context.
    if (iobj.source != null)
        context.drawImage(iobj.source, iobj.current * iobj.width, 0,
            iobj.width, iobj.height,
            x, y, iobj.width, iobj.height);
    iobj.current = (iobj.current + 1) % iobj.total_frames;
    // incrementing the current frame and assuring animation loop
}

function on_body_load() { // <body onload='on_body_load()'>...
    var canvas = document.getElementById('the-canvas');
    // <canvas id='canvasElement' width='320' height='200'/>
    var context = canvas.getContext("2d");

    setInterval((function (c, i) {
        return function () {
            draw_anim(c, 10, 10, i);
        };
    })(context, img_obj), 100);
}