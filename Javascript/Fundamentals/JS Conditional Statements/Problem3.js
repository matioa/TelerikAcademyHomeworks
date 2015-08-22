//Problem 3. The biggest of Three
var a,
	b,
	c,
	biggest;

a = 5;
b = 12;
c = 5;

if (a > b && a > c) {
	biggest = a;

} else if (b > c && b > a) {
	biggest = b;
} else {
	biggest = c;
}

console.log('\nProblem 4 - The biggest of Three');
console.log('biggest number is: ' + biggest);