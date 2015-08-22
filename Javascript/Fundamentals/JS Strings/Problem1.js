//Problem 1. Reverse string
console.log('\nProblem 1. Reverse string');


var regularString = 'sample';

if (!String.prototype.reverse) {
	String.prototype.reverse = function() {
		var reversed=[],
			i,
			len;

		len=this.length;
		for (i=0;i<len;i+=1) {
			reversed.unshift(this[i]);
		}
		return reversed.join('');
	};
}

console.log('original: '+regularString);
console.log('reversed: '+regularString.reverse());