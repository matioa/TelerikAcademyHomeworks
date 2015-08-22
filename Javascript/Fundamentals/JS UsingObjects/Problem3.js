// Problem 3. Deep copy
console.log('\nProblem 3. Deep copy');


var number,
	numberCopy,
	person,
	personCopy;

number = 10;
numberCopy = clone(number);

console.log(number);
console.log(numberCopy);

person = {name: 'Ivan Milchev', age: 35};
personCopy = clone(person);
console.log(person);
console.log(personCopy);

console.log('...after change of name...')
person.name = 'Georgi Ivanov';
console.log(person);
console.log(personCopy);


function clone(obj){
	var cloned,
		prop;
    if (typeof obj !== 'object') {
        return obj;
    }

    cloned = {};
    for (prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }

    return cloned;
}