//Problem 6
console.log('\nProblem 6');

var people = [];

function Person(firstName, lastName, age) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.age = age;
}

people = [new Person('Gosho', 'Petrov', 50),
	new Person('Bay', 'Ivan', 81),
	new Person('Ivan', 'Milchev', 50),
	new Person('Georgina', 'Stoyanova', 25),
	new Person('Georgi', 'Mandjarov', 25),
	new Person('Foti', 'Fotev', 18)
];


function group(array, prop) {
	var i,
		len,
		key,
		associativeArray = {};

	for (i=0, len=array.length; i<len; i+=1) {
		key = array[i][prop];

		if (!associativeArray[key]) {
			associativeArray[key] = [];
			associativeArray[key].push(array[i]);
		} else {
			associativeArray[key].push(array[i]);
		}
	}
	return associativeArray;
}

var groupedPeople = group(people, 'age');
console.log(groupedPeople);