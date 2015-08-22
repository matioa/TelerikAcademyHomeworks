//Problem 10. Find palindromes
console.log('\nProblem 10. Find palindromes');

var array = ['ABBA', 'lamal', 'exe', 'sixty'],
	j,
	len = array.length;

for (j = 0; j < len; j += 1) {
	console.log(array[j]+' '+isItPalindrome(array[j]));
}

function isItPalindrome(text) {
	var i,
		len = text.length / 2;

	for (i=0; i<len;i+=1) {
		if (text[i]!==text[text.length-i-1]) {
			return false;
		}
	}
	return true;
}