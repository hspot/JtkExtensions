# Jtk.Extensions
- Jtk.Extensions is a set of common extension and helper methods.

## Object Extension Methods
Extension method for all objects

### IsNull() and IsNotNull()
Instead of `testObject == null` or `testObject != null`, use the following to produce more readeable and less error-prone code:
```
testObject.IsNull();
tetstObject.IsNotNull()
```

### ToObject<T>()
Convert dictionary of object fields and values to the original object
```
objectFieldList.ToObject<Company>();
```

### NullSafe()
Check the object and use a default object for he type if the object is when evaluating the expression for that object. Optionally, provide a default value for when the object is null.
```
Zip5 = contact.Address.NullSafe(a => a.Zip5);
DOBDay = contact.Dob.NullSafe(d => d.Day, 1);

var contact = result.Where(contact => contact.Address.NullSafe(i => i.City.IsNotNullOrEmpty());
```

## String Extension Methods
Extension method for strings

### NullSafe()
Check the string and use an empty string if the string object is null when performing an operation on the string.
```
nullString.NullSafe().Length
```

### IsNullOrEmpty() and IsNotNullOrEmpty()
Instead of using `"blah" != null` or `string.IsNullOrEmpty(mystring)`, use the following to produce more readable code:
```
var fileName = fileVariable.IsNullOrEmpty()  ? _defaultFileName : fileNameOther;

if(firstName.IsNotNullOrEmpty) 
{...}
```

### IsNullOrWhiteSpace() and IsNotNullOrWhiteSpace()
Instead of using `" ".All(char.IsWhiteSpace)` or `string.IsNullOrWhiteSpace(mystring)`, use the following to produce more readable code:
```
var fileName = nameVariable.IsNullOrWhiteSpace()  ? _defaultFileName : fileNameOther;

if(firstName.IsNullOrWhiteSpace) 
{...}
```

### int? TryParse()
Parse string into a nullable integer type without causing exception. Instead of `int.Parse("")` or `int output; int.TryParse(input, output)`, use the following to produce more readable and safer code: 
```
int? myInt = "".TryParse();
int? myInt = "1234".TryParse();
```

## Enumerable Extension Methods
Extension method for Enumerable types such as List, HashTable, etc.

### IEnumerable<T> NullSafe<T>()
Return calling collection if not null, otherwise return an empty collection
```
foreach (Contact contact in contacts.NullSafe()) {...}
```

### NullSafeCount<T>()
Return collection count is not null, otherwise return count of 0
```
var hasData = contacts.NullSafeCount() > 0 ? true : false;
```

### IsNullOrEmpty<T>() and  IsNotNullOrEmpty<T>()
Return whether the collection is null or empty or is not null and empty.
```
if (contacts.IsNullOrEmpty())

contact = results.Where(contact => contact.Address.NullSafe(i => i.City.IsNotNullOrEmpty())
```