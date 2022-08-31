const bool = true;
typeof bool; // 'boolean'

const num = 17;
typeof num; // 'number'

const str = "String";
typeof str; // 'string'

const bigInt = BigInt(2n);
typeof bigInt; // 'bigint'

const nullVar = null;
typeof null; // 'object'

const undefinedVar = undefined;
typeof undefinedVar; // 'undefined'

const arr = ["Alex", 17, "Mike", bool];
typeof arr; // 'object'

const obj = {
  firstName: "John",
  lastName: "Doe",
};
typeof obj; // 'object'
