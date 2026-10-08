
# Flyweight Pattern

## Category

Structural

## Difficulty

Advanced

## 30-Second Explanation

Share repeated data instead of storing it in every object.

## Intent

Use sharing to support large numbers of fine-grained objects efficiently.

## Problem

Thousands of trees each store duplicate name, color, and texture data.

## Problem Example

Memory grows quickly when intrinsic data is duplicated.

## Why Is This a Problem?

Most tree data is identical; only position differs.

## Solution

Extract shared TreeType and reuse it across many tree instances.

## Before vs After

### Before

Every tree stores full type information.

### After

Trees reference shared flyweight types; only x/y are unique.

## Pattern Structure

```text
TreeTypeFactory -> TreeType (shared)
                      ^
                   Tree (x,y)
```

## Participants

TreeTypeFactory, TreeType, Tree

## How It Works

1. Factory returns shared TreeType.
2. Tree stores extrinsic coordinates.
3. Draw combines shared and unique state.

## When Should I Use It?

- Many similar objects
- Intrinsic state can be shared
- Memory is a concern

## When Should I NOT Use It?

- Objects are mostly unique
- Shared state changes frequently

## Real-World Examples

- Game forests and tiles
- Text editor character formatting
- Map markers with shared icons

## How to Remember

"Share the repeating parts."

## Key Learning

- Separates intrinsic vs extrinsic state
- Reduces memory usage
- Factory caches shared objects
- Trade complexity for efficiency

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Flyweight/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Flyweight/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Each tree duplicates type data. | Shared TreeType flyweights reduce duplication. |

