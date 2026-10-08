# Learning Roadmap

A recommended path for learning all 23 GoF Design Patterns in this repository.

## STEP 1 — Understand OOP Fundamentals

Before patterns, make sure you understand:

- Classes and objects
- Interfaces and abstraction
- Inheritance vs composition
- Polymorphism

Patterns build on these ideas. If OOP feels unclear, spend time here first.

## STEP 2 — Start with Easier Creational Patterns

These patterns solve common object-creation problems and are easy to recognize.

1. **Singleton** — One shared instance
2. **Factory Method** — Delegate object creation
3. **Builder** — Step-by-step construction

Why start here? Creation problems appear early in design discussions, and the examples are small.

## STEP 3 — Learn Common Structural Patterns

These patterns appear frequently in real codebases.

1. **Adapter** — Make incompatible interfaces work together
2. **Decorator** — Add behavior by wrapping
3. **Facade** — Simplify complex subsystems
4. **Composite** — Treat individual and group objects uniformly

Why next? These patterns help you improve structure without rewriting everything.

## STEP 4 — Learn Common Behavioral Patterns

These solve everyday behavior and communication problems.

1. **Strategy** — Interchangeable algorithms
2. **Observer** — Notify subscribers on change
3. **Command** — Encapsulate actions as objects
4. **State** — Behavior changes with state

Why next? They reduce large conditional logic and improve flexibility.

## STEP 5 — Learn the Remaining Patterns

Once the common patterns feel familiar, continue with:

| Pattern | Category |
|---------|----------|
| Abstract Factory | Creational |
| Prototype | Creational |
| Bridge | Structural |
| Proxy | Structural |
| Flyweight | Structural |
| Chain of Responsibility | Behavioral |
| Interpreter | Behavioral |
| Iterator | Behavioral |
| Mediator | Behavioral |
| Memento | Behavioral |
| Template Method | Behavioral |
| Visitor | Behavioral |

Why last? These are still important, but often appear in more specific scenarios.

## Suggested Study Method

For each pattern in this repository:

1. Read the **30-Second Explanation**
2. Run the **Problem** project
3. Read **Why Is This a Problem?**
4. Run the **Solution** project
5. Compare **Before vs After**
6. Review **When Should I Use It?**

Spend 5–10 minutes per pattern. Revisit the [Quick Reference](../Quick-Reference.md) for revision.

## Interview Preparation Order

If preparing for interviews, prioritize:

1. Singleton, Factory Method, Builder
2. Adapter, Decorator, Facade
3. Strategy, Observer, Command, State
4. Remaining patterns for completeness

## After Completing All Patterns

- Use [What Pattern Should I Use?](../What-Pattern-Should-I-Use.md) when facing design problems
- Re-run examples you found difficult
- Try recognizing patterns in frameworks and libraries you use daily
