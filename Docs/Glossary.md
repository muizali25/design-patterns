# Glossary

Short, beginner-friendly definitions for terms used throughout this repository.

## Coupling

How much one part of code depends on another. **Low coupling** is generally better because changes in one place cause fewer changes elsewhere.

## Cohesion

How focused a class or module is on a single purpose. **High cohesion** means a class does one thing well.

## Abstraction

Hiding unnecessary details and exposing only what matters. Interfaces and abstract classes are common abstraction tools.

## Encapsulation

Keeping data and behavior inside a class and controlling access through methods or properties.

## Interface

A contract that defines what a class must do, without specifying how. In C#, interfaces start with `I` by convention (e.g., `IPaymentStrategy`).

## Composition

Building behavior by combining objects ("has-a" relationship). Example: a `PaymentProcessor` **has** an `IPaymentStrategy`.

## Inheritance

Deriving a class from a base class ("is-a" relationship). Example: `CreditCardStrategy` **is** an `IPaymentStrategy` implementation.

## Polymorphism

Using a base type or interface to refer to different concrete implementations. The same call can behave differently depending on the actual object.

## SOLID

Five design principles for maintainable object-oriented code:

- **S** — Single Responsibility
- **O** — Open/Closed
- **L** — Liskov Substitution
- **I** — Interface Segregation
- **D** — Dependency Inversion

## Open/Closed Principle

Classes should be **open for extension** but **closed for modification**. You add new behavior without changing existing tested code.

## Dependency

When one class needs another class to work. Design patterns often reduce direct dependencies.

## Delegation

Asking another object to perform work instead of doing it yourself. Example: `PaymentProcessor` delegates payment to `IPaymentStrategy`.

## Composition Over Inheritance

Prefer combining objects over deep inheritance hierarchies. It usually leads to more flexible and maintainable designs.

## Client

The code that uses a pattern's components. The client depends on abstractions, not concrete details.

## Context

The class that uses a strategy, state, or similar pattern participant. Example: `PaymentProcessor` is the context in the Strategy pattern.

## Concrete Class

A specific implementation, not an abstract definition. Example: `CreditCardStrategy`.

## Subsystem

A group of related classes that work together. Facade simplifies access to a subsystem.

## Intrinsic vs Extrinsic State (Flyweight)

- **Intrinsic** — Shared, reusable data (e.g., tree type name, texture)
- **Extrinsic** — Unique per-object data (e.g., tree position x, y)

## GoF

**Gang of Four** — the four authors of the classic design patterns book that defined these 23 patterns.
