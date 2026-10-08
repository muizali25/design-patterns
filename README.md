# C# Design Patterns Learning Repository

A clean, beginner-friendly learning repository for all **23 Gang of Four (GoF) Design Patterns**, implemented as small, independently runnable **C# / .NET 9 Console** examples.

Open `DesignPatternsLearning.sln` in **Visual Studio 2022** and explore each pattern in 2–5 minutes.

## What You Will Learn

- What each pattern solves
- Why the problem exists
- How the pattern changes the design
- When to use the pattern
- When not to use it
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
DesignPatternsLearning/
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

### Visual Studio 2022

1. Open `DesignPatternsLearning.sln`
2. In Solution Explorer, navigate to a pattern (e.g., `Behavioral` → `Strategy`)
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
| Singleton | Creational | One shared instance | Beginner |
| Factory Method | Creational | Delegate object creation | Beginner |
| Abstract Factory | Creational | Create compatible product families | Intermediate |
| Builder | Creational | Build complex objects step-by-step | Beginner |
| Prototype | Creational | Clone existing objects | Intermediate |
| Adapter | Structural | Make incompatible interfaces work together | Beginner |
| Bridge | Structural | Separate abstraction from implementation | Intermediate |
| Composite | Structural | Treat parts and wholes uniformly | Beginner |
| Decorator | Structural | Add behavior by wrapping | Beginner |
| Facade | Structural | Simplify complex subsystem | Beginner |
| Flyweight | Structural | Share repeated intrinsic state | Advanced |
| Proxy | Structural | Control access to another object | Intermediate |
| Chain of Responsibility | Behavioral | Pass request through handlers | Intermediate |
| Command | Behavioral | Encapsulate an action | Intermediate |
| Interpreter | Behavioral | Define and evaluate a grammar | Advanced |
| Iterator | Behavioral | Traverse without exposing internals | Beginner |
| Mediator | Behavioral | Centralize object communication | Intermediate |
| Memento | Behavioral | Save and restore state | Intermediate |
| Observer | Behavioral | Notify subscribers | Beginner |
| State | Behavioral | Behavior changes with state | Intermediate |
| Strategy | Behavioral | Interchangeable behavior | Beginner |
| Template Method | Behavioral | Fixed workflow, customizable steps | Intermediate |
| Visitor | Behavioral | Add operations without changing elements | Advanced |

## Technology

- **C#** with modern syntax
- **.NET 9** Console Applications
- **Visual Studio 2022** compatible
- No external NuGet packages, databases, or web frameworks

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (optional, recommended)

## Philosophy

> Make the Design Pattern obvious.

Examples are intentionally small. The goal is to understand **what problem you are facing** and **which pattern can help** — not to build a production application.

## License

Free to use for personal learning, revision, interview preparation, and sharing with other developers.
