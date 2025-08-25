# Liskov Substitution Principle (LSP) – README

---

## 📘 What is LSP?
The **Liskov Substitution Principle (LSP)** states that:  
**“Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.”**

In other words, if class **B** is a subclass of class **A**, then you should be able to use **B** anywhere **A** is expected — without unexpected behavior.

---

## 🎯 Why LSP?
✅ Ensures consistent behavior across inheritance hierarchies  
✅ Makes systems more reliable and predictable  
✅ Prevents fragile or misleading abstractions  
✅ Strengthens trust in polymorphism  

---

## 🔎 Signs of LSP Violations
- A subclass **overrides behavior** in a way that breaks expectations of the base class.  
- Client code needs to **check types** before using an object.  
- A subclass throws **unexpected errors** or rejects operations the base class supports.  
- Inherited methods don’t make sense for some subclasses.  

---

## 🛠 Benefits of Applying LSP
- **Reliability** → Guarantees subclasses behave correctly in place of their parents.  
- **Flexibility** → Promotes safe polymorphism and inheritance.  
- **Maintainability** → Fewer surprises when extending existing code.  
- **Clarity** → Subtypes are truly “specializations” of their base types.  

---

## 🚀 How to Apply LSP
1. **Design clear contracts** → Define expectations for each method in a base type.  
2. **Ensure substitutability** → Subclasses must honor the promises of the base class.  
3. **Avoid broken inheritance** → Don’t force subclasses to implement behavior that doesn’t apply.  
4. **Use composition if needed** → If a class cannot fully follow LSP, it may not belong in the hierarchy.  

---


## 💡 Summary
The Liskov Substitution Principle ensures **correct, predictable, and safe use of inheritance**.  
When in doubt, ask yourself:  
👉 *“If I replace the parent class with this subclass, will everything still work as expected?”*  
If no → it violates LSP.  
