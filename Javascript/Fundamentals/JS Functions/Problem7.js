//Problem 7. First larger than neighbours
console.log('\nProblem 7. First larger than neighbours');

var i,
	j,
	len,
	randomNumber,
	array = [];

for (i = 0; i < 10; i += 1) {
	randomNumber = (Math.random() * 10) | 0;
	array.push(randomNumber);
}

console.log(array);
console.log('First element that is larger is at position ' + firstLarger(array));



function firstLarger(array) {
	for (j = 0, len = array.length; j < len; j += 1) {
		if (isLargerThanNeighbours(j, array)) {
			return j;
		}
	}
	return -1;
}


function isLargerThanNeighbours(index, array) {
	var len,
		result;

	len = array.length;
	if (index < 0 || index > len) {
		return false;
	} else if (!index) {
		if (array[index] > array[index + 1]) {
			return true;
		} else {
			return false;
		}
	} else if (index == len) {
		if (array[index] > array[index - 1]) {
			return true;
		} else {
			return false;
		}
	} else if (array[index] > array[index + 1] && array[index] > array[index - 1]) {
		return true;
	} else {
		return false;
	}
}