//Problem 2. Multiplication Sign
var a,
	b,
	c,
	result;
a = prompt('enter a');
b = prompt('enter b');
c = prompt('enter c');


a = +a;
b = +b;
c = +c;

if (isNaN(a) || isNaN(b) || isNaN(c)) {
	result = 'Not valid input';
} else if (!a || !b || !c) {
	result = '0';
} else if (a < 0 && b < 0 && c < 0) {
	result = '-';
} else if (a < 0 || b < 0 || c < 0) {
	if ((a < 0 && b < 0) || (a < 0 && c < 0) || (b < 0 && c < 0)) {
		result = '+';
	} else {
		result = '-';
	}
} else {
	result = '+';
}

console.log('\nProblem 2 - Multiplication Sign');
console.log(a + '*' + b + '*' + c + '= ' + result);