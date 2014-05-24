Voting System Application  
============================

A simple voting system application in Bangla based on Electoral system of Bangladesh.

![HomePage](https://raw.githubusercontent.com/wasi0013/Voting-System/master/Voting-System-Snapshots/Home.jpg)

Software requirement:
----------------------------
  *Dot net framework 4 or above

Successfully implemented:
-------------------------
  * Home page
  * Admin account (currently uses voterid 13 as admin)
  * Login
  * User registration and signup (With password Strength checker)
  * Quick Vote
  * Vote Clock for all votes (Stable! will work even if the software were closed)
  * Stats (Implemented charts)
  * User information page
  * Quick Vote
  * Local vote
  * City Corporation Vote
  * Upozilla Vote
  * Ctg Hill Area vote
  * Pourashava Vote
  * Team registration and management for National Election
  * Seats Planning 
  * National Election Voting process
  * Master Reset control on Admin
  * National election result
  * History (Impemented some animation with text box and string on Home)   

Still to come:
--------------

  * History of votes
  * More Robust admin page with greater and flexible control and quick access


Some Overview on Cyclomatic Complexity:
---------------------------------------
generated using microsoft visual studio 2010 ultimate 

|Forms And User Control	|Cyclomatic Complexity	|Depth of Inheritance	|Class Coupling	|Lines of Code|
|-----------------------|----------------------|---------------------|---------------|-------------|
|OVS	|390	|7	|101	|4166|
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

Actual lines of code:
---------------------
Using git bash : 25,588 lines [Command: wc -l $(git ls-files)]  
Written code: 4,166 lines  
Automatically generated: rest

Total Work Hour:
-----------------
36 hours and 37 mins