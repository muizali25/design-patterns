
# Mediator Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Stop objects from talking directly; talk through a mediator.

## Intent

Define an object that encapsulates how a set of objects interact.

## Problem

Chat users send messages directly to each other.

## Problem Example

Every user must know about every other user.

## Why Is This a Problem?

Adding users increases direct connections dramatically.

## Solution

Route all messages through a ChatMediator.

## Before vs After

### Before

Many direct object-to-object references.

### After

Users communicate only with mediator.

## Pattern Structure

```text
Alice ----\
           ChatMediator
Bob --------/
```

## Participants

ChatMediator, ChatUser

## How It Works

1. Users register with mediator.
2. User sends message to mediator.
3. Mediator distributes to others.

## When Should I Use It?

- Many objects interact in complex ways
- Direct references create spaghetti coupling
- Interaction rules change often

## When Should I NOT Use It?

- Only two objects communicate
- Mediator becomes a god object

## Real-World Examples

- Chat rooms
- Air traffic control
- UI dialog coordinators

## How to Remember

"Everyone talks to the middle person."

## Key Learning

- Reduces direct dependencies
- Centralizes interaction logic
- Easier to change communication rules
- Watch mediator complexity

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Mediator/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Mediator/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Users send direct messages to each other. | Mediator routes all chat messages. |

