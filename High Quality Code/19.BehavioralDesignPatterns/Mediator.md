# Mediator Design Pattern

### Before Mediator Design Pattern
Complex interaction between objects creates dependency and tighter coupling. We stand for loose coupling, we want to reduce dependency as much as possible, we want more reuse. 

![Before UML](http://javapapers.com/wp-content/uploads/2013/01/MediatorProblem.png)
### After Mediator Design Pattern
Define an object that acts as a mediator between communicating objects thus removing the direct dependency between those communicating objects. This mediator object encapsulates the interaction information and uses it to enable communication between the objects.

![After UML](http://javapapers.com/wp-content/uploads/2013/01/Mediator.png)

The intermediate mediator object is not only to communicate between two objects, but it helps in interaction for a set of peer objects. This mediator object is like a router in networks, which is routes / controls or coordinates communication between systems.

### Example
Air traffic controller (ATC) is a mediator between flights. It helps in communication between flights and co-oridates/controls landing, take-off. Two flights need not interact directly and there is no dependency between them. This dependency is solved by the mediator ATC. If ATC is not there all the flights have to interact with one another and managing the show will be very difficult and things may go wrong.

### Implementation
In a mediator design pattern implementation we will have 
 - **mediator interface** – an interface that defines the communication rules between objects
 - **concrete mediator** – a mediator object which will enables communication between participating objects
 - **colleague** – objects communicating with each other through mediator object 
