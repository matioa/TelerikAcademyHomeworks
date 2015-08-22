// Problem 11. String format
console.log('\nProblem 11. String format');


var string = '{0}, {1}, {0} text {2}',
	result;

result = stringFormat(string, 'Pesho', 'Gosho', 'Ivan');
console.log(result);

var str = stringFormat('Hello {0}!', 'Peter');
console.log(str);

var frmt = '{0}, {1}, {0} text {2}';
var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
console.log(str);


function stringFormat() {
	var allArguments = arguments,
		i,
		result = [],
		text = allArguments['0'],
		len = text.length,
		index = '',
		recordIndex = false,
		open = '{',
		close = '}';

	for (i = 0; i <= len; i += 1) {
		if (text[i] === open) {
			recordIndex = true;
			continue;
		}

		if (text[i] === close) {
			recordIndex = false;
			index = parseInt(index) + 1;
			result.push(allArguments[index]);
			index = '';
			continue;
		}
		if (recordIndex) {
			index += text[i];
			continue;
		} else {
			result.push(text[i]);
		}
	}
	return result.join('');
}