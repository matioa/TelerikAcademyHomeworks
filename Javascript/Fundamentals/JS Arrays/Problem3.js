//Problem 3. Maximal sequence
console.log('\nProblem 3.  Maximal sequence')

var inputArray,
	i,
	j,
	len,
	counter = 1,
	maxSequence = 0,
	maxElement,
	startIndex,
	maxSequenceArray = [];

inputArray = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

for (i = 0, len = inputArray.length; i < len - 1; i += 1) {
	for (j = i + 1; j < len; j += 1) {
		if (inputArray[i] == inputArray[j]) {
			console.log(inputArray[i] + ' ' + inputArray[j] + ' :' + (inputArray[i] == inputArray[j]));
			counter += 1;
		} else {
			break;
		}
	}
	if (maxSequence < counter) {
		maxSequence = counter;
		maxElement = inputArray[i];
		startIndex = i;
		counter = 0;
	};
};

console.log(inputArray);
console.log('Element ' + maxElement + ' is repeated ' + maxSequence + ' times.');
maxSequenceArray = inputArray.splice(startIndex-1, maxSequence);
console.log(maxSequenceArray);