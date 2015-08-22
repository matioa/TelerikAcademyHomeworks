//Problem 8. Trapezoid area
console.log('\nProblem 8 - Trapezoid area');

var a = 5;
var b = 7;
var h = 12;
writeResult();
a=2;
b=1;
h=33;
writeResult();
a=8.5;
b=4.3;
h=2.7;
writeResult();
a=100;
b=200;
h=300;
writeResult();
a=0.222;
b=0.333;
h=0.555;
writeResult();


function calculateArea(a,b,h) {
	var result = ((a+b)*h)/2;
	return result;
}

function writeResult () {
	console.log('a:'+a+' b:'+b+' h:'+h+' area:'+calculateArea(a,b,h))
}