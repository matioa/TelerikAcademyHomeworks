//Problem 7. The biggest of five numbers
var a,
	b,
	c,
	d,
	e,
	biggest;

console.log('\nProblem 7 - The biggest of five numbers');

a = 5;
b = 2;
c = 2;
d = 4;
e = 1;
findBiggest(a, b, c, d, e);
print();

a = -2;
b = -22;
c = 1;
d = 0;
e = 0;
findBiggest(a, b, c, d, e);
print();

a = -2;
b = 4;
c = 3;
d = 2;
e = 0;
findBiggest(a, b, c, d, e);
print();

a = 0;
b = -2.5;
c = 0;
d = 5;
e = 5;
findBiggest(a, b, c, d, e);
print();

a = -3;
b = -0.5;
c = -1.1;
d = -2;
e = -0.1;
findBiggest(a, b, c, d, e);
print();


function findBiggest(a, b, c, d, e) {
	if (a > b && a > c && a > d && a > e) {
		biggest = a;
	} else if (b > c) {
		if (b > d) {
			if (b > e) {
				biggest = b;
			} else {
				biggest = e;
			}
		} else {
			if (d > e) {
				biggest = d;
			} else {
				biggest = e;
			}
		}
	} else if (c > d) {
		if (c > e) {
			biggest = c;
		} else {
			biggest = e;
		}
	} else if (d > e) {
		biggest = d;
	} else {
		biggest = e;
	}
}

function print() {
	console.log(a + ' ' + b + ' ' + c + ' ' + d + ' ' + e + ' | biggest: ' + biggest);
}