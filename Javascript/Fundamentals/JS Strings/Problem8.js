// Problem 8. Replace tags
console.log('\nProblem 8. Replace tags');

var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>',
    result;

result = replaceTag(input);

console.log(result);


function replaceTag(html) {
    while (html.indexOf('<a href') >= 0) {
        html = html.replace('<a href="', '[URL=').
        replace('">', ']').
        replace('</a>', '[/URL]');
    }
    return html;
}