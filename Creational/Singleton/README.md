
# Singleton Pattern

## Category

Creational

## Difficulty

Beginner

## 30-Second Explanation

Only one shared instance should exist.

## Intent

Ensure a class has only one instance and provide global access to it.

## Problem

Multiple parts of an application create their own instances of shared configuration, causing inconsistent state.

## Problem Example

Two different AppSettings objects hold different theme values.

## Why Is This a Problem?

There is no single source of truth. Settings can drift apart across the app.

## Solution

Restrict construction and expose one shared instance through a static accessor.

## Before vs After

### Before

Every caller uses 
ew AppSettings() and gets a separate object.

### After

All callers use AppSettings.Instance and share the same object.

## Pattern Structure

```text
Client A ----\
              ---> AppSettings.Instance
Client B ----/
```

## Participants

AppSettings (Singleton)

## How It Works

1. Constructor is private.
2. Static property returns the single instance.
3. All clients use the same reference.

## When Should I Use It?

- Application-wide configuration
- Shared logging gateway
- Single resource manager

## When Should I NOT Use It?

- When testability suffers from global state
- When you need multiple independent instances

## Real-World Examples

- App configuration
- Logger instance
- Connection pool manager

## How to Remember

"One door, one instance."

## Key Learning

- Controls instance count
- Provides global access point
- Use carefully to avoid hidden dependencies
- Lazy initialization is common in C#

## Run the Example

**Problem project:**

```bash
dotnet run --project Creational/Singleton/Problem
```

**Solution project:**

```bash
dotnet run --project Creational/Singleton/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Multiple AppSettings instances with different values. | One shared AppSettings.Instance used everywhere. |

