//Problem 4. Sort 3 numbers
var a,
	b,
	c,
	n1,
	n2,
	n3;

a = prompt('enter a');
b = prompt('enter b');
c = prompt('enter c');


a = +a;
b = +b;
c = +c;

if (a > b && a > c) {
	n1 = a;
	if (b > c) {
		n2 = b;
		n3 = c;
	} else {
		n2 = c;
		n3 = b;
	}
} else if (b > c && b > a) {
	n1 = b;
	if (a > c) {
		n2 = a;
		n3 = c;
	} else {
		n2 = c;
		n3 = a;
	}
} else {
	n1 = c;
	if (b > a) {
		n2 = b;
		n3 = a;
	} else {
		n2 = a;
		n3 = b;
	}
}

console.log('\nProblem 4 - Sort 3 numbers');
console.log(n1 + ' ' + n2 +' '+ n3);