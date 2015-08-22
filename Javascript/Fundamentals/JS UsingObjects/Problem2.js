//Problem 2. Remove elements
console.log('\nProblem 2. Remove elements');

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

if (!Array.hasOwnProperty('remove')) {
	Array.prototype.remove = function(item) {
		var i,
			length = this.length;

		for (i = 0; i < length; i += 1) {
			if (this[i] === item) {
				this.splice(i, 1);
				i -= 1;
				length -= 1;
			}
		}
	};
}

arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(arr);
arr.remove(1);
console.log(arr);
