
# Composite Pattern

## Category

Structural

## Difficulty

Beginner

## 30-Second Explanation

Treat individual items and groups of items the same way.

## Intent

Compose objects into tree structures to represent part-whole hierarchies.

## Problem

Files and folders are handled with different logic, making totals hard to compute.

## Problem Example

Client must special-case folders vs files to calculate size.

## Why Is This a Problem?

Uniform operations require branching and duplicated client logic.

## Solution

Give files and folders a common interface with recursive composition.

## Before vs After

### Before

Separate types with different APIs.

### After

Both implement GetSize(); folders delegate to children.

## Pattern Structure

```text
IFileSystemNode
   /          \
FileItem    Folder
               |
            children
```

## Participants

IFileSystemNode, FileItem, Folder

## How It Works

1. Leaf (file) returns its own size.
2. Composite (folder) sums child sizes.
3. Client treats both uniformly.

## When Should I Use It?

- Tree structures (files, UI components, org charts)
- Client should not distinguish leaf vs composite
- Recursive operations on structures

## When Should I NOT Use It?

- Flat collections with no hierarchy
- Leaf and composite behavior are totally different

## Real-World Examples

- File systems
- UI component trees
- Organization hierarchies

## How to Remember

"One interface for part and whole."

## Key Learning

- Uniform treatment of leaves and composites
- Recursive structure
- Simplifies client code
- Tree operations become natural

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Composite/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Composite/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Files and folders handled separately. | Common interface with recursive folder composition. |

