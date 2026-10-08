
# Observer Pattern

## Category

Behavioral

## Difficulty

Beginner

## 30-Second Explanation

One changes, many get notified.

## Intent

Define a one-to-many dependency so when one object changes state, all dependents are notified.

## Problem

NewsAgency manually notifies each subscriber type with if/else.

## Problem Example

Adding a new subscriber type changes NewsAgency.

## Why Is This a Problem?

Subject knows too much about concrete subscriber classes.

## Solution

Observers implement common interface; subject notifies all through it.

## Before vs After

### Before

Subject contains subscriber-specific logic.

### After

Subject calls Update() on all IObserver instances.

## Pattern Structure

```text
NewsAgency -> IObserver
              /      \
        Email       SMS
```

## Participants

NewsAgency, IObserver, EmailSubscriber, SmsSubscriber

## How It Works

1. Observers subscribe to subject.
2. Subject publishes news.
3. Each observer receives Update().

## When Should I Use It?

- Event notification systems
- UI data binding
- Pub/sub scenarios

## When Should I NOT Use It?

- Only one listener exists
- Order and delivery guarantees are complex (consider event buses)

## Real-World Examples

- Newsletter subscriptions
- Stock price alerts
- UI reacting to model changes

## How to Remember

"One changes, many get notified."

## Key Learning

- Loose coupling between subject and observers
- Dynamic subscribe/unsubscribe
- Basis for event-driven design
- .NET events are related

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Observer/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Observer/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Subject uses if/else for each subscriber type. | IObserver interface enables uniform notifications. |

