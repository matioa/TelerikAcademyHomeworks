//Problem 1. Format with placeholders
console.log('\nProblem 1. Format with placeholders');



String.prototype.format = function(options) {
    var prop,
        result = this;
    for (prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
    }
    return result;
};

var options = {name: 'John', age:13};
var string ='Hello, there! Are you #{name}?';
console.log(string.format(options));
var string2= 'My name is #{name} and I am #{age}-years-old.';
console.log(string2.format(options));