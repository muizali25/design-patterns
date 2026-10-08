# Pattern Map

Visual overview of all 23 GoF Design Patterns.

```text
                    DESIGN PATTERNS
                          |
        +-----------------+-----------------+
        |                 |                 |
   CREATIONAL         STRUCTURAL       BEHAVIORAL
        |                 |                 |
    Singleton           Adapter          Chain of Responsibility
    Factory Method      Bridge           Command
    Abstract Factory    Composite        Interpreter
    Builder             Decorator        Iterator
    Prototype           Facade           Mediator
                        Flyweight        Memento
                        Proxy            Observer
                                         State
                                         Strategy
                                         Template Method
                                         Visitor
```

## Creational (5)

| Pattern | Main Idea |
|---------|-----------|
| Singleton | One shared instance across the application |
| Factory Method | Let subclasses decide which object to create |
| Abstract Factory | Create families of related objects together |
| Builder | Construct complex objects step-by-step |
| Prototype | Clone existing objects instead of rebuilding |

## Structural (7)

| Pattern | Main Idea |
|---------|-----------|
| Adapter | Convert one interface into another |
| Bridge | Split abstraction and implementation |
| Composite | Treat individual and group objects uniformly |
| Decorator | Add behavior by wrapping objects |
| Facade | Provide one simple interface to a complex subsystem |
| Flyweight | Share repeated intrinsic state to save memory |
| Proxy | Control access to another object |

## Behavioral (11)

| Pattern | Main Idea |
|---------|-----------|
| Chain of Responsibility | Pass a request through a chain of handlers |
| Command | Represent actions as objects |
| Interpreter | Define and evaluate a simple grammar |
| Iterator | Traverse collections without exposing internals |
| Mediator | Centralize communication between objects |
| Memento | Save and restore object state safely |
| Observer | Notify subscribers when something changes |
| State | Change behavior when internal state changes |
| Strategy | Swap interchangeable algorithms at runtime |
| Template Method | Define algorithm skeleton with customizable steps |
| Visitor | Add operations without changing element classes |
