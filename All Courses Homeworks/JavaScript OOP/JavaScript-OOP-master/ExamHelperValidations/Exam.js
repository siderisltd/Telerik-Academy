// za da raboti trqbva da go ogradim v funkciq solve()
function solve() {

    var module = (function () {

        var validator = {

            validateNumberBetweenRange: function (val, name, minRange, maxRange) {
                name = name || 'Value';
                this.validateIfUndefined(val, ' UNDEFINED FROM validateNumberBetweenRange');
                this.validateIfNumber(val, 'NAN FROM validateNumberBetweenRange');

                if (val >= minRange && val <= maxRange) {

                }
                else {
                    throw new Error(name + ' IS NOT IN THE GIVEN RANGE ');
                }
            },

            validateIfStringIsConvertibleToNumber: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateNonEmptyString(val, name);

                var asNumber = parseInt(val);

                if (isNaN(asNumber)) {
                    throw new Error(name + ' IS NOT CONVERTIBLE TO NUMBER ');
                }

            },

            validateNonEmptyString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }
                if (val.length === 0) {
                    throw new Error(name + ' MUST BE NON EMPTY STRING');
                }
            },

            validateExactStringLength: function (val, name, minValue, maxValue) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfString(val, ' FROM EXACTLENGTH : IT IS NOT A STRING !!!');

                if (val.length === minValue || val.length === maxValue) {

                }
                else {
                    throw new Error(name + ' MUST BE EXACTLY ' + minValue + ' CHARACTERS OR ' + maxValue);
                }
            },

            validateIfUndefined: function (val, name) {
                name = name || 'Value';
                if (typeof val === 'undefined') {
                    throw new Error(name + ' cannot be undefined');
                }
            },

            validateIfObject: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'object') {
                    throw new Error(name + ' must be an object');
                }
            },

            validateIfString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                //if (val.length < CONSTANTS.TEXT_MIN_LENGTH
                //        || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
                //    throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH +
                //            ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols');
                //}
            },

            validateIfNumber: function (val, name) {
                name = name || 'Value';

                if (typeof val !== 'number') {
                    throw new Error(name + ' must be a number');
                }
            },
            //bez 0
            validatePositiveNumber: function (val, name) {
                name = name || 'Value';

                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val <= 0) {
                    throw new Error(name + ' must be positive number');
                }
            },

            validateId: function (id, name) {
                name = name || 'Value';
                this.validateIfUndefined(id, 'From validateID ');
                this.validateIfNumber(id, 'From validateNumber in ValidateID')
                this.validatePositiveNumber(id, ' ID MUST BE POSITIVE FROM VALIDATE_ID')
                if (typeof id !== 'number') {
                    id = id.id;
                }

                this.validateIfUndefined(id, 'Object must have id');
                return id;
            },   // tova se polzva s id = validateId(id); - ID trqbva da e num

            validateIsArray: function (val, name) {
                name = name || 'Value';

                if (!Array.isArray(val)) {
                    throw new Error(name + ' is not array');
                }
            },

            validateAreAllArrMembersAreNumbers: function (val, name) {
                name = name || 'Value';
                this.validateIsArray(val, name);

                var isAllNumbers = val.every(function (number) {
                    return typeof number === 'number';
                });

                if (!isAllNumbers) {
                    throw new Error(name + ' Not all members are numbers');
                }

            },

            validateAreAllArrMembersAreStrings: function (val, name) {
                name = name || 'Value';
                this.validateIsArray(val, name);

                var isEveryElementString = val.every(function (element) {
                    return typeof element === 'string';
                });

                if (!isEveryElementString) {
                    throw new Error(name + ' Not all members are STRINGS');
                }
            },

            validateAreAllArrayElementsConvertibleToNumber: function (val, name) {
                name = name || 'Value';

                this.validateIsArray(val, name);

                var isConvertable = val.every(function (number) {
                    return parseInt(number);
                });

                if (!isConvertable) {
                    throw Error(name + ' Elements are not convertible to NUMBER');
                }
            },

            //must just have property length
            validateIfLenghtIsBetweenMinAndMax: function (val, name, minLength, maxLength) {
                name = name || 'Value';

                if (!val.length) {
                    throw new Error('The value must have property length');
                }

                if (val.length < minLength || val.length > maxLength) {
                    throw new Error(name + ' has invalid length');
                }

            }, //look it before use

            //should test
            validateIfSomeElementInheritsAnother: function (child, parent, name) {
                name = name || 'Value';
                this.validateIfUndefined(child);
                this.validateIfUndefined(parent);

                var isParent = false;

                if (parent.isPrototypeOf(child)) {
                    isParent = true;
                }

                if (!isParent) {
                    throw new Error('NAME:' + name + ' CHILD: ' + child + ' is not child of ' + parent)
                }

            },
            //attribute, self = this //**// izpolzva se s this za konkretniq obekt i vaji samo za negovite si propertyta mai

            //CheckItBefore USING
            checkIfExistingAttribute: function (attribute, self, name) {
                name = name || 'Value';

                this.validateIfUndefined(self);
                this.validateIfObject(self);
                this.validateIfString(attribute);

                var isThereAttr = self.hasOwnProperty(attribute);


                if (isThereAttr = false) {
                    throw new Error(name + ' ATTRIBUTE : ' + attribute + ' is NOT EXIST ')
                }
            }
        };

        var item,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog;

        item = (function () {
            var item = Object.create({});

            var lastId = 0;

            Object.defineProperty(item, 'init', {
                value: function (name, description) {
                    this._id = ++lastId;
                    this.name = name;
                    this.description = description;
                    return this;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (val) {
                    validator.validateIfString(val, 'Item description');
                    validator.validateNonEmptyString(val, 'Item desctiption');

                    this._description = val;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateIfString(val, 'Item name');
                    validator.validateIfLenghtIsBetweenMinAndMax(val, ' Item NAME ', 2, 40);
                    this._name = val;
                }
            });
            return item;
        }());

        book = (function (parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function (name, description, isbn, genre) {
                    parent.init.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;
                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (val) {
                    validator.validateIfStringIsConvertibleToNumber(val, ' BOOK ISBN ');
                    validator.validateExactStringLength(val, ' BOOK ISBN ', 10, 13);
                    validator.validateIfStringIsConvertibleToNumber(val, ' BOOK ISBN ');
                    this._isbn = val;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function (val) {
                    validator.validateIfString(val, ' BOOK ISBN ');
                    validator.validateIfLenghtIsBetweenMinAndMax(val, ' BOOK GENRE ', 2, 20);
                    this._genre = val;
                }
            });

            return book;
        }(item));

        media = (function (parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function (name, description, rating, duration) {
                    parent.init.call(this, name, description);
                    this.rating = rating;
                    this.duration = duration;
                    return this;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (val) {
                    validator.validateNumberBetweenRange(val, ' MEDIA RATING ', 1, 5);
                    this._rating = val;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function () {
                    return this._duration;
                },
                set: function (val) {
                    validator.validatePositiveNumber(val, ' MEDIA DURATION ');
                    this._duration = val;
                }
            });

            return media;
        }(item));

        //do tuk ok 46

        catalog = (function () {
            var catalog = Object.create({});

            var lastId = 0;

            Object.defineProperty(catalog, 'init', {
                value: function (name) {
                    this._id = ++lastId;
                    this.name = name;
                    this._items = [];
                    return this;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'items', {
                get: function () {
                    return this._items;
                }
            });


            Object.defineProperty(catalog, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateIfString(val, ' NAME FromCatalogName ');
                    validator.validateIfLenghtIsBetweenMinAndMax(val, ' NAME FromCatalogName ', 2, 40);
                    this._name = val;
                }
            });
            //methods

            Object.defineProperty(catalog, 'add', {  //tested
                value: function () {
                    //console.log(arguments);
                    var args;
                    if(!Array.isArray(arguments[0])){
                        args = [].slice.apply(arguments);
                    }
                    args = args || arguments[0];

                    validator.validateIfUndefined(args, ' Catalog arguments');

                    //if(args.length === 0){
                    //    throw Error(' EMPTY ARRAY ');
                    //}

                    for(var index in args){
                        if(validator.validateIfSomeElementInheritsAnother(args[index], item, ' Only ITEM LIKE OBJS '));
                        this._items.push(args[index]);
                    }

                    return this;
                }
            });

            Object.defineProperty(catalog, 'find', {  // x 2
                value: function () {
                    var args;
                    if(!Array.isArray(arguments[0])){
                        args = [].slice.apply(arguments);
                    }
                    args = args || arguments[0];
                    validator.validateIfUndefined(args, ' Catalog arguments');

                    if(args.length === 0){
                        throw Error(' EMPTY ARRAY ');
                    }

                    var id;
                    var options;

                    if(!(typeof args[0] === 'number') && !(typeof args[0] === 'object')){
                        throw new Error('fuck off');
                    }

                    if(typeof args[0] === 'number') {
                        validator.validateId(args[0], ' arguments ot nula ');
                        id = args[0];
                    }
                    else if (typeof args[0] === 'object'){
                        options = args[0];
                    }

                    var isFound;



                    if(typeof id === 'number'){
                        for (var i = 0; i < this._items.length; i++) {
                            var currentItem = this._items[i];

                            if(currentItem._id == id){
                                isFound = true;
                                return currentItem;
                            }
                        }
                        if(typeof isFound === 'undefined'){
                            return null;
                        }
                    }

                    if(typeof options === 'object'){
                        var myOption = {};

                        if(typeof options.id !== 'undefined'){
                            myOption.id = options.id;
                            myOption.id = parseInt(myOption.id);
                            validator.validateId(myOption.id, 's');
                        }
                        if(typeof options.name !== 'undefined'){
                            myOption.name = options.name;
                        }

                        if(typeof myOption.id === 'undefined' && myOption.name === 'undefined'){
                            throw new Error();
                        }

                        if(typeof myOption.id !== 'undefined' && typeof myOption.name !== 'undefined'){
                            //tursim po 2 kriteriq
                            var isFound;
                            for (var i = 0; i < this._items.length; i++) {
                                var currentItem = this._items[i];

                                if(currentItem._id === myOption.id && currentItem.name === myOption.name ){
                                    isFound = true;
                                    return currentItem;
                                }
                            }
                            if(typeof isFound === 'undefined'){
                                return null;
                            }
                        }

                        if(typeof myOption.id !== 'undefined' && typeof myOption.name === 'undefined'){
                            //tursim po id
                            var isFound;
                            for (var i = 0; i < this._items.length; i++) {
                                var currentItem = this._items[i];

                                if(currentItem._id === myOption.id){
                                    isFound = true;
                                    return currentItem;
                                }
                            }
                            if(typeof isFound === 'undefined'){
                                return null;
                            }
                        }

                        if(typeof myOption.id === 'undefined' && typeof myOption.name !== 'undefined'){
                            //tursim po name
                            var isFound;
                            for (var i = 0; i < this._items.length; i++) {
                                var currentItem = this._items[i];

                                if(currentItem.name === myOption.name ){
                                    isFound = true;
                                    return currentItem;
                                }
                            }
                            if(typeof isFound === 'undefined'){
                                return null;
                            }
                        }
                    }
                    return this;
                }
            });


            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    validator.validateIfString(pattern, 'Search pattern');

                    return this._items
                        .filter(function (item,s,items) {
                            return items
                                .some(function (item) {
                                    return ((item.name.toLowerCase() .indexOf(pattern.toLowerCase()) >= 0)
                                        || item.id.toString().toLowerCase().indexOf(pattern.toLowerCase()) >= 0
                                     || item.description.toString().toLowerCase().indexOf(pattern.toLowerCase()) >= 0);
                                });
                        })
                        .map(function (item) {
                            return {
                                name: item.name,
                                id: item.id
                            }
                        });
                }
            });

            return catalog;
        }());

        bookCatalog = (function (parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function (book) {
                    var otg = parent.add.call(this, book);
                    validator.validateIfUndefined(otg);
                    return otg;
                }
            });

            Object.defineProperty(bookCatalog, 'find', {  // x 2
                value: function (args) {
                    return parent.find.call(this, args);
                }
            });


            ////todo:getGenres()
            //Returns an array of lowercase strings
            //All the unique genres of books that are added


            //methods

            //add(book1, book2, book3, �)
            //add(booksArray)
            //getGenres()
            //find(options)

            //Object.defineProperty(catalog, 'add', {  //x 2   -- booksArray ili book1, book2, book3,
            //    value: function () {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});
            //
            //Object.defineProperty(catalog, 'getGenres', {
            //    value: function () {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});
            //
            //Object.defineProperty(catalog, 'find', {
            //    value: function (options) {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});

            return bookCatalog;
        }(catalog));  //TODO's


        mediaCatalog = (function (parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function (name) {
                    parent.init.call(this, name);
                    return this;
                }
            });


            //methods

            Object.defineProperty(mediaCatalog, 'add', {
                value: function (mediacat) {
                    var otg = parent.add.call(this,mediacat);
                    validator.validateIfUndefined(otg);
                    return otg;
                }
            });

            Object.defineProperty(mediaCatalog, 'find', {
                value: function (mediacat) {
                    var otg =  parent.find.call(this,mediacat);
                    validator.validateIfUndefined(otg);
                    return otg;
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function (count) {
                   validator.validateIfUndefined(count,'finger');
                    validator.validateIfNumber(count,'maika ti ');
                    if(count < 1){
                        throw new Error();
                    }
                }
            });


            //Object.defineProperty(mediaCatalog, 'add', {  //x 2
            //    value: function () {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});
            //
            //Object.defineProperty(mediaCatalog, 'getTop', {
            //    value: function (count) {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});
            //
            //Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
            //    value: function () {
            //        //TODO: ADD LOGIC
            //        //return this;
            //    }
            //});
            //

            return mediaCatalog;
        }(catalog));


        return {
            getCatalog: function (name) {   //tested ne trqbva da go ima mai
                return Object.create(catalog).init(name);
            },
            getItem: function (name, description) {   //tested ne trqbva da go ima mai
                return Object.create(item).init(name, description);
            },
            getBook: function (name, isbn, genre, description) {   //tested
                return Object.create(book).init(name, description, isbn, genre);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, description, rating, duration);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog).init(name);
            }
        };
    }());

    return module;
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');
var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

//console.log(catalog.items);

//console.log(catalog.find(book1.id));
//returns book1

//console.log(catalog.find({id: book2.id, genre: 'IT'}));
////returns book2

//catalog.search('js');
//
console.log(catalog.search('js'));
//// returns book2
//
//console.log(catalog.search('javascript'));
////returns book1 and book2
//
//console.log(catalog.search('Te sa zeleni'))
////returns []
