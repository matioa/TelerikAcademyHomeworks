//Problem 6. Quadratic equation
var a,
	b,
	c,
	discriminant,
	root1,
	root2;

console.log('\nProblem 6 - Quadratic equation');

a = 2;
b = 5;
c = -3;
quadraticEquation(a, b, c);

a = -1;
b = 3;
c = 0;
quadraticEquation(a, b, c);

a = -0.5;
b = 4;
c = -8;
quadraticEquation(a, b, c);

a = 5;
b = 2;
c = 8;
quadraticEquation(a, b, c);


function quadraticEquation(a, b, c) {
	console.log(a + 'x*x + ' + b + 'x + ' + c);
	discriminant = b * b - 4 * a * c;

	if (!discriminant) {
		root1 = -(b / (2 * a));
		console.log('One root: ' + root1);
	} else if (discriminant > 0) {
		root1 = (-b - Math.sqrt(discriminant)) / (2 * a);
		root2 = (-b + Math.sqrt(discriminant)) / (2 * a);
		console.log('Root 1: ' + root1);
		console.log('Root 2: ' + root2);
	} else {
		console.log('No real roots');
	}

	console.log('\n');
}