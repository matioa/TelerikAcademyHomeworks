//Problem 2. Lexicographically comparison
var i,
	j,
	len1,
	len2,
	counter = 0,
	array1 = ['b', 'a', 't', 'm', 'a', 'n'],
	array2 = ['b', 'a', 't', 'g', 'i', 'r', 'l'];


for (i = 0, len1 = array1.length; i < len1; i += 1) {
	for (j = 0, len2 = array2.length; j < len2; j += 1) {
		if (array1[i] == array2[j]) {
			counter += 1;
		}
	}
}

console.log('\nProblem 2.  Lexicographically comparison')
console.log(array1);
console.log(array2);

if (!counter) {
	console.log('Array1 and Array2 does not contain equal characters.');
} else {
	console.log('Array1 and Array2 contain ' + counter + ' characters in common.');
};