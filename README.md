Code Smell: Long Method.

Definition: A method that contains too many lines of code.

Solution: As a rule of thumb, if you feel the need to comment on something inside a method, you should take this code and put it in a new method. Even a single line can and should be split off into a separate method, if it requires explanations. And if the method has a descriptive name, nobody will need to look at the code to see what it does.

---

Code Smell: Nested Conditional

Definition: You have a group of nested conditionals and it’s hard to determine the normal flow of code execution.

Solution: Isolate all special checks and edge cases into separate clauses and place them before the main checks. Ideally, you should have a “flat” list of conditionals, one after the other.