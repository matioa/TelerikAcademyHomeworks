/// <reference path="C:\Users\Martin\Documents\Visual Studio 2013\Projects\Javascript\JS UI\TestingJSUI\Test\canvas-vsdoc.js" />

var canvas = document.getElementById('myCanvas').getContext('2d');
canvas.lineWidth = '2';
canvas.fillStyle = 'rgba(255,0,0,.5)';
canvas.fillRect(100, 50, 25, 100);
canvas.strokeRect(100, 50, 25, 100);

canvas.strokeRect(130, 50, 25, 100);

//canvas.beginPath();
//canvas.moveTo(50, 50);
//canvas.lineTo(250, 50);
//canvas.lineTo(250, 150);
//canvas.lineTo(50, 150);
//canvas.closePath();
//canvas.stroke();
