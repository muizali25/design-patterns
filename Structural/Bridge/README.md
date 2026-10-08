
# Bridge Pattern

## Category

Structural

## Difficulty

Intermediate

## 30-Second Explanation

Separate what something is from how it is rendered or implemented.

## Intent

Decouple an abstraction from its implementation so both can vary independently.

## Problem

Combining every shape with every renderer creates a class explosion.

## Problem Example

RedCircleVector, BlueSquareRaster, and many similar classes.

## Why Is This a Problem?

Two dimensions of variation multiply the number of classes.

## Solution

Split shape (abstraction) and renderer (implementation) into separate hierarchies.

## Before vs After

### Before

One class per shape-renderer combination.

### After

Shapes compose with renderers at runtime.

## Pattern Structure

```text
Shape ----> IRenderer
  |            |
Circle     Vector/Raster
Square
```

## Participants

Shape, Circle, Square, IRenderer, VectorRenderer, RasterRenderer

## How It Works

1. Abstraction holds reference to implementation.
2. Shape calls renderer to draw.
3. Shape and renderer vary independently.

## When Should I Use It?

- Two dimensions change independently
- You want to avoid combinatorial subclasses
- Implementation may switch at runtime

## When Should I NOT Use It?

- Only one implementation exists
- Abstraction and implementation always change together

## Real-World Examples

- Shapes and renderers
- Devices and remote controls
- Messages and delivery channels

## How to Remember

"Split the what from the how."

## Key Learning

- Reduces subclass explosion
- Composition over multiplication
- Abstraction and implementation evolve separately
- Different from Adapter

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Bridge/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Bridge/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Class explosion for shape-renderer pairs. | Shapes delegate drawing to interchangeable renderers. |

