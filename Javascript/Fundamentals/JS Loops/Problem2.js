//Problem 2. Numbers not divisible
var number,
	maxNumber;

console.log('\nProblem 2. Numbers not divisible');

maxNumber = 25;

for (number = 1; number <=maxNumber; number+=1) {
	if (!(number%3) && !(number%7)) {
	} else {
		console.log(number);
	}
}