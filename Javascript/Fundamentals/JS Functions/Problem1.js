//Problem 1. English digit
console.log('\nProblem 1. English digit');

var i,
	number,
	word;

for (i = 0; i<10; i+=1) {
	number = (Math.random()*10000)|0;
	console.log(number+' last digit is: '+findLastDigit(number));
}

function findLastDigit(number) {
	var lastDigit,
		result;

	lastDigit = number % 10;

	switch(lastDigit) {
		case 0: result = 'zero'; break;
		case 1: result = 'one'; break;
		case 2: result = 'two'; break;
		case 3: result = 'three'; break;
		case 4: result = 'four'; break;
		case 5: result = 'five'; break;
		case 6: result = 'six'; break;
		case 7: result = 'seven'; break;
		case 8: result = 'eight'; break;
		case 9: result = 'nine'; break;
	}
	return result;
}