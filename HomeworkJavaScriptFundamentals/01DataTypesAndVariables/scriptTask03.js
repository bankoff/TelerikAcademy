taskName = "DataTypesAndVariables-3";

function Main(bufferElement) {
		
// Numbers		
	WriteLine("Typeof 37 is: " + typeof(37));
	WriteLine("Typeof 3.14 is:" + typeof(3.14));
	WriteLine("Typeof Math.LN2 is:" + typeof(Math.LN2));
	WriteLine("Typeof Infinity is:" + typeof(Infinity));
	WriteLine("Typeof NaN is:" + typeof(NaN));
	WriteLine("Typeof Number(1) is:" + typeof(Number(1)));
	WriteLine();

// Strings
	WriteLine('Typeof "" is:' + typeof(""));
	WriteLine('Typeof "bla" is:' + typeof("bla"));
	WriteLine("Typeof (typeof 1) is:" + typeof(typeof(1)));
	WriteLine();

// Booleans
	WriteLine("Typeof true is:" + typeof(true));
	WriteLine("Typeof false is:" + typeof(false));
	WriteLine("Typeof Boolean(true) is:" + typeof(Boolean(true)));
	WriteLine();

// Undefined
	WriteLine("Typeof undefined is:" + typeof(undefined));
	WriteLine("Typeof blabla is:" + typeof(blabla));
	WriteLine();

// Objects
	WriteLine("Typeof {a:1} is:" + typeof({a:1}));
	WriteLine("Typeof [1, 2, 4] is:" + typeof([1, 2, 4]));
	WriteLine("Typeof new Date() is:" + typeof(new Date()));
	WriteLine("Typeof new Boolean(true) is:" + 
		typeof(new Boolean(true)));
	WriteLine("Typeof new Number(1) is:" + typeof(new Number(1)));
	WriteLine();

// Functions
	WriteLine("Typeof function(){} is:" + typeof(function(){}));
	WriteLine("Typeof Math.sin is:" + typeof(Math.sin));	
}