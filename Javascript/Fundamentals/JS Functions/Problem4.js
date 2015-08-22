//Problem 4. Number of elements
console.log('\nProblem 4. Number of elements');

var tag = 'div';
console.log(tag+' -> '+findElements('div'));

function findElements(tag) {
	return document.getElementsByTagName(tag).length;
}

