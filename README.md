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


## Code Smell
Duplicated code.

### Definition
identical code that exists in more than one location.

### Solution
 moving the code into its own method and calling that method from all of the places where it was originally used.
 
 
## Code Smell
Long method.

### Definition
a method that has grown too large.

### Solution
a method needs to be broken up into smaller methods.

## Code Smell
Arrow-like nested if statements 

### Definition
```
 if
   if
     if
       if
         do something
       endif
     endif
   endif
 endif
```
### Solution
refactor the code to use the guard clause instead
