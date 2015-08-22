//Problem 5. Appearance count
console.log('\nProblem 5. Appearance count');

var array = [3,3,2,4,5,2,3,5,2,6,34,23,2],
	counter;

console.log(countAppearance(2,array));


	function countAppearance(number, array) {
		var i,
			len,
			result=0;

		number =+number;
		for (i=0, len=array.length; i<len; i+=1) {
			if (number === array[i]) {
				result+=1;
			}
		}
		return result;
	}