/* Task Description */
/*
*
  * use prototypal inheritance, without function constructors---- Y
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
    *
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
    *
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
  *
    * sets the content of the element
    * works only if there are no children    ?????
    *
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
    *
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/

/*
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


//function solve() {
	var domElement = (function () {

		var htmlOutput = [];

		function isValidType (value){
			return /[A-Za-z0-9]+/g.test(value); // tuk za attribute e i dash - , a za tipa nqma uj
		}

		function isValidAttribute (value){
			return /[A-Za-z0-9-]+/g.test(value);
		}

		//parent is a domElement   ?? wtf
		var domElement = {
			init: function (type) {
				this.type = type;
				return this;
			},
			get type() {
				return this._type;
			},
			set type(value) {
				if (isValidType(value)) {
					this._type = value;
				}
				else {
					throw Error('Invalid type');
				}
			},
			get childElements() {
				return this._childElements;
			},
			set childElements(value) {
				if (this.content && this.content.length > 0) {
					this.content = '';
				}
				this._childElements = this._childElements || [];
				this._childElements.push(value);
			},
			get content() {
				return this._content;
			},
			set content(value) {
				//TODO: works only if there are no children
				if (typeof(value) !== 'string') {
					throw new Error('Invalid content');
				}
				this._content = value;
			},
			appendChild: function (child) {
				if (typeof(child) !== 'string' && !domElement.isPrototypeOf(this)) {
					throw Error('This is not correct child');
				}
				this.childElements = child;

				return this;
			},
			addAttribute: function (name, value) {
				if (!isValidAttribute(name)) {
					throw Error('Invalid attribute');
				}
				//attribute logic

				return this;

			},
			removeAttribute: function (attributeToRemove) {
				//tuk shte mahame daden atribut
				//ako ne sushtestvuva Error

				return this;
			},
			get innerHTML() {
				var result = '';
				// <
				// type
				// attr.forEach key + '=' + value ''''
				// childElemetns.forEach -> child.innerHTML
				// >
				return htmlOutput.slice();
			}
		};

		return domElement;
	} ());

//module.exports = solve;


var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta);

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);