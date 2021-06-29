## Code smells in the code:

1. Long Method.
Definition: 
A method contains too many lines of code.

Solution:
Take this code and put it in a new method.
 
2. Duplicate Code.
Definition: 
Two code fragments look almost identical.

Solution:
Use Extract Method. Move duplicated code to a separate new method (or function) and replace the old code with a call to the method.
 


---


**recourse**: 
- https://github.com/NotMyself/GildedRose
- http://iamnotmyself.com/2011/02/14/refactor-this-the-gilded-rose-kata/

> please make sure you fork this repo and submit your code as PR.🦾
