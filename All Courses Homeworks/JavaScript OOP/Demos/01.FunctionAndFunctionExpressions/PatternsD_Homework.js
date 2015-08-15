function solve() {
    var Course = {
        init: function(title, presentations) {
            validateTitle(title);
            this.title = title;
            validatePresentations(presentations);
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function(name) {
            var student = validateName(name);
            var id = this.students.length + 1;
            student.id = id;

            this.students.push(student);

            return id;
        },
        getAllStudents: function() {
            return this.students.slice();
        },
        submitHomework: function(studentID, homeworkID) {
            validateId(studentID, 1, this.students.length);
            validateId(homeworkID, 1, this.presentations.length);
        },
        pushExamResults: function(results) {
        },
        getTopStudents: function() {
        }
    };

    Object.defineProperty(Course, 'title', {
        get: function () {
            return Course._title;
        },
        set: function(title){
            Course._title = title;
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function () {
            return Course._presentations;
        },
        set: function(presentations){
            Course._presentations = presentations;
        }
    });

    Object.defineProperty(Course, 'students', {
        get: function () {
            return Course._students;
        },
        set: function(students){
            Course._students = students;
        }
    });

    function validateTitle(title){
        if(title === null || typeof title !== 'string'){
            throw 'Invalid type for title.';
        }

        if(title.trim() === '' || title !== title.trim()){
            throw 'Invalid title.';
        }

        if(/[\s]{2,}/.test(title)){
            throw 'Invalid spacing.';
        }
    }

    function validatePresentations(presentations){
        if(presentations === null || !Array.isArray(presentations)){
            throw 'Invalid type for presentations';
        }

        if(presentations.length === 0){
            throw 'Invalid length.';
        }

        presentations.forEach(function (title) {
            validateTitle(title);
        });
    }

    function validateName(name){
        if(name === null || typeof name !== 'string'){
            throw 'Invalid type for name.';
        }

        if(name.trim() === ''){
            throw 'Empty names string.';
        }

        var names = name.split(' ');

        if(names.length !== 2){
            throw 'Invalid names string.';
        }

        names.forEach(function(n){
            if(!/^[A-Z][a-z]*$/.test(n)){
                throw 'Invalid name.';
            }
        });

        return {
            firstname: names[0],
            lastname: names[1]
        };
    }

    function validateId(id, min, max){
        if(id != Number(id)){
            throw 'Invalid type for id.';
        }

        id = +id;

        if(id < min || id > max){
            throw 'Invalid range.';
        }
    }

    return Course;
}