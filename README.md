Voting System of Bangladesh
============================

A simple voting system application in Bangla based on Electoral system of Bangladesh.

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

Under Development:
------------------

  * National Election Voting process
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
|OVS	|366	|7	|101	|3794|
|Program	|1|	1|	3|	3|
|Main	|5	|7	|14	|20|
|National Election|	5	|7	|14	|20|
|National Election Vote|	29	|7	|43	|251|
|Election|	36	|7	|38|	328|
|Stats	|26	|7	|42|	237|
|Home	|30	|7	|47	|378|
|Quick Vote	|67	|7	|51	|639|
|Signup	|34	|7	|45	|443|
|Standard Vote	|59	|7	|49 |	603|
|User Information|	38	|7|	50|	589|

Actual lines of code:
---------------------
Using git bash : 24,178 lines [Command: wc -l $(git ls-files)]
Written code: 3,794 lines
Automatically generated: rest