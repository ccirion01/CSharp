using NamedOptionalParameters;

Named.PrintOrderDetails(orderNo: 1, sellerName: "Juanita", productName: "Mouse");
Named.PrintOrderDetails(sellerName: "Juanita", orderNo: 1, "Mouse");
Named.PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
Named.PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");

Optional.ExampleMethod(1);
Optional.ExampleMethod(1, "string");
//Si no queres pasarle el segundo parametro opcional, pero si el tercero, podes usar un Named argument:
Optional.ExampleMethod(1, optionalEnum: XEnum.Value1);
Optional.ExampleMethod(1, "string", optionalEnum2: XEnum.Value1);