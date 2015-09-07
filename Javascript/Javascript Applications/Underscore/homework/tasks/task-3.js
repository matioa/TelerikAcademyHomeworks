/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName`, `age` and `marks` properties
        *   `marks` is an array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (students) {
        _.chain(students)
            .map(function (student) {
                var overallScore = 0;
                _.each(student.marks, function (mark) {
                    overallScore += mark;
                });
                student.score = overallScore / student.marks.length;
                student.fullName = student.firstName + ' ' + student.lastName;
                return student;
            })
            .sortBy('score')
            .last([1])
            .each(function (student) {
                console.log(student.fullName + ' has an average score of ' + student.score);
            })
    };
}

module.exports = solve;
