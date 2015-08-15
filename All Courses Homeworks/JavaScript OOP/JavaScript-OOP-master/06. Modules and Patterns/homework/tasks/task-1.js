/* Task Description */
/* 
 * TODO:Create a module for a Telerik Academy course
 * TODO:The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation      ---> ???
 * TODO:There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * TODO:Each student can submit a homework for each presentation in the course
 * Create method init
 * //////////////////Accepts a string - course title
           * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
            * Titles do not start or end with spaces
               * Titles do not have consecutive spaces
             * Titles have at least one character
 * Throws if there are no presentations



 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}

-----------------------------------------------------------------------
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 ----------------------------------------------------------------------
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 *
 *
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 *
 *
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

var Course = (function () {
    var students = [],
        homeworks = [],
        studentID = 0,
        examResults = [];

    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations; // each presentation also had a title
        },
        addStudent: function (student) {
            var firstAndLastName = student.split(' '),
                firstName = firstAndLastName[0].trim(),
                lastName = firstAndLastName[1].trim(),
                ID = ++studentID;
            if(isValidStudentName(student,firstName) && isValidStudentName(student, lastName)){
                students.push({fisrname: firstName, lastname: lastName, id: ID });
            }
            else{
                throw Error('Invalid student name');
            }
        },
        getAllStudents: function () {
            return students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            validateId(studentID, 1, this.students.length);
            validateId(homeworkID, 1, this.presentations.length);
            homeworks.push({studentID: studentID, homeworkID: homeworkID});
        },
        pushExamResults: function (results) {
            for(var index in results){
                var current = results[index];
                if (isNaN(current.Score)){
                    //throw new Error('Score is NaN');
                }
                //If the student ID exists in students[]

            }
            //format {StudentID: ..., Score: ...}
            //StudentIDs which are not listed get 0 points t.e tezi, koito ne sa ni podadeni v masivva
            //* Throw if there is an invalid StudentID
            //* Throw if same StudentID is given more than once ( he tried to cheat (: )
            //* Throw if Score is not a number
        },
        getTopStudents: function () {
        }
    };

    Object.defineProperty(Course, 'title',{
        get: function(){
            return this._title;
        },
        set: function(value){
            if(isCorrectTitle(value)){
                this._title = value;
            }
            else{
                throw Error('Invalid title');
            }
        }
    });

    Object.defineProperty(Course, 'presentations',{
        get: function(){
            return this._presentations.slice();
        },
        set: function(value){
            if(isCorrectPresentation(value)){
                this._presentations = value;
            }
            else{
                throw Error('Invalid presentations');
            }
        }
    }); // kak si imat ime kak im se podava



    function isCorrectTitle (title) {
        var isString = typeof title === 'string',
            isFirstLetterSpace = title[0] === ' ',
            isLastLetterSpace = title[title.length - 1] === ' ',
            hasMoreThanOneCharacter = title.length > 1,
            indexOfSpace = isString? title.indexOf(' ') : -1,
            hasNoConsecutiveSpaces = true;

        while (indexOfSpace > 0) {
            if (title[indexOfSpace + 1] === ' ' || title[indexOfSpace - 1] === ' ') {
                hasNoConsecutiveSpaces = false;
            }
            indexOfSpace = title.indexOf(' ', indexOfSpace + 1);
        }

        if (isString && !isFirstLetterSpace && !isLastLetterSpace && hasMoreThanOneCharacter && hasNoConsecutiveSpaces) {
            return true;
        }
        else {
            return false;
        }
    }  //tested

    function isCorrectPresentation (presentations) {
        return presentations.every(function (presentation) {
            return typeof presentation === 'string';
        });
    }   //tested

    function isValidStudentName (fullName, oneName) {
        var isValidFullName = typeof fullName === 'string';
        var isValidOneName = true;

        if(oneName[0] = oneName[0].toUpperCase()){
            for (var i = 1; i < oneName.length; i++) {
                if(oneName[i] != oneName[i].toLowerCase()){
                    isValidOneName = false;
                    break;
                }

            }
        }
        else{
            isValidOneName = false;
        }

        if(isValidFullName && isValidOneName){
            return true;
        }
        else{
            return false;
        }
    }   //tested

    function isValidIdNumberInGivenRange(id, min, max){
        if(id != Number(id)){
            throw 'Invalid type for id.';
        }
        if(id < min || id > max){
            throw 'Invalid range.';
        }
    }


    return Course;
}());

var jsoop = Object.create(Course);
jsoop.init('Shepherds huddle', [
        'sailors furious',
        'Moulds detonate tunnel',
        'Modules and Patterns']
);

jsoop.addStudent('Jeko Jekov');
jsoop.addStudent('Jeko Jekov');
jsoop.addStudent('Jeko Jekov');
jsoop.addStudent('Jeko Jekov');
jsoop.addStudent('Jeko Jekov');
jsoop.addStudent('Jeko Jekov');


console.log(jsoop.getAllStudents());

//module.exports = solve;
