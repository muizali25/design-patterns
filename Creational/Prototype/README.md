
# Prototype Pattern

## Category

Creational

## Difficulty

Intermediate

## 30-Second Explanation

Copy an existing object instead of creating from scratch.

## Intent

Create new objects by copying an existing instance (prototype).

## Problem

Creating similar objects repeatedly repeats expensive initialization.

## Problem Example

Each report reloads templates and formatting from scratch.

## Why Is This a Problem?

Setup cost is paid every time even when objects are nearly identical.

## Solution

Create one prototype and clone it for new instances.

## Before vs After

### Before

Every new report runs full initialization.

### After

Prototype is initialized once; clones reuse prepared state.

## Pattern Structure

```text
Report (prototype)
     |
   Clone()
     |
  Report copy
```

## Participants

IPrototype, Report

## How It Works

1. Prototype is configured once.
2. Client calls Clone().
3. New object starts with copied state.

## When Should I Use It?

- Object creation is expensive
- Objects differ only slightly
- You want to avoid subclassing for variations

## When Should I NOT Use It?

- Objects are cheap to create
- Deep copying is complex and risky

## Real-World Examples

- Document templates
- Game enemy spawning
- Configured form defaults

## How to Remember

"Copy the finished example."

## Key Learning

- Avoids repeated setup cost
- Clone instead of rebuild
- Watch out for shallow vs deep copy
- Useful when types are configured at runtime

## Run the Example

**Problem project:**

```bash
dotnet run --project Creational/Prototype/Problem
```

**Solution project:**

```bash
dotnet run --project Creational/Prototype/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Expensive initialization runs for every report. | Clone a prepared prototype report. |

