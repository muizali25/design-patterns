# What Pattern Should I Use?

A simple decision guide: **"I have this problem — which pattern should I consider?"**

## Creational Patterns

```text
I need exactly one shared instance across the app
        ↓
     Singleton

I need to create objects without naming concrete classes in client code
        ↓
     Factory Method

I need to create groups of related objects that must stay compatible
        ↓
     Abstract Factory

I need to build a complex object with many optional parts
        ↓
     Builder

I need to create new objects by copying an existing one
        ↓
     Prototype
```

## Structural Patterns

```text
I have a class with the wrong interface for my client
        ↓
     Adapter

I have a combinatorial explosion of classes (type × implementation)
        ↓
     Bridge

I need to treat individual items and groups of items the same way
        ↓
     Composite

I need to add features without creating many subclasses
        ↓
     Decorator

I need to hide complexity behind one simple method
        ↓
     Facade

I am creating many similar objects with repeated shared data
        ↓
     Flyweight

I need to control access to an expensive or remote object
        ↓
     Proxy
```

## Behavioral Patterns

```text
I need to pass a request through multiple possible handlers
        ↓
     Chain of Responsibility

I need to turn actions into objects (undo, queue, log)
        ↓
     Command

I need to evaluate a simple language or rule grammar
        ↓
     Interpreter

I need to walk through a collection without exposing its internals
        ↓
     Iterator

I have too many objects talking directly to each other
        ↓
     Mediator

I need undo/restore without exposing internal object details
        ↓
     Memento

I need many objects to react when one object changes
        ↓
     Observer

An object's behavior should change when its state changes
        ↓
     State

I need to switch algorithms or behaviors at runtime
        ↓
     Strategy

I have similar workflows with only a few steps that differ
        ↓
     Template Method

I need new operations on a stable class hierarchy
        ↓
     Visitor
```

## Quick Decision Table

| If you need to... | Consider |
|-------------------|----------|
| Share one instance | Singleton |
| Delegate creation to subclasses | Factory Method |
| Create compatible product families | Abstract Factory |
| Build step-by-step | Builder |
| Clone instead of rebuild | Prototype |
| Make interfaces compatible | Adapter |
| Separate two dimensions of change | Bridge |
| Treat parts and wholes uniformly | Composite |
| Add behavior dynamically | Decorator |
| Simplify a complex subsystem | Facade |
| Reduce memory for similar objects | Flyweight |
| Control object access | Proxy |
| Route requests through handlers | Chain of Responsibility |
| Encapsulate actions | Command |
| Parse/evaluate simple grammar | Interpreter |
| Traverse without exposing structure | Iterator |
| Reduce object-to-object coupling | Mediator |
| Save and restore state | Memento |
| Notify on changes | Observer |
| Behavior depends on state | State |
| Swap algorithms | Strategy |
| Reuse workflow skeleton | Template Method |
| Add operations externally | Visitor |
