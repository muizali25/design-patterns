
# Chain of Responsibility Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Pass a request along a chain until someone handles it.

## Intent

Avoid coupling the sender of a request to its receiver by giving multiple objects a chance to handle it.

## Problem

One approver class uses if/else for every approval level.

## Problem Example

Supervisor, manager, and director logic live in one method.

## Why Is This a Problem?

Adding a new approval level modifies existing code.

## Solution

Link handlers in a chain; each decides to process or pass along.

## Before vs After

### Before

Monolithic conditional approval logic.

### After

Independent handlers linked together.

## Pattern Structure

```text
Request -> Supervisor -> Manager -> Director
```

## Participants

ApprovalHandler, SupervisorHandler, ManagerHandler, DirectorHandler

## How It Works

1. Request enters first handler.
2. Handler processes if it can.
3. Otherwise forwards to next handler.

## When Should I Use It?

- Multiple handlers for one request
- Handler set may change dynamically
- Sender should not know exact receiver

## When Should I NOT Use It?

- Exactly one handler always processes requests
- Chain order is irrelevant and a simple map suffices

## Real-World Examples

- Purchase approval workflows
- Middleware pipelines
- Logging filters

## How to Remember

"Pass it down the line."

## Key Learning

- Decouples sender and receiver
- Dynamic handler chains
- Each handler has single responsibility
- Order matters

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/ChainOfResponsibility/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/ChainOfResponsibility/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | One class with if/else for all approval levels. | Linked handlers process or forward requests. |

