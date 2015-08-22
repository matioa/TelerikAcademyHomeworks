//Problem 9. Point in Circle and outside Rectangle
console.log('\nProblem 9. Point in Circle and outside Rectangle');

x= 1;
y=4;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y));
x= 3;
y=2;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x= 0;
y=1;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x= 4;
y=1;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x= 2;
y=0;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x= 4;
y=0;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x= 2.5;
y=1.5;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x=3.5;
y=1.5;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y))
x=-100;
y=-100;
writeResult();
console.log(inCircle(x,y));
console.log(outsideRectangle(x,y));


function inCircle(x,y) {
	var circleX=1;
	var circleY=1;
	var circleRadius=3;

	return (x-circleX)*(x-circleX) + (y-circleY)*(y-circleY) <=circleRadius*circleRadius;
}

function outsideRectangle(x,y) {
	var rectangleMinX = -1;
	var rectangleMaxX=1;
	var rectangleMinY=-1;
	var rectangleMaxY=5;

	var result = ( x>=rectangleMinX && x<=rectangleMaxX) && (y>=rectangleMinY && y<=rectangleMaxY);
	return !result;
}

function writeResult () {
	var result = inCircle(x,y) && outsideRectangle(x,y);
	console.log('x:'+x+' y:'+y+' '+result);
}