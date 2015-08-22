//Problem 4. Has property
console.log('\nProblem 4. Has property');

function hasProperty(obj, prop) {
	for (objProp in obj) {
		if (objProp === prop) {
			return true;
		}
	}

	return false;
}

var obj = {
	prop1: 1,
	prop2: 2
};

console.log(hasProperty(obj,'prop1'));
console.log(hasProperty(obj,'prop3'));