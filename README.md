# C# Design Patterns Learning

Learn all **23 Gang of Four (GoF) design patterns** through small, independently runnable **C# / .NET 9** console examples.

Each pattern shows the **problem first**, then the **pattern-based solution**, with a short guide on when to use it — and when not to.

Open `DesignPatternsLearning.sln` in Visual Studio 2022, or run any example from the command line in a few minutes.

## What You Will Learn

- What each pattern solves
- Why the problem exists
- How the pattern changes the design
- When to use it — and when not to
- How to recognize the pattern in real applications

## Quick Links

| Resource | Description |
|----------|-------------|
| [Pattern Map](Pattern-Map.md) | Visual overview of all 23 patterns |
| [Quick Reference](Quick-Reference.md) | One-page cheat sheet |
| [What Pattern Should I Use?](What-Pattern-Should-I-Use.md) | Problem → pattern decision guide |
| [Learning Roadmap](Docs/Learning-Roadmap.md) | Recommended study order |
| [Glossary](Docs/Glossary.md) | Common design terms explained |

## Repository Structure

```text
design-patterns/
├── Creational/     (5 patterns)
├── Structural/     (7 patterns)
├── Behavioral/     (11 patterns)
└── Docs/
```

Each pattern folder contains:

```text
PatternName/
├── README.md       ← Learning guide
├── Problem/        ← Shows the design problem
└── Solution/       ← Applies the pattern
```

## How to Run Examples

### Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (optional, recommended)

### Visual Studio 2022

1. Open `DesignPatternsLearning.sln`
2. In Solution Explorer, navigate to a pattern (e.g. `Behavioral` → `Strategy`)
3. Right-click `Strategy.Problem` or `Strategy.Solution` → **Set as Startup Project**
4. Press **F5**

### Command Line

```bash
# Run a Problem example
dotnet run --project Behavioral/Strategy/Problem

# Run a Solution example
dotnet run --project Behavioral/Strategy/Solution

# Build entire solution
dotnet build DesignPatternsLearning.sln
```

## Learning Approach

For each pattern:

1. Read the pattern **README.md**
2. Run the **Problem** project — understand what's wrong
3. Run the **Solution** project — see the improved design
4. Compare **Before vs After** in the README

## All 23 Patterns

| Pattern | Category | Main Idea | Difficulty |
|---------|----------|-----------|------------|
| [Singleton](Creational/Singleton/README.md) | Creational | One shared instance | Beginner |
| [Factory Method](Creational/FactoryMethod/README.md) | Creational | Delegate object creation | Beginner |
| [Abstract Factory](Creational/AbstractFactory/README.md) | Creational | Create compatible product families | Intermediate |
| [Builder](Creational/Builder/README.md) | Creational | Build complex objects step-by-step | Beginner |
| [Prototype](Creational/Prototype/README.md) | Creational | Clone existing objects | Intermediate |
| [Adapter](Structural/Adapter/README.md) | Structural | Make incompatible interfaces work together | Beginner |
| [Bridge](Structural/Bridge/README.md) | Structural | Separate abstraction from implementation | Intermediate |
| [Composite](Structural/Composite/README.md) | Structural | Treat parts and wholes uniformly | Beginner |
| [Decorator](Structural/Decorator/README.md) | Structural | Add behavior by wrapping | Beginner |
| [Facade](Structural/Facade/README.md) | Structural | Simplify a complex subsystem | Beginner |
| [Flyweight](Structural/Flyweight/README.md) | Structural | Share repeated intrinsic state | Advanced |
| [Proxy](Structural/Proxy/README.md) | Structural | Control access to another object | Intermediate |
| [Chain of Responsibility](Behavioral/ChainOfResponsibility/README.md) | Behavioral | Pass request through handlers | Intermediate |
| [Command](Behavioral/Command/README.md) | Behavioral | Encapsulate an action | Intermediate |
| [Interpreter](Behavioral/Interpreter/README.md) | Behavioral | Define and evaluate a grammar | Advanced |
| [Iterator](Behavioral/Iterator/README.md) | Behavioral | Traverse without exposing internals | Beginner |
| [Mediator](Behavioral/Mediator/README.md) | Behavioral | Centralize object communication | Intermediate |
| [Memento](Behavioral/Memento/README.md) | Behavioral | Save and restore state | Intermediate |
| [Observer](Behavioral/Observer/README.md) | Behavioral | Notify subscribers | Beginner |
| [State](Behavioral/State/README.md) | Behavioral | Behavior changes with state | Intermediate |
| [Strategy](Behavioral/Strategy/README.md) | Behavioral | Interchangeable behavior | Beginner |
| [Template Method](Behavioral/TemplateMethod/README.md) | Behavioral | Fixed workflow, customizable steps | Intermediate |
| [Visitor](Behavioral/Visitor/README.md) | Behavioral | Add operations without changing elements | Advanced |

## Technology

- **C#** with modern syntax
- **.NET 9** console applications
- **Visual Studio 2022** compatible
- No external NuGet packages, databases, or web frameworks

## Philosophy

> Make the design pattern obvious.

Examples are intentionally small. The goal is to understand **what problem you are facing** and **which pattern can help** — not to build a production application.

## License

MIT — free to use for personal learning, revision, interview preparation, and sharing with other developers.
