//Problem 2. Correct brackets
console.log('\nProblem 2. Correct brackets');

var input1 =  '((a+b)/5-d)',
	input2 = ' )(a+b)) ';

console.log(input1+' => correct?: '+checkBrackets(input1));
console.log(input2+' => correct?: '+checkBrackets(input2));


function checkBrackets(text) {
	var isCorrect = true,
		brackets=0,
		i,
		len = text.length;

	for (i =0; i<len; i+=1) {
		if (text[i]==='(') {
			brackets +=1;
		}
		if (text[i]===')') {
			brackets -=1;
		}
		if (brackets<0) {
			isCorrect = false;
			break;
		}
	}
	return isCorrect;
}