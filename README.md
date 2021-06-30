# Challenge 01

## *Step#1*

#### Go to **csharp**  -> **GildedRose.cs** -> `UpdateQuality()` function 


## *Step#2*

### **Challenge Requirement**

#### find the code Smell in the function `UpdateQuality()` and Refactor the function.
##### your repo should contain a README file and the refactored function.

- README file contains:

Code Smell:

Definition: 

Solution:


> p.s. your refactored function have to work just like how the old `UpdateQuality()` function was working

---


**recourse**: 
- https://github.com/NotMyself/GildedRose
- http://iamnotmyself.com/2011/02/14/refactor-this-the-gilded-rose-kata/

> please make sure you fork this repo and submit your code as PR.🦾

## Code Smell
Duplicated code.

### Definition
identical code that exists in more than one location.

### Solution
 moving the code into its own method and calling it from all places where it was used.
 
 
## Code Smell
Long method.

### Definition
a method that has grown up too large.

### Solution
a method needs to be broken down into smaller methods.