
# State Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Change behavior when the object's state changes.

## Intent

Allow an object to alter its behavior when its internal state changes.

## Problem

VendingMachine uses a large switch on state strings.

## Problem Example

InsertCoin, SelectProduct, and Dispense all contain state conditionals.

## Why Is This a Problem?

State transitions and behavior are tangled in one class.

## Solution

Extract each state into its own class implementing IState.

## Before vs After

### Before

One class with switch/if on current state.

### After

Context delegates to current state object.

## Pattern Structure

```text
VendingMachine -> IState
                   / | \
              Idle HasCoin Dispensing
```

## Participants

VendingMachine, IState, IdleState, HasCoinState, DispensingState

## How It Works

1. Machine holds current state.
2. Action calls state method.
3. State may transition machine to new state.

## When Should I Use It?

- Object behavior changes with state
- Large state-based conditionals
- State transitions are well defined

## When Should I NOT Use It?

- Only 2 simple states
- State rarely changes

## Real-World Examples

- Vending machines
- Order workflows
- Media player play/pause/stop

## How to Remember

"Behavior follows the current mode."

## Key Learning

- Eliminates state switches
- Each state encapsulates behavior
- Transitions localized in state classes
- Context delegates to state

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/State/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/State/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | VendingMachine filled with state switch logic. | State objects encapsulate behavior and transitions. |

