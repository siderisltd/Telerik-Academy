var stage = new Kinetic.Stage({
    container: 'container',
    width: 640,
    height: 480
});

var layer = new Kinetic.Layer();

var rect = new Kinetic.Rect({
    x: 0,
    y: 0,
    width: 640,
    height: 480,
    fill: '#D9E8FF',
    stroke: 'black'
});

var circle = new Kinetic.Circle({
    radius: 50,
    stroke: 'blue',
    x: 320,
    y: 240
});

var line = new Kinetic.Line({
    points: [320,0,320,480],
    stroke: 'black',
    fill: 'yellow'
});


layer.add(rect);
layer.add(circle);
layer.add(line);

stage.add(layer);

circle.remove();

layer.draw();


