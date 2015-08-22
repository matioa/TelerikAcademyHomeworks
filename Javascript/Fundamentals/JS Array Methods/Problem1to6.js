//Problem 1. Make person
console.log('\nProblem 1. Make person');



function Person(firstName, lastName, age, gender) {
	this.firstName = firstName;
	this.lastName= lastName;
	this.age=age;
	this.gender = gender;
}

Person.prototype.toString = function () {
	return this.firstName+' '+this.lastName+' '+this.age+' '+this.gender;
}

var people = [new Person('Zak','Oberin',4,false),
				new Person('Mich','Buchannon',37,false),
				new Person('Marilyn','Monroe', 29,true),
				new Person('Woody', 'Allen', 54,false),
				new Person('Brad','Pitt',22,false),
				new Person('Demi','Moore',22,true),
				new Person('Meg','Ryan',40,true),
				new Person('Charlie','Sheen',39,false),
				new Person('Kurt','Cobain',34,false),
				new Person('Elvis','Presley',33,false)];

console.log(people.toString());

// Problem 2. People of age
console.log('\nProblem 2. People of age');
var allAreAdults = people.every(function(human) {
	return human.age>=18;
});
console.log(allAreAdults);



// Problem 3. Underage people
console.log('\nProblem 3. Underage people');

var underagePeople = people.filter(function(human){
	return human.age<18;
});
console.log(underagePeople);

people.forEach(function(human){
 if(human.age<18) {
 	console.log(human);
 }
});



//Problem 4. Average age of females
console.log('\nProblem 4. Average age of females');

var arrayWomen = people.filter(function(human) {
	return human.gender;
});

var avrgAgeWomen = arrayWomen.reduce(function(sum,human){
	return sum+human.age;
},0)/arrayWomen.length;

console.log(avrgAgeWomen);




//Problem 5. Youngest person
console.log('\nProblem 5. Youngest person');

	// add property Full Name
Person.prototype.fullName = function () {
	return this.firstName+' '+this.lastName;
}

	// add method find
if (!Array.prototype.find) {
  Array.prototype.find = function(predicate) {
    if (this == null) {
      throw new TypeError('Array.prototype.find called on null or undefined');
    }
    if (typeof predicate !== 'function') {
      throw new TypeError('predicate must be a function');
    }
    var list = Object(this);
    var length = list.length >>> 0;
    var thisArg = arguments[1];
    var value;

    for (var i = 0; i < length; i++) {
      value = list[i];
      if (predicate.call(thisArg, value, i, list)) {
        return value;
      }
    }
    return undefined;
  };
}

var youngestMan = people.sort(function(a,b) {
	return a.age-b.age;
}).find(function(human) {
	return !human.gender;
});

console.log(youngestMan.fullName());

//Problem 6. Group people
console.log('\nProblem 6. Group people');

var groupedByLetter = people.reduce(function(group,person) {
	var letter = person.firstName[0];
	if (!group[letter]) {
		group[letter]=[];
		group[letter].push(person)
	} else {
		group[letter].push(person);
	}
	return group;
},{});

for (var letter in groupedByLetter) {
	console.log(letter+' '+groupedByLetter[letter])
};