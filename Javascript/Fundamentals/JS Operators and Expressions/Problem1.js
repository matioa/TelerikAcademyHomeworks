//Problem 1. Odd or Even
console.log('\nProblem 1');
var numVariable = 3;
console.log(numVariable+ ' is Odd? ' + oddNumbers(numVariable));
numVariable = 2;
console.log(numVariable+ ' is Odd? ' + oddNumbers(numVariable));
numVariable = -2;
console.log(numVariable+ ' is Odd? ' + oddNumbers(numVariable));
numVariable = -1;
console.log(numVariable+ ' is Odd? ' + oddNumbers(numVariable));
numVariable = 0;

function oddNumbers (number)	{
	var result = (number%2!=0) ;
	return result;
}