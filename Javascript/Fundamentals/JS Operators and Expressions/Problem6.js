//Problem 6. Point in Circle
console.log('\nProblem 6');

var x =0;
var y = 1;
var r = 5;

writeResult();
x=-5;
y=0;
writeResult();

x=-4;
y=5;
writeResult();

x=1.5;
y=-3;
writeResult();

x=-4;
y=5;
writeResult();

x=100;
y=-30;
writeResult();

x=0;
y=0;
writeResult();

x=0.2;
y=-0.8;
writeResult();

x=0.9;
y=-4.93;
writeResult();

x=2;
y=2.655;
writeResult();

function isInsideCircle (x, y, r) {
	var result = (x*x + y*y) <= r*r;
	return result;
}

function writeResult () {
	console.log('x:' +x +' y:' +y + '  inside:'+isInsideCircle(x,y,r));
}