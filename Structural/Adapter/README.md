
# Adapter Pattern

## Category

Structural

## Difficulty

Beginner

## 30-Second Explanation

Convert one interface into another interface the client understands.

## Intent

Convert the interface of a class into another interface clients expect.

## Problem

A client expects IPrinter, but only a legacy printer with a different method exists.

## Problem Example

Client cannot call LegacyPrinter because method names and signatures differ.

## Why Is This a Problem?

Rewriting legacy code is costly; the client should not depend on incompatible APIs.

## Solution

Wrap the legacy class in an adapter that implements the expected interface.

## Before vs After

### Before

Client and legacy class speak different interfaces.

### After

Adapter translates calls from IPrinter.Print() to legacy methods.

## Pattern Structure

```text
Client -> IPrinter -> Adapter -> LegacyPrinter
```

## Participants

IPrinter, LegacyPrinterAdapter, LegacyPrinter, PrintClient

## How It Works

1. Client uses expected interface.
2. Adapter implements that interface.
3. Adapter delegates to legacy class.

## When Should I Use It?

- Integrating legacy code
- Third-party libraries with wrong interface
- Reusing existing class without modification

## When Should I NOT Use It?

- You control and can change the original interface easily
- The mismatch is too large to translate cleanly

## Real-World Examples

- Legacy API integration
- Payment gateway wrappers
- Data format converters

## How to Remember

"Convert what you have into what they expect."

## Key Learning

- Makes incompatible code work together
- Wraps rather than rewrites
- Client stays clean
- Common in integration projects

## Run the Example

**Problem project:**

```bash
dotnet run --project Structural/Adapter/Problem
```

**Solution project:**

```bash
dotnet run --project Structural/Adapter/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Client cannot use legacy printer interface. | Adapter implements IPrinter and wraps legacy code. |

