//IMPORTANT THINGS
//    --> Objects are key value pairs [like dictionary]  !!! They are passed by references
//    --> Ako iskame pri prototipnoto nasledqvane da izvikame parent funkciq vurhu konkretniq obekt izpolzvame
//        MainObjectParent.FunctionName.call(this) -- imam go na prototypeInheritanceTest.js
//    --> This-a v funkciqta s koeto e definirano daden metod e obekta, ot koito e izvikana funkciqta

//CLASSICAL INHERITANCE
function MyClass(name, age) {
    this._name = name;
    this._age = age
}
MyClass.prototype.someMethod = function () {

};

function MySubClass(name, age){
    MyClass.call(this, name, age);
}

MySubClass.prototype = Object.create(MyClass.prototype);
MySubClass.prototype.constructor = MySubClass;

MySubClass.prototype.someMethod = function(){
    MyClass.prototype.someMethod.call(this);
};

var testMyClass = new MyClass('test', 'testov');
var testSubClass = new MySubClass('putka', 'maina');

console.log(testMyClass);
console.log(testSubClass);

////
//Another example of classical OOP
function Person(name, age){
    this.name = name;
    this.age = age;
}
Person.prototype.introduce = function(){
  console.log('Name:' + this.name + ', Age: ' + this.age);
};

var personOne = new Person('gosho', 12);
var personTwo = new Person('pesho', 10);

//Ofertata e s Object.defineProperty vmesto get, set

var ParentClass = (function(name){
    var ParentClass = function(name){
        this.name = name;
    };
    //Default-no property pri inicializaciq
    //moje bi e po pravilno v samiq konstruktor no...
    ParentClass.prototype.defaultProperty = 'default';


    //ako ne iskame da ni se pokazva property to _name kato minavame s forin po propertytata
    //tova ne se pravi nqma smisul
    Object.defineProperty(ParentClass.prototype, '_name',{
       enumerable: false,
        writable: true
    });

    Object.defineProperty(ParentClass.prototype, 'name',{
        get: function(){
            return this._name;
        },
        set: function(value){
            if(typeof (value) !== 'string'){
                throw new Error('Simple validation');
            }
            this._name = value;
        },
        // za da se pokazva tova -
        enumeraable:true
    });

    ParentClass.prototype.getName = function(){
      return this.name;
    };

    return ParentClass;
}());

var objOne = new ParentClass('gosho');
//objOne.name = 'pesho'; // kak beshe tova da si skriem property to
console.log(objOne.name);

//SIMPLE CLASSICAL INHERITANCE  --> ne mnogo dobur primer absurd na izpita
var Children = (function(parent){
    var Children = function(name, age){
        parent.call(this, name);
        this.age = age;
    };
    Children.prototype = parent.prototype;

    return Children;
}(ParentClass));

var newChildren = new Children('penka', 12);    // zashto ne rabotqt getterite i setterite ot parenta ??

console.log(newChildren.getName());

// taka vzimame prototipa na daden obekt

console.log(Object.getPrototypeOf(ParentClass));