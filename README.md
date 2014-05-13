Digital-Voting-System
=====================

A simple voting system application based on Electoral system of Bangladesh

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
   
   

Under Development:
------------------

  * National Election
  * Team registration
  * seats planning
  * Voting process
  * History (Impemented some animation with text box and string on Home) 

Still to come:
--------------

  * History of votes
  * More Robust admin page with greater and flexible control and quick access


Some Overview on Cyclomatic Complexity:
---------------------------------------
|Forms And User Control	|Cyclomatic Complexity	|Depth of Inheritance	|Class Coupling	|Lines of Code|
|-----------------------|----------------------|---------------------|---------------|-------------|
|OVS	|293	|7	|101	|3270|
|Program	|1|	1|	3|	3|
|Main	|1	|0	|3	|3|
|National Election|	5	|7	|14	|20|
|National Election Vote|	11	|7	|21	|121|
|Election|	30	|7	|38|	286|
|Stats	|26	|7	|42|	237|
|Home	|30	|7	|47	|377|
|Quick Vote	|59	|7	|51	|582|
|Signup	|27	|7	|39	|370|
|Standard Vote	|59	|7	|49 |	603|
|User Information|	28	|7|	46|	485|
