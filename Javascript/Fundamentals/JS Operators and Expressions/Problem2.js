//Problem 2. Divisible by 7 and 
console.log('\nProblem 2');

numVariable = 3;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));
numVariable = 0;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));
numVariable = 5;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));
numVariable = 7;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));
numVariable = 35;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));
numVariable = 140;
console.log(numVariable+ ' is divided by 7 and 5? ' + dividedBy7Or5(numVariable));

function dividedBy7Or5 (number)	{
	var result = (number%7==0) && (number%5==0) ;
	return result;
}