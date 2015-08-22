//Problem 5. nbsp
console.log('\nProblem 5. nbsp');

var text,
	changedText,
	template = / /g;

text = 'This- -will- -replace- -whitespace- ';
changedText = text.replace(template,'&nbsp');

console.log(changedText);
