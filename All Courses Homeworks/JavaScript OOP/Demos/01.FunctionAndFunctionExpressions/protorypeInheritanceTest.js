//prototype inheritance

var Animal = (function(){

   var Animal = {
        init: function(name, age){
            this.name = name;
            this.age = age;
            return this;   //important
        },
        get name(){
            return this._name;
        },
        set name(value){
            if(true){
                this._name = value;
            }
            else if(false){
                throw new Error('someError');
            }
        },
        get age(){
            return this._age;
        },
        set age(value){
            this._age = value;
        },
        //overriding parent method
        toString: function(){
            return 'overrided toString : name--> ' + this.name + '| age --> ' + this.age;
        }

    };
    return Animal;   //important
}());

var cat = (function(parent){
    var cat = Object.create(parent); // avtomatichno suzdava obekt i mu setva prototipa na animal

    Object.defineProperty(this, 'init',{
       value: function(name, age){ // tuk moje da podadem i drugi property ta
           parent.init.call(this, name, age);
       }
    });
    return cat;
}(Animal));

var kitten = (function(parent){
    var kitten = Object.create(parent);


    kitten.toString = function(){
      return parent.toString.call(this) + ' overrided';
    };
    return kitten;
}(cat));



var testAnimal = Object.create(Animal).init('jirafcho', 3);
var testCat = Object.create(cat).init('penka', 12);
var testKitten = Object.create(kitten).init('goshka', 1);


//console.log(Animal.isPrototypeOf(testKitten));  // dali nqkoi obekt e prototip na Animal

//ducktyping -> tova se interesuva da ima name i age samo za da moje da si svurshi rabotata
//console.log(testCat.toString.call({name: 'duck', age: 12}));

console.log(testAnimal.toString());