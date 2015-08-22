//Problem 3. Sub-string in text
console.log('\nProblem 3. Sub-string in text');

var text,
	searchedWord;

text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
searchedWord = 'in';

console.log(countOccurrence(searchedWord, text));


function countOccurrence(word, text) {
	var counter = 0,
		i,
		len = text.length,
		characters = word.length;

var textLower = text.toLowerCase();
var wordLower = word.toLowerCase();

	for (i = 0; i < len; i += 1) {
		if (textLower.substr(i, characters) === wordLower) {
			counter += 1;
			i += characters - 1;
		}
	}
	return counter;
}