# Abstract Factory

---
## The intent of the abstract factory pattern is to provide an interface for creating families of related or dependent objects without specifying their concrete classes.

## Diagram:

---
### Use:
- System should be independent of how its products are created, composed and represented
- Providing a class library of products and reveal only interfaces, not implementations
- When the system should be configured with one of multiple families of products
- Enforcing family of related products objects to be used together

### Consequences:
- Isolates concrete classes by encapsulating the responsibility and the process of creating product objects
- Easy to add new products without breaking client => OCP
- Code to create products is kept in one place => SRP
- Easy exchanging product families
- Promotes consistency among products

### Cons:
- Adding new products might be difficult