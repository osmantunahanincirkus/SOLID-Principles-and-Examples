# Liskov Substitution Principle (LSP)

## Introduction

The Liskov Substitution Principle (LSP) is a fundamental principle in object-oriented programming that states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. This means that a subclass should override the parent class methods in a way that does not break functionality from a client’s point of view.

Introduced by Barbara Liskov in 1987, LSP ensures that derived classes extend the base class without changing its behavior. This principle is crucial for achieving robust and reliable polymorphic behavior in a system.

## Benefits of Liskov Substitution Principle (LSP)

- **Ensures a Strong Contract:** LSP ensures that subclasses adhere to the contract defined by the base class, providing predictable and consistent behavior.
- **Promotes Polymorphism:** By adhering to LSP, developers can design systems that effectively use polymorphism, allowing objects to be treated as instances of their parent class.
- **Enhances Code Reliability:** LSP helps in creating reliable code where subclasses can be used interchangeably with their base classes without causing unexpected behavior.
- **Facilitates Code Reusability:** Subclasses that adhere to LSP can be reused across different parts of the system without modification, promoting greater code reuse.
- **Improves Maintainability:** Systems designed with LSP in mind are easier to maintain because changes in subclasses do not affect the functionality of the base class or other subclasses.

## Explanation of Example

The code scenario illustrates the Liskov Substitution Principle (LSP) by initially having a subclass (Square) inheriting from a base class (Rectangle) where the subclass does not completely adhere to the behavior of the base class, and later refactoring it to use a base class (Shape) that adheres to LSP principles, allowing for interchangeability of objects without affecting program correctness.

### Before LSP

In this portion of the code, we have a Rectangle class representing a geometric rectangle shape. The Rectangle class has properties for width and height, along with a method GetArea() to calculate the area of the rectangle. Additionally, there's a Square class which is a subclass of Rectangle and overrides the Width and Height properties to maintain the behavior of a square.

However, this implementation violates the Liskov Substitution Principle (LSP). According to LSP, objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. But in this case, a Square object behaves differently from a Rectangle object, as the behavior of setting width and height is altered to maintain the square's property of having equal sides.

### After LSP

In the refactored version, we introduced a common base class Shape with an abstract method GetArea() for calculating the area. Both Rectangle and Square classes inherit from this base class and provide their own implementations of the GetArea() method. This ensures that objects of Rectangle and Square classes can be used interchangeably without affecting the correctness of the program, thus adhering to the Liskov Substitution Principle.

## Conclusion

The Liskov Substitution Principle is essential for designing robust and maintainable object-oriented systems. By ensuring that subclasses can be substituted for their base classes without altering the program's correctness, LSP promotes the effective use of polymorphism and enhances code reliability. Adhering to LSP leads to a more predictable and maintainable codebase, which is crucial for long-term software development.

## References

- Barbara Liskov, "Data Abstraction and Hierarchy"
- [Liskov Substitution Principle on Wikipedia](https://en.wikipedia.org/wiki/Liskov_substitution_principle)
