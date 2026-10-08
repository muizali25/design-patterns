
# Strategy Pattern

## Category

Behavioral

## Difficulty

Beginner

## 30-Second Explanation

Same job, different way.

## Intent

Define a family of algorithms, encapsulate each one, and make them interchangeable.

## Problem

PaymentProcessor uses if/else for every payment method.

## Problem Example

Credit card, cash, and PayPal logic in one class.

## Why Is This a Problem?

Adding a payment type modifies PaymentProcessor.

## Solution

Extract payment logic into interchangeable strategy objects.

## Before vs After

### Before

Context contains all algorithm variants.

### After

Context delegates to selected IPaymentStrategy.

## Pattern Structure

```text
PaymentProcessor
       |
 IPaymentStrategy
   /          \
CreditCard    Cash
```

## Participants

PaymentProcessor, IPaymentStrategy, CreditCardStrategy, CashStrategy

## How It Works

1. Context holds strategy reference.
2. Client sets desired strategy.
3. Context calls strategy.Pay().

## When Should I Use It?

- Multiple interchangeable algorithms
- Avoid large conditional logic
- Runtime behavior switching

## When Should I NOT Use It?

- Only one algorithm ever exists
- Strategies share no common interface

## Real-World Examples

- Payment methods
- Sorting algorithms
- Compression methods

## How to Remember

"Same job, different way."

## Key Learning

- Encapsulates varying behavior
- Runtime algorithm switching
- Open for new strategies
- Context stays stable

## Run the Example

**Problem project:**

```bash
dotnet run --project Behavioral/Strategy/Problem
```

**Solution project:**

```bash
dotnet run --project Behavioral/Strategy/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | PaymentProcessor uses if/else for payment types. | Interchangeable payment strategies. |

