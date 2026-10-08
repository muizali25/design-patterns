
# Template Method Pattern

## Category

Behavioral

## Difficulty

Intermediate

## 30-Second Explanation

Define the steps once; let subclasses fill in the differences.

## Intent

Define the skeleton of an algorithm in a base class, deferring some steps to subclasses.

## Problem

CsvExporter and JsonExporter duplicate the same export workflow.

## Problem Example

Connect, read, export, disconnect repeated in both classes.

## Why Is This a Problem?

Shared steps can drift apart when copied.

## Solution

Base class defines template method; subclasses override only the format step.

## Before vs After

### Before

Duplicated workflow in each exporter.

### After

Workflow defined once in DataExporter.Export().

## Pattern Structure

```text
DataExporter.Export()
  Connect()
  ReadData()
  WriteFormat()  <- overridden
  Disconnect()
```

## Participants

DataExporter, CsvExporter, JsonExporter

## How It Works

1. Base class defines Export() sequence.
2. Subclass overrides WriteFormat().
3. Template method calls overridden step.

## When Should I Use It?

- Similar workflows with small variations
- Control algorithm structure in base class
- Avoid duplicating process steps

## When Should I NOT Use It?

- Workflows are completely different
- Composition with Strategy is clearer

## Real-World Examples

- Data export pipelines
- Test case setup/teardown
- Game loop frameworks

## How to Remember

"Same steps, swap one part."

## Key Learning

- Hollywood Principle: don't call us, we'll call you
- Reuses invariant steps
- Subclasses customize hooks
- Inheritance-based pattern

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/TemplateMethod/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/TemplateMethod/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Duplicate export steps in each exporter. | Template method defines shared workflow skeleton. |

