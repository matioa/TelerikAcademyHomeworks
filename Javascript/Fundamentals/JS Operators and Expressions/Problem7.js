//Problem 7. Is prime
console.log('\nProblem 7 - Is Prime');

var number = 1;
writeResult();
number = 2;
writeResult();
number =3;
writeResult();
number=4;
writeResult();
number=9;
writeResult();
number=37;
writeResult();
number=97;
writeResult();
number=51;
writeResult();
number=-3;
writeResult();
number=0;
writeResult();


function isPrime(number) {
	if (number<2) {return false};

		for (var i=2; i<=number/2;i++) {
			if (number%i==0) {
				return false;
			}
		}
	return true;

}

function writeResult () {
	console.log(number + ' is prime? ' + isPrime(number));
}