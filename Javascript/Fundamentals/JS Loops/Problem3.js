//Problem 3. Min/Max of sequence
console.log('\nProblem 3. Min/Max of sequence');


var numbers = [33504, 15963, 94073, 56791, 81681, 4058, 68912, 40887, 60265, 8954, 70585, 84429, 16066, 30210,
		51332, 58345, 30871, 3257, 50976, 11018, 32154, 23075, 3477, 11539, 59347, 60773, 53908, 78723, 46588, 7584
	],
	minNum = 0,
	maxNum = 0,
	i,
	len;


for (i = 0, len = numbers.length; i < len; i += 1) {
	if (numbers[maxNum] < numbers[i]) maxNum = i;
	if (numbers[i] < numbers[minNum]) minNum = i;
}


console.log('min: ' + numbers[minNum]);
console.log('max: ' + numbers[maxNum]);