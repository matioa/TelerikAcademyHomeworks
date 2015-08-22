//Problem 4. Third digit
console.log('\nProblem 4');

var number = 5;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 701;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 1732;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 9703;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 877;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 777877;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));
number = 9999799;
console.log(number + ' - Third digit 7? ' + thirdDigit(number));

function thirdDigit(number) {
	var thirdDigit = ((number/1000 - ((number/1000)|0))*10)|0;
	var result = thirdDigit % 7 == 0;
	return result;
}