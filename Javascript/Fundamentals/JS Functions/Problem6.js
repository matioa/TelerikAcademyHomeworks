//Problem 6. Larger than neighbours
console.log('\nProblem 6. Larger than neighbours');

var array = [3, 3, 2, 4, 5, 2, 3, 5, 2, 6, 34, 23, 2],
	elementX;

elementX = 4;
console.log(array);
console.log('element '+array[elementX]+ ' at position '+elementX+' is larger than neighbours? '+ isLargerThanNeighbours(elementX, array));

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
		if (array[index] > array[index-1]) {
			return true;
		} else {
			return false;
		}
	} else if (array[index] > array[index+1] && array[index] > array[index-1]) {
		return true;
	} else {
		return false;
	}
}