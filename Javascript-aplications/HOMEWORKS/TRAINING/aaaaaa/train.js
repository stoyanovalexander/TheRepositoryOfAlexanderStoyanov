//function Person(fname, lname) {
//    this.intraduce = function () {
//        return "Hello my name is: " + fname + " " + lname;
//    }
//}

//var Pesho = new Person("Pesho", "mentata");
//var Gosho = new Person("Gosho", "fleitata");

//console.log(Pesho.intraduce());
//console.log(Gosho.intraduce());
/////////////////////////////////////////////////////////////////////////

//function Person(fname, lname) { }
//function Student(fname, lname, grade) { }
//Student.prototype = new Person();

//var myManOne = new Student("Siabonga", "Nomwete", 7);
/////////////////////////////////////////////////////////////////////////////

//function Person(fname, lname) {
//    var fullName = fname + " " + lname;
//    this.sayName = function () { return fullName; };
//}
//////////////////////////////////////////////////////////////////////////

//function Person(fname, lname) {
//    this.fname = fname;
//    this.lname = lname;
//}

//Person.prototype = {
//    fullName:
//        function () {
//            return this.fname + " " + this.lname;
//        },
//    changeFName:
//        function (fname) {
//            this.fname = fname || this.fname;
//        }
//}

//////////////////////////////////////////////////////////////////////

//var Person = Class.create({
//    init: function (fname, lname) {
//        this.fname = fname;
//        this.lname = lname;
//    },
//    fullname: function () {
//        return this.fname + " " + this.lname;
//    },

//    changeFname: function (fname) {
//        this.fname = fname || this.fname;
//    }
//});

////////////////////////////////////////////////////////////////////////

//var Class.create= function(properties){
//    var theClass=function(){
//        this.init.apply(this, arguments)
//    }

//    theClass.prototype={};
//    for(var prop in properties){
//        theClass.prototype[prop]=properties[prop];
//    }

//    if(!theClass.prototype.init){
//        theClass.prototype.init=function(){}
//    }
    //return theClass;
//}

/////////////////////////////////////////////////////////////////////////

//Function.prototype.inherit = function (parent) {
//    var oldPrototype = this.prototype;
//    var prototype = new parent();
//    this.prototype = Object.create(prototype);
//    this.prototype._super = prototype;
//    for (var prop in oldPrototype) {
//        this.prototype[prop] = oldPrototype[prop];
//    }
//}

//var Person = Class.create({});
//var Student = Class.create({});
//Student.inherit(Person);

/////////////////////////////////////////////////////////////////////

//var Person = {
//    init: function () { },
//    fullname: function(){}
//}

//var pesho = Object.create(Person);
//pesho.init("Peter", "Petrov", "Pesho vodkata");

//var joro = Object.create(Person);
//joro.init("Siabonga", "Nomwete", "Mangala");

//////////////////////////////////////////////////////////////////////


//if (!Object.create) {
//    Object.create = function (obj) {
//        function f() { };
//        f.prototype = obj;
//        return new f();
//    }
//}

///////////////////////////////////////////////////////////////////////

//var Person = {}
//var Student = Person.extend({});

//Object.prototype.extend = function (prperties) {
//    function f() { };
//    f.prototype = Object.create(this);
//    for (var prop in properties) {
//        f.prototype[prop] = properties[prop];
//    }
//    f.prototype._super = this;
//    return new f();
//}

////////////////////////////////////////////////////////////////////////

//var Person = Class.create({
//    init: function (fname, lname) {
//        this.fname = fname;
//        this.lname = lname;
//    },

//    fullName: function () {
//        return this.fname + " " + lname;
//    },

//    changeFName: function (fname) {
//        this.fname = fname || this.fname;
//    }
//});

/////////////////////////////////////////////////////////////////////

//var Person = Class.create({});
//var Student = Class.create({});
//Student.inherit(Person);

//////////////////////////////////////////////////////////////////////

//var Person = {
//    init: function () {
//    },

//    fullName: function () {

//    },
//}

//var pesho = Object.create(Person);
//pesho.init("Pesho", "Siabonga", "Nomweteto");

//var hurencho = Object.create(Person);
//hurencho.init("Huren", "Nlchl", "Caisa");

//var Person = {};
//var Student = Person.extend({});

///////////////////////////////////////////////////////////////////////

//var Person = Class.create({
//    init: function (fname, lname) {
//        this.fname = fname;
//        this.lname = lname;
//    },

//    fullName: function () {
//        return this.fname + " " + lname;
//    },

//    changeFName: function (fname) {
//        this.fname = fname || this.fname;
//    }
//})

////////////////////////////////////////////////////////////////////////

//var Person = Class.create({});
//var Student = Class.create({});
//Student.inherit(Person);

////////////////////////////////////////////////////////////////////////

var Person = {
    init: function () { },
    fullName: function () { }
}

var Siabongcho = Object.create(Person);
Siabongcho.init("Siabonga", "Nomwete", "Jizasa");
var hurencho = Object.create(Person);
hurencho.init("Huren", "Nlchl", "Kilara");

var Person{};
var Student=Person.extend({});
