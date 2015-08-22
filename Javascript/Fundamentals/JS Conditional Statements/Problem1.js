//Problem 1. Exchange if greater
var a,
	b,
	temp;

a = +(prompt('Enter a'));
b = +(prompt('Enter b'));

if (a > b) {
	temp = a;
	a = b;
	b = temp;
}
console.log(a + ' ' + b);