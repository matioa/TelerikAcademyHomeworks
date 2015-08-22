//Problem 3. Occurrences of word
console.log('\nProblem 3. Occurrences of word');

var text,
	word;

text = 'I opened the letter. The letter was opened. Opening the letter was by me.';
word = 'the';
console.log(word + ': ' + findWord(word, text, false) + ' times');



function findWord(word, text, caseSensitive) {
	var i,
		len,
		counter = 0,
		result,
		textArray = [];

	if (!caseSensitive) {
		word = word.toLowerCase();
		text = text.toLowerCase();
	}

	textArray = text.split(' ');

	for (i = 0, len = textArray.length; i < len; i += 1) {
		if (word == textArray[i]) {
			counter += 1;
		}
	}
	return counter;
}