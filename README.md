# C# Design Pattern

Includes a number of simple design pattern examples. This is just a cheat sheet for me and by no means a tutorial or similar how to implement certain patterns. I included a short description for each design pattern here.


## Adapter Pattern
![Adapter Pattern](Images/Adapter.PNG)

When two different system have for example a product with width and height. But in one system the product has a ";" separated string WidthHeight combined and in the other system the width and height are separate float fields. With help of the adapter pattern we can create a common interface for both of the products.

## Abstract Factory
![Abstract Factory Pattern](Images/AbstractFactory.PNG)

Helps for example when you have to edit multiple formats (HTML, plain text). With Abstract Factory we can ensure that the apporiate object sets are created based upon the style of the text. Helps to easily add or remove formats, it helps to ensure a higher level of seperation

## Bridge Pattern
![Bridge Pattern](Images/Bridge.PNG)

Its a composite of the Template and Strategy Pattern. At first sight, the Bridge pattern looks a lot like the Adapter pattern in that a class is used to convert one kind of interface to another. However, the intent of the Adapter pattern is to make one or more classes' interfaces look the same as that of a particular class. The Bridge pattern is designed to separate a class's interface from its implementation so you can vary or replace the implementation without changing the client code.

## Builder Pattern
![Builder Pattern](Images/Builder.PNG)

Helps to create new object by offering a range of different builders to create new objects. For example could a file transfer builder be created and if you want to use FTP you can use the FTP builder. 

## Command Pattern


## Composite Pattern


## Decorator Pattern


## Facade Pattern


## Null-Object Pattern


## Observer Pattern


## Singleton Pattern

## State Pattern

## Strategy Pattern

## Visitor Pattern
