
# Iterator Pattern

## Category

Behavioral

## Difficulty

Beginner

## 30-Second Explanation

Walk through a collection without knowing how it is stored.

## Intent

Provide a way to access elements of a collection sequentially without exposing its representation.

## Problem

Client accesses BookCollection.Books directly as a List<Book>.

## Problem Example

Changing internal storage breaks all client code.

## Why Is This a Problem?

Internal structure is exposed; encapsulation is lost.

## Solution

Implement IEnumerable<Book> so clients use standard iteration.

## Before vs After

### Before

Public list exposed to clients.

### After

Collection exposes iterator; storage is private.

## Pattern Structure

```text
Client -> foreach -> BookCollection
                         |
                      private list
```

## Participants

BookCollection, Book

## How It Works

1. Collection implements IEnumerable.
2. Client uses foreach.
3. Internal storage can change safely.

## When Should I Use It?

- Hide collection internals
- Provide uniform traversal
- Support multiple iteration strategies

## When Should I NOT Use It?

- .NET collections already provide iterators
- You need direct index access for performance

## Real-World Examples

- Custom collections
- Paginated data sources
- Tree traversal

## How to Remember

"Walk the collection, hide the storage."

## Key Learning

- Encapsulates traversal
- Client independent of structure
- Built into C# with foreach
- Supports multiple iterators

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Iterator/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Iterator/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Internal list exposed publicly. | IEnumerable hides storage behind iteration. |

