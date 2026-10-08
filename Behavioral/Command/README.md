
# Command Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Turn an action into an object.

## Intent

Encapsulate a request as an object, letting you parameterize clients with different requests.

## Problem

RemoteControl calls Light methods directly with no way to swap or store actions.

## Problem Example

TurnOn/TurnOff logic is hard-coded in the remote.

## Why Is This a Problem?

Actions cannot be queued, logged, or undone easily.

## Solution

Represent each action as an ICommand object executed by the remote.

## Before vs After

### Before

Invoker tightly coupled to receiver methods.

### After

Invoker executes command objects that call receiver.

## Pattern Structure

```text
RemoteControl -> ICommand -> Light
```

## Participants

ICommand, LightOnCommand, LightOffCommand, RemoteControl, Light

## How It Works

1. Remote stores a command.
2. User presses button.
3. Command executes action on receiver.

## When Should I Use It?

- Undo/redo
- Job queues
- Macro commands
- Decouple invoker from receiver

## When Should I NOT Use It?

- Simple direct method calls with no extra behavior needed

## Real-World Examples

- Undo in text editors
- Transaction logs
- Task scheduling systems

## How to Remember

"Turn an action into an object."

## Key Learning

- Encapsulates requests
- Supports undo and queuing
- Invoker decoupled from receiver
- Easy to add new commands

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Command/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Command/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Remote directly controls light methods. | Commands encapsulate light actions. |

