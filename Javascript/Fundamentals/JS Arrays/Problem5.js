//Problem 5. Selection sort
console.log('\nProblem 5. Selection sort');

var i,
	j,
	len,
	min,
	temp,
	removeIndex,
	array = [10, 58, 65, 2, 5, 84, 100, 54],
	unsortedArray = [];

unsortedArray = array.slice(0);

for (i = 0, len = array.length; i < len; i += 1) {
	min = array[i];
	minIndex = i;
	for (j = i+1; j < len; j += 1) {
		if (array[j] < min) {
			min = array[j];
			minIndex = j;
		}
	}
	if (min !== array[i]) {
		temp = array[i];
		array[i]=min;
		array[minIndex]=temp;
	}
}

console.log('unsorted: ' + unsortedArray);
console.log('sorted: ' + array);