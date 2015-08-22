// Problem 7. Parse URL
console.log('\nProblem 7. Parse URL');

var url = 'http://telerikacademy.com/Courses/Courses/Details/239',
	result={};

var result = parseUrl(url);
console.log(result);

function parseUrl(url) {
	var indexOfSlash = url.indexOf('/'),
		indexOfSecondSlash = url.indexOf('/', indexOfSlash + 1),
		indexOfThirdSlash = url.indexOf('/', indexOfSecondSlash + 1),
		result = {};

	result.protocol = url.substring(0, url.indexOf(':'));
	result.server = url.substring(indexOfSecondSlash + 1, indexOfThirdSlash);
	result.resource = url.substring(indexOfThirdSlash);

	return result;
}