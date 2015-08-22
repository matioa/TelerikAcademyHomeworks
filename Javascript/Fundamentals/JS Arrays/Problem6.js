//Problem 6. Most frequent number
console.log('\nProblem 6. Most frequent number');

var i,
	j,
	len,
	counter,
	maxCounter = 0,
	maxRepeatedEl;
array = [4, 1, 1, 4, 3, 4, 4, 1, 2, 4, 9, 3];

for (i = 0, len = array.length; i < len; i += 1) {
	counter = 1;
	for (j = i + 1; j < len; j += 1) {
		if (array[i] === array[j]) {
			counter += 1;
		}
	}
	if (maxCounter < counter) {
		maxCounter = counter;
		maxRepeatedEl = array[i];
	}
}

console.log(array);
console.log(maxRepeatedEl + ' (' + maxCounter + ' times)');