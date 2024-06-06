# Open/Closed Principle (OCP)

## Introduction

The Open/Closed Principle (OCP) is one of the foundational principles in object-oriented design that states that software entities such as classes, modules, and functions should be open for extension but closed for modification. This means that the behavior of a module can be extended without altering its source code. The principle promotes the idea that existing code should not be changed when new functionality is needed; instead, new code should be added.

OCP encourages the use of polymorphism and inheritance to achieve extension. By designing software this way, it becomes easier to add new features without risking breaking existing functionality.

## Benefits of Open/Closed Principle (OCP)

- **Enhanced Code Stability:** Since existing code remains unchanged when new functionality is added, the risk of introducing new bugs into the system is minimized.
- **Improved Reusability:** Classes designed with OCP in mind can be reused and extended in different contexts without modification. This leads to more flexible and adaptable code.
- **Facilitates Maintenance:** Maintaining and updating the codebase becomes easier because changes are confined to new extensions rather than modifications to existing code.
- **Encourages Polymorphism:** OCP promotes the use of interfaces and abstract classes, encouraging developers to design systems that are more modular and easier to extend.
- **Promotes Scalability:** As the software grows, adhering to OCP ensures that the system can scale efficiently with minimal disruption to existing functionality.

## Explanation of Example

The code scenario illustrates the Open/Closed Principle (OCP) by initially having a single class (DiscountCalculator) with a method that calculates discounts based on customer types, which is later refactored into separate subclasses (RegularCustomerDiscount and PremiumCustomerDiscount) to extend functionality without modifying existing code, adhering to OCP principles.

### Before OCP

In this portion of the code, we have a DiscountCalculator class that calculates discounts based on the customer type. However, this violates the Open/Closed Principle (OCP) because every time we need to add a new customer type or change the discount percentage, we have to modify the CalculateDiscount method in this class. This leads to code modification, which is against the principle of open for extension but closed for modification.

### After OCP

In the refactored version, we've introduced inheritance to adhere to the Open/Closed Principle. We created an abstract base class DiscountCalculator with an abstract method CalculateDiscount. Then, we created concrete subclasses RegularCustomerDiscount and PremiumCustomerDiscount, each implementing the CalculateDiscount method with its specific discount calculation logic. This approach allows us to extend the functionality by adding new discount types without modifying existing code, hence adhering to the OCP.

## Conclusion

The Open/Closed Principle is crucial for creating extensible and maintainable software systems. By ensuring that software entities are open for extension but closed for modification, developers can add new functionality with minimal risk of breaking existing code. This principle fosters a more stable and scalable codebase, which is essential for long-term software development projects.

## References

- Robert C. Martin, "Clean Architecture: A Craftsman's Guide to Software Structure and Design"
- [Open/Closed Principle on Wikipedia](https://en.wikipedia.org/wiki/Open%E2%80%93closed_principle)
