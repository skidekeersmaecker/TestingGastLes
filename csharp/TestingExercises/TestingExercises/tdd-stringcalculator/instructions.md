String Calculator Kata by Roy Osherove
===

Instructions:
* Part 1: [basic TDD](http://osherove.com/tdd-kata-1/)
* Part 2: [interactions](http://osherove.com/tdd-kata-2/)

Some useful C# methods:

* Parse a number from a string
  ```csharp
  string text = "12";
  int number = System.Int32.Parse(s); //12
  ```

* Split a string delimited by a specified character
```csharp
string input = "1,2,3";
string[] parts = input.Split(','); //string[3] { "1", "2", "3" }
```
