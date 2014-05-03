taskName = "DataTypesAndVariables-1";

function Main(bufferElement) {
	var intLiteral = 33;
	var floatLiteral = 5.95;
	var boolLiteral = true;
	var strLiteral = "String";
	var arrayLiteral = [44, "Lili", 17];
	var objectLiteral = {
		name: 'Dimo',
		age: 96
	};

	WriteLine( Format("{0} - This literal is integer", intLiteral));
	WriteLine( Format("{0} - This literal is floating-point", 
		floatLiteral));
	WriteLine( Format("{0} - This literal is boolean", boolLiteral));
	WriteLine( Format("{0} - This literal is string", strLiteral));
	WriteLine( Format("{0} - This literal is array", arrayLiteral));
	WriteLine( Format("name:{0}, age:{1} - This literal is object", 
		objectLiteral.name,objectLiteral.age));	
}
