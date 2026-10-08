# Quick Reference

A short cheat sheet for all 23 GoF Design Patterns.

## By Problem

```text
Need a single shared instance?
→ Singleton

Need to delegate object creation?
→ Factory Method

Need to create families of related objects?
→ Abstract Factory

Need to build a complex object step-by-step?
→ Builder

Need to copy existing objects instead of rebuilding?
→ Prototype

Need incompatible interfaces to work together?
→ Adapter

Need two dimensions of variation independently?
→ Bridge

Need to treat individual and group objects the same?
→ Composite

Need to add behavior without changing the original class?
→ Decorator

Need to simplify a complex subsystem?
→ Facade

Need to share repeated intrinsic state?
→ Flyweight

Need to control access to an expensive object?
→ Proxy

Need to pass a request through a chain of handlers?
→ Chain of Responsibility

Need to represent an action as an object?
→ Command

Need to interpret a simple language or grammar?
→ Interpreter

Need to traverse a collection without exposing internals?
→ Iterator

Need to reduce direct communication between objects?
→ Mediator

Need to save and restore object state?
→ Memento

Need to notify many objects when something changes?
→ Observer

Need behavior to change when internal state changes?
→ State

Need interchangeable algorithms or behaviors?
→ Strategy

Need a fixed workflow with customizable steps?
→ Template Method

Need to add operations without changing element classes?
→ Visitor
```

## By Category

### Creational
- **Singleton** — One shared instance
- **Factory Method** — Subclasses decide what to create
- **Abstract Factory** — Create compatible product families
- **Builder** — Step-by-step object construction
- **Prototype** — Clone existing objects

### Structural
- **Adapter** — Interface conversion
- **Bridge** — Separate abstraction from implementation
- **Composite** — Tree structures with uniform treatment
- **Decorator** — Wrap to add behavior
- **Facade** — Simple entry point to complex system
- **Flyweight** — Share intrinsic state
- **Proxy** — Surrogate with controlled access

### Behavioral
- **Chain of Responsibility** — Pass request along handlers
- **Command** — Encapsulate requests as objects
- **Interpreter** — Grammar-based evaluation
- **Iterator** — Sequential access without exposing structure
- **Mediator** — Centralize communication
- **Memento** — Capture and restore state
- **Observer** — Publish/subscribe notifications
- **State** — State-specific behavior
- **Strategy** — Swappable algorithms
- **Template Method** — Skeleton algorithm with hooks
- **Visitor** — External operations on object structure
