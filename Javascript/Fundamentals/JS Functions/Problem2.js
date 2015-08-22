//Problem 2. Reverse number
console.log('\nProblem 2. Reverse number');

var number = 2988.34,
	something = [],
	reversedNumber;

console.log('number: '+number);
console.log('reversed number: '+reverseDigits(number));


function reverseDigits(number) {
	var result,
		i,
		len,
		digitArray = [],
		reversedArray = [];

	digitArray = (number.toString()).split('');
	len = digitArray.length;

	for (i = 0; i < len; i+=1) {
		reversedArray.push(digitArray.pop());
	}
	result = +(reversedArray.join(''));

	return result;
}