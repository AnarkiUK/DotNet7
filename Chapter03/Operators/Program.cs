using static System.Console;

int a = 3;
int b = a++; // Assignment happens before the increment (postfix operator)
WriteLine($"a is {a} | b is {b}");

int c = 3;
int d = ++c; // Increment happens before the assignment (prefix operator)
WriteLine($"c is {c} | d is {d}");

/* Good practice:
*  Never combine the use of ++ and -- operators with
*  an assignment operator (=). Perform the operations
*  as separate statements. This is due to confusion
*  between prefix and postfix when combined with
*  an assignment.
*/