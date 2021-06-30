### Code Smell: 
1) Deeply Nested Code
2) Duplicated Code
3) Long Methods

### Definition: 
These are considered a code smell because it's hard for other programmers to understand the code. It'll take them a very long time just to understand the code itself and what it does.
#### 1. Deeply Nested Code
It is when you have multiple nested conditional block inside of each other.
#### 2. Duplicated Code
It is when a code has a lot of duplication and repitition. It makes the code hard to understand and also hard to maintain
#### 3. Long Methods
When a function is very long and it has mutiple functionalities or things to do. Long code takes time to read and fully understand.

### Solution:
What I did to solve the problem was create three boolean functions. One that checked the validity of the name, the other checked if the quality was positive and the last one checked if the quality was less than fifty. This way I don't need to repeat the same code over and over again with ambiguous meaning, I can just use the functions I created which you can easily understand by just reading the name of the function and it helps you not repeat the code. I also combined some of the if statements inside of each other and some of them I dragged them outside of the nested if, so it won't have so many nested if statements inside of each other.


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
