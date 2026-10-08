
# Proxy Pattern

## Category

Structural

## Difficulty

Intermediate

## 30-Second Explanation

Stand in for the real object and control when it is used.

## Intent

Provide a surrogate or placeholder to control access to another object.

## Problem

Creating real images loads from disk immediately, even if never displayed.

## Problem Example

Expensive loading happens at construction time.

## Why Is This a Problem?

Performance suffers when heavy resources are created too early.

## Solution

Proxy implements the same interface and creates the real image on first use.

## Before vs After

### Before

Client always triggers immediate expensive loading.

### After

Proxy delays loading until Display() is called.

## Pattern Structure

```text
Client -> IImage -> ImageProxy -> RealImage
```

## Participants

IImage, ImageProxy, RealImage

## How It Works

1. Client uses proxy as if it were real image.
2. Proxy creates real object lazily.
3. Subsequent calls reuse loaded object.

## When Should I Use It?

- Lazy loading
- Access control
- Remote objects
- Logging or caching wrappers

## When Should I NOT Use It?

- Object creation is cheap
- You always need the real object immediately

## Real-World Examples

- Lazy image loading
- Virtual proxy for large files
- Protection proxy for permissions

## How to Remember

"A stand-in that controls access."

## Key Learning

- Same interface as real subject
- Controls creation or access
- Lazy initialization is common
- Related to Decorator but different intent

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Proxy/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Proxy/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Images load immediately on creation. | Proxy delays loading until display. |

