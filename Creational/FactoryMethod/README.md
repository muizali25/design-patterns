
# Factory Method Pattern

## Category

Creational

## Difficulty

Beginner

## 30-Second Explanation

Don't create the object directly; let a factory decide what to create.

## Intent

Define an interface for creating objects, but let subclasses decide which class to instantiate.

## Problem

A service creates objects using conditional logic and knows every concrete type.

## Problem Example

NotificationService uses if/else to create email, SMS, and push notifications.

## Why Is This a Problem?

Adding a new notification type requires modifying the service class.

## Solution

Move object creation into specialized creator classes with a factory method.

## Before vs After

### Before

Client/service contains creation logic for every product type.

### After

Creators encapsulate creation; client calls CreateNotification() on the appropriate creator.

## Pattern Structure

```text
NotificationCreator
       |
 CreateNotification()
       |
   INotification
   /           \
Email         SMS
```

## Participants

NotificationCreator, INotification, EmailNotification, SmsNotification, EmailNotificationCreator, SmsNotificationCreator

## How It Works

1. Creator defines CreateNotification().
2. Subclass creators return specific products.
3. Client uses creator without knowing concrete classes.

## When Should I Use It?

- Object type is chosen at runtime
- Framework code should not depend on concrete products
- Subclasses need different products

## When Should I NOT Use It?

- Only one product type ever exists
- Simple creation with no variation

## Real-World Examples

- Document exporters (PDF, Word)
- UI control factories
- Payment notification senders

## How to Remember

"Ask someone else to create the object."

## Key Learning

- Separates creation from use
- Supports Open/Closed Principle
- Subclasses control instantiation
- Client depends on abstractions

## Run the Example

**Problem project:**

```bash
dotnet run --project Creational/FactoryMethod/Problem
```

**Solution project:**

```bash
dotnet run --project Creational/FactoryMethod/Solution
```

In Visual Studio 2022, set $(System.Collections.Hashtable.Folder.Split('\')[-1]).Problem or $(System.Collections.Hashtable.Folder.Split('\')[-1]).Solution as the startup project and press F5.

## Problem vs Solution Summary

| | Problem | Solution |
|---|---------|----------|
| Design | Service uses if/else to create notifications. | Creators encapsulate creation behind a factory method. |

