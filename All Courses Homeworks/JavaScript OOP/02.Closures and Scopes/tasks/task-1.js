function solve() {
        var library = (function () {

            var books = [],
                categories = [],
                ID = 0;


            function listBooks() {
                return books.sort(function(a, b){
                    return a.ID - b.ID;
                });
            }

            function addBook(book) {
                if(isIsbnCorrect(book.isbn) && isAuthorCorrect(book.author) &&
                    isTitleCorrect(book.title) && isCategoryCorrect(book.category)){
                    book.ID = parseInt(books.length + 1);
                    books.push(book)
                    return book;
                }
                else{
                    if(book.category){
                        categories.push(book.category);
                    }
                    return [];
                }
            }

            function isIsbnCorrect(isbn){
                var isCorrect = false;
                if((isbn !== undefined || isbn !== '') &&
                    (isbn.toString().length == 10 || isbn.toString().length == 13) &&
                    (/^\d+$/g).test(isbn)){

                    if(!isIsbnUnique(isbn)){
                        isCorrect = true;
                        return isCorrect;
                    }
                    else{
                        throw new Error('Incorrect ISBN');
                    }
                }

                else{
                    throw new Error('Incorrect ISBN');
                }

                function isIsbnUnique(isbn){
                    return books.some(function(book){
                        return isbn === book.isbn;
                    });
                }
            }    //ready maybe one !

            function isAuthorCorrect(author){
                var isCorrect = author.toString() !== '';
                if(!isCorrect){
                    throw new Error('Incorrect author');
                }
                return isCorrect;
            }

            function isTitleCorrect(title){    //maybe !
                var isCorrect = false;
                if(!isTitleUnique(title)) {
                    if (title.length >= 2 && title.length <= 100) {
                        isCorrect = true;
                        return isCorrect;
                    }
                }

                throw new Error('Incorrect title');

                function isTitleUnique(title) {
                    return books.some(function (book) {
                        return title === book.title;
                    });
                }
            }

            function isCategoryCorrect(category){
                var isCorrect = false;
                if(category.length >= 2 && category.length <= 100){
                    isCorrect = true;
                    return isCorrect;
                }
                else{
                    throw new Error('Incorrect category');
                }
            }


            function listCategories() {
                return categories.sort(function(a, b){
                    return a.ID - b.ID;
                });
            }

            return {
                books: {
                    list: listBooks,
                    add: addBook
                },
                categories: {
                    list: listCategories
                }
            };

        } ());
        return library;
    }



    module.exports = solve;
