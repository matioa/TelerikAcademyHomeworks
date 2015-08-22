//Problem 5. Third bit
console.log('\nProblem 5');

var number = 5;
console.log(number + ' bit# 3: ' + checkThirdBit(number));
number = 8;
console.log(number + ' bit# 3: ' + checkThirdBit(number));
number = 0;
console.log(number + ' bit# 3: ' + checkThirdBit(number));
number = 15;
console.log(number + ' bit# 3: ' + checkThirdBit(number));
number = 5343;
console.log(number + ' bit# 3: ' + checkThirdBit(number));
number = 62241;
console.log(number + ' bit# 3: ' + checkThirdBit(number));

function checkThirdBit (number) {
	var result = (number>>3)&1;
	return result;
}