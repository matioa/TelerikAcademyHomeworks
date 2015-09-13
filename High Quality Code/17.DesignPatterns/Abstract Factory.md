# Abstract Factory Design Pattern
## Intent
 - Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
 - A hierarchy that encapsulates: many possible "platforms", and the construction of a suite of "products".
 - The new operator considered harmful.

## Problem

If an application is to be portable, it needs to encapsulate platform dependencies. These "platforms" might include: windowing system, operating system, database, etc. Too often, this encapsulatation is not engineered in advance, and lots of #ifdef case statements with options for all currently supported platforms begin to procreate like rabbits throughout the code.

## Structure
The Abstract Factory defines a Factory Method per product. Each Factory Method encapsulates the new operator and the concrete, platform-specific, product classes. Each "platform" is then modeled with a Factory derived class.

## Example
The purpose of the Abstract Factory is to provide an interface for creating families of related objects, without specifying concrete classes. This pattern is found in the sheet metal stamping equipment used in the manufacture of Japanese automobiles. The stamping equipment is an Abstract Factory which creates auto body parts. The same machinery is used to stamp right hand doors, left hand doors, right front fenders, left front fenders, hoods, etc. for different models of cars. Through the use of rollers to change the stamping dies, the concrete classes produced by the machinery can be changed within three minutes.

## Check list
1. Decide if "platform independence" and creation services are the current source of pain.
2. Map out a matrix of "platforms" versus "products".
3. Define a factory interface that consists of a factory method per product.
4. Define a factory derived class for each platform that encapsulates all references to the new operator.
5. The client should retire all references to new, and use the factory methods to create the product objects.
