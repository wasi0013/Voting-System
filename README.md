[Voting System Application](http://wasi0013.github.io/Voting-System)  
============================

A simple voting system application in Bangla based on Electoral system of Bangladesh.

![HomePage](https://raw.githubusercontent.com/wasi0013/Voting-System/master/Voting-System-Snapshots/Home.jpg)

Software requirement:
----------------------------
  * Dot net framework 4 or above([Click to download](http://www.microsoft.com/en-us/download/details.aspx?id=40779))
  * Microsoft SQL Server 2008 or above([Click to download](http://www.microsoft.com/en-us/download/details.aspx?id=29062))  

How to Test it:
---------------
  * Clone this repository
  * Run the "ovs.sql" script from the TestDbScript folder in SQL server management studio to generate the test database
  * Open "ovs.sln" in Visual studio
  * Build and run 


Features:  
------------------------------
  - [x] Home page
  - [x] Admin account (currently uses voterid 13 as admin)
  - [x] Login
  - [x] User registration and signup (With password Strength checker)
  - [x] Quick Vote
  - [x] Vote Clock for all votes (Stable! will work even if the software were closed)
  - [x] Stats (Implemented charts)
  - [x] User information page
  - [x] Quick Vote
  - [x] Local vote
  - [x] City Corporation Vote
  - [x] Upozilla Vote
  - [x] Ctg Hill Area vote
  - [x] Pourashava Vote
  - [x] Team registration and management for National Election
  - [x] Seats Planning 
  - [x] National Election Voting process
  - [x] Master Reset control on Admin
  - [x] National election result
  - [x] History (Some animation with text box and string on Home)
  - [x] Tool tips for English translation of Bangla labels   
  - [ ] History of votes
  - [ ] More Robust admin page with greater and flexible control and quick access


Some Overview on Cyclomatic Complexity:
---------------------------------------
generated using microsoft visual studio 2010 ultimate 

|Forms And User Control	|Cyclomatic Complexity	|Depth of Inheritance	|Class Coupling	|Lines of Code|
|-----------------------|----------------------|---------------------|---------------|-------------|
|OVS	|395	|7	|103	|4304|
|Program	|1|	1|	3|	3|
|Main	|5	|7	|14	|20|
|National Election|	41	|7	|44	|420|
|National Election Vote|	29	|7	|43	|251|
|Election|	37	|7	|38|	324|
|Stats	|26	|7	|42|	237|
|Home	|30	|7	|48	|383|
|Quick Vote	|68	|7	|51	|642|
|Signup	|34	|7	|45	|482|
|Standard Vote	|91	|7	|50 |	778|
|User Information|	41	|7|	52|	689|
|Team Stats| 14|7|36|173|

Lines of code written So far:
-----------------------------
Using git bash : 31,148 lines [Command: wc -l $(git ls-files)]  
Written code: 4,304 lines  
Automatically generated: rest

Total Work Hours:
-----------------
36 hours and 37 mins


Note: This was my "hello world" project on c# (Only for educational purpose)
