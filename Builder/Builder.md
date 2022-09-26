# Builder

---
## The intent of the builder pattern is  to separate the construction of a complex object from its representation. By doing so, the same construction process can create different representations.

## Diagram:

---
### Use:
- Make an algorithm for creating a complex object independent of the parts that make up the object and how they're assembled
- Allowing construction process to make different representations for the object that's constructed

### Consequences:
- Enable vary a products internal representation
- Isolates code for construction and representation => SRP
- Fine control over the construction process

### Cons:
- Increased complexity