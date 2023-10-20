// See https://aka.ms/new-console-template for more information
using System.Text;

for(int i=1;i<=100;i++) {
    var builder = new  StringBuilder();
    if (i % 3 == 0) {
        builder.Append("fizz");
    }
    if (i % 5 == 0) {
        builder.Append("buzz");
    }
    System.Console.WriteLine($"number:{i} result:{builder.ToString()}" );
}

System.Console.WriteLine($"Enter the string to reverse" );  
var text = System.Console.ReadLine();
var reversebuilder = new StringBuilder();
for(int i =text.Length-1;i>=0;i--) {
    reversebuilder.Append(text[i]);
}
System.Console.WriteLine($"string:{text} reverse:{reversebuilder.ToString()}" );
/*
Answers
Part V - Back-end skills (SQL OR LINQ):
1. all the customers whose name begins with "Joe"
    select * from Customer where name like 'Joe%'

2. all the product names ordered by customer "Joe" after ' 11/1/2016'
    select * from Product

*/