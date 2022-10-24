# FibonacciAPIRest
Challenge where build a Fibonacci Api Rest. The http method used is Get, due to more simple to implement than other methods. 
It was used the languague "C#" because I am more acquainted with it.
It was chosen Asp.NetCore because is more desgined to work with different API Webs than
with other platforms. The IDE used was Microsoft Visual Studio, due to is required
for work with Asp.NetCore and it also helps you a lot with identifying code errors and solving them

## Technologies used:
#### Frontend:
-Html
#### FrameWork: 
- Asp.Net Core v2.1
#### IDE:
- Microsoft Visual Studio 2017 
#### Language:
- C#
#### S.O:
- Windows 10

## Requirements: 
 -  Visual Studio 2017 or upper version
 -  .Net Core 2.1 or upper version.
 -  Windows 10 or upper version.

## Running Instructions:
1. Open Visual Studio 2017
2. Open the file "FibonacciAPI.sln"
3. Clean Solution
4. Build Solution 
5. Run Solution and automatic the browser will open.
6. On the url showed in the browser will add the index "n" asked
   for next the program show the result.  

## Algorithm Description:
The algorithm code is written in the "ValluesController.cs" section, Controllers folder.
Two cases are handled:
a) In case the index n entered is any of the first two positions of the Fibonacci series
b) If the index n entered is greater than or equal to 2.

For case a, two if are used to identify n
and then display the result in the browser.

For case b, the variables a,b,c,k and a for-loop are used.
The for loop is used to go over and operate the fibonacci serie.
The variable k marks the beginning of the position of the Fibonacci serie, which is 2. It also acts
as an accountant.
The variable c is an accumulator that displays the final result.
The variables a and b store the information of the last 2 values of the series.


## Optimization:
A better solution is make a form with labels, textbox and button, for 
improve the design and procedure. Also use the http method: Post  with 
the form,  because is a method more safe. On the textbox would put the index "n" asked. 
and through the button would be given the orden for process the program. In a label would 
show the result.


