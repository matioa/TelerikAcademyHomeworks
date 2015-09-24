# Visitor Design Pattern
### Intent
 - Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.
 - The classic technique for recovering lost type information.
 - Do the right thing based on the type of two objects.
 - Double dispatch

### Problem
Many distinct and unrelated operations need to be performed on node objects in a heterogeneous aggregate structure. You want to avoid "polluting" the node classes with these operations. And, you don't want to have to query the type of each node and cast the pointer to the correct type before performing the desired operation.

### Structure
The Element hierarchy is instrumented with a "universal method adapter". The implementation of accept() in each Element derived class is always the same. But – it cannot be moved to the Element base class and inherited by all derived classes because a reference to this in the Element class always maps to the base type Element.

![Visitor UML](https://static.dzone.com/dz1/dz-files/visitor_pattern.png)

### Example
The Visitor pattern represents an operation to be performed on the elements of an object structure without changing the classes on which it operates. This pattern can be observed in the operation of a taxi company. When a person calls a taxi company (accepting a visitor), the company dispatches a cab to the customer. Upon entering the taxi the customer, or Visitor, is no longer in control of his or her own transportation, the taxi (driver) is.