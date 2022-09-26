# Factory Method

---
## The intent of the factory method pattern is to define an interface for creating an object, but to le subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclasses.

## Diagram:

---

### Use:
- When a class can't anticipate the class of objects, it must create
- When a class wants its subclasses to specify the objects it creates
- Delegate responsibility to one of several helpers, and you want to localize the knowledge of which helper subclass is the delegate
- Enable reusing of existing code

### Consequences:
- Eliminate the need to bind application-specific classes to your code
- New products can be added without breaking client code => OCP
- Moving creating code to one specific place, the creator => SRP

### Cons:
- Clients might need to create subclasses of the creator class just to add new Concrete Product, if there is not need this would add unwanted complexity