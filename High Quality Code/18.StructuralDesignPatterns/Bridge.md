# Bridge Design Pattern
## Intent
 - Decouple an abstraction from its implementation so that the two can vary independently.
 - Publish interface in an inheritance hierarchy, and bury implementation in its own inheritance hierarchy.
 - Beyond encapsulation, to insulation

## Problem
"Hardening of the software arteries" has occurred by using subclassing of an abstract base class to provide alternative implementations. This locks in compile-time binding between interface and implementation. The abstraction and implementation cannot be independently extended or composed.

## Structure
The Client doesn’t want to deal with platform-dependent details. The Bridge pattern encapsulates this complexity behind an abstraction "wrapper".
Bridge emphasizes identifying and decoupling "interface" abstraction from "implementation" abstraction.

## Example
The Bridge pattern decouples an abstraction from its implementation, so that the two can vary independently. A household switch controlling lights, ceiling fans, etc. is an example of the Bridge. The purpose of the switch is to turn a device on or off. The actual switch can be implemented as a pull chain, simple two position switch, or a variety of dimmer switches.

## Check list
1. Decide if two orthogonal dimensions exist in the domain. These independent concepts could be: abstraction/platform, or domain/infrastructure, or front-end/back-end, or interface/implementation.
2. Design the separation of concerns: what does the client want, and what do the platforms provide.
3. Design a platform-oriented interface that is minimal, necessary, and sufficient. Its goal is to decouple the abstraction from the platform.
4. Define a derived class of that interface for each platform.
5. Create the abstraction base class that "has a" platform object and delegates the platform-oriented functionality to it.
6. Define specializations of the abstraction class if desired.




