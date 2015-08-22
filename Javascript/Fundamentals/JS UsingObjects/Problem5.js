//Problem 5. Youngest person
console.log('\nProblem 5. Youngest person');

var i,
	len,
	people = [],
	firstName,
	lastName,
	age,
	fullName,
	minAge,
	youngestPerson;

function Person(firstName, lastName, age) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.age = age;
}

Person.prototype.fullName = function() {
	return this.firstName+' '+this.lastName;
};

people = [new Person('Gosho','Petrov', 50),
			new Person('Bay','Ivan',81),
			new Person('Ivan','Milchev',35),
			new Person('Georgina','Stoyanova',27),
			new Person('Georgi','Mandjarov',31),
			new Person('Foti','Fotev',18)
			];


for (i = 0, len=people.length; i<len; i+=1) {
	if (people[i].age<minAge || !minAge) {
		minAge = people[i].age;
		youngestPerson = i;
	}
}

console.log(people[youngestPerson].fullName()+' '+people[youngestPerson].age);

