
# Facade Pattern

## Category

Structural

## Difficulty

Beginner

## 30-Second Explanation

One simple door to a complicated building.

## Intent

Provide a unified interface to a set of interfaces in a subsystem.

## Problem

Client must orchestrate amplifier, projector, and lights manually.

## Problem Example

Starting movie mode requires many coordinated subsystem calls.

## Why Is This a Problem?

Client is tightly coupled to subsystem details and steps.

## Solution

Provide HomeTheaterFacade.WatchMovie() that coordinates everything.

## Before vs After

### Before

Client knows every subsystem and sequence.

### After

Client calls one facade method.

## Pattern Structure

```text
Client -> HomeTheaterFacade -> Amplifier
                            -> Projector
                            -> Lights
```

## Participants

HomeTheaterFacade, Amplifier, Projector, Lights

## How It Works

1. Client calls facade.
2. Facade invokes subsystem objects in order.
3. Subsystems remain unchanged.

## When Should I Use It?

- Complex subsystem with many steps
- You want a simple entry point
- Reduce client coupling to internals

## When Should I NOT Use It?

- Subsystem is already simple
- Client needs fine-grained control over every step

## Real-World Examples

- Home theater start button
- Order checkout service
- API gateway simplifying microservices

## How to Remember

"One simple door to a complicated building."

## Key Learning

- Simplifies usage, not subsystem design
- Reduces client coupling
- Does not prevent direct subsystem access
- Great for onboarding developers

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Facade/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Facade/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Client orchestrates many subsystem calls. | Facade exposes one WatchMovie() method. |

