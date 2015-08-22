//Problem 4. Maximal increasing sequence
console.log('\nProblem 4. Maximal increasing sequence')

var inputArray,
	i,
	len,
	counter = 0,
	maxSequence = 0,
	startIndex,
	maxSequenceArray = [];

inputArray = [3, 2, 3, 4, 2, 2, 4];

for (i = 0, len = inputArray.length; i < len - 1; i += 1) {
	counter += 1;
	if (inputArray[i] >= inputArray[i + 1]) {
		counter = 1;
	}
	if (maxSequence < counter) {
		maxSequence = counter;
		startIndex = inputArray[i + 1] - counter;
	}
}

maxSequenceArray = inputArray.splice(startIndex, maxSequence);
console.log(maxSequenceArray);