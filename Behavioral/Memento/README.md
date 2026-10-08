
# Memento Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Save a snapshot so you can restore it later.

## Intent

Capture and externalize an object's internal state so it can be restored later.

## Problem

Text editor changes cannot be undone without exposing internal fields.

## Problem Example

No safe way to store previous text state.

## Why Is This a Problem?

Undo requires state storage, but internals should stay private.

## Solution

Editor creates memento snapshots and restores from them.

## Before vs After

### Before

No undo; state management mixed with editing.

### After

Save/restore via memento without breaking encapsulation.

## Pattern Structure

```text
TextEditor -> Save() -> EditorMemento
TextEditor <- Restore()
```

## Participants

TextEditor, EditorMemento

## How It Works

1. Editor saves current state to memento.
2. Editor changes text.
3. Editor restores from memento.

## When Should I Use It?

- Undo functionality
- Snapshots/checkpoints
- State rollback

## When Should I NOT Use It?

- State is trivial
- Full history management needs more than simple memento

## Real-World Examples

- Text editor undo
- Game save points
- Form draft restoration

## How to Remember

"Take a snapshot, rewind later."

## Key Learning

- Preserves encapsulation
- Origin object creates memento
- Caretaker stores mementos
- Foundation for undo systems

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Memento/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Memento/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | No way to undo text changes safely. | Memento stores and restores editor state. |

