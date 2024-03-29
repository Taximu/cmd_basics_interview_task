## Task
Develop a tool that reads input from the command line, parses the input and writes the output to the console.

CONDITIONS
-  The tool should be able to accept any command line parameters, parse them and write the corresponding output to the console.
-  The code should be written in an object oriented way and should show that object oriented design was understood and could be used by the programmer.
-  The code should contain short meaningful comments if necessary.
-  The program should be written in a way that it is flexible for potential future requirements and extensions.
-  Please do not use any frameworks or existing libraries to solve the problem as this would not show how you would solve the problem.

The following shows which are the command line parameters the tools should react on. Furthermore the corresponding 
parsing operation and the expected output for every relevant parameter.

Example
-a [Value 1] [Value 2]
Value 1: Number
Value 2: Number
Value 1 + Value 2

"The sum of [Value 1] and [Value 2] is [Result]."
Input:
-a 5 6
Output:
"The sum of 5 and 6 is 11."

-b [Value 1][Value 2]
Value 1: String
Value 2: Char
Remove the char given in Value 2 from the string Value 1.

"[Value 1] without [Value 2] results in [Result]."
Input:
-b "Microsoft" "t"
Output:
"Microsft" without "t" results in "Microsof".

-c [Value 1][Value 2]
Value 1: Number
Value 2: Natural Number
Value 1 raised to the power of Value 2.

"[Value 1] raised to the power of [Value 2] is [Result]."
Input:
-c 2 3
Output:
"2 raised to the power of 3 is 8."

Please structure the code in a way that additional parameters and operations could be added without much effort.
