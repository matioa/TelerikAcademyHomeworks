//Problem 3. Rectangle area
console.log('\nProblem 3');

var width = 3;
var height = 4;
console.log('width:'+width +', height:'+height+', area:'+area(width,height));
width = 2.5;
height=3;
console.log('width:'+width +', height:'+height+', area:'+area(width,height));
width = 5;
height=5;
console.log('width:'+width +', height:'+height+', area:'+area(width,height));

function area (width, height) {
	var result = width * height;
	return result
}