# Interface Segregation Principle (ISP) – README

---

## 📘 What is ISP?
The **Interface Segregation Principle (ISP)** states that:  
**“Clients should not be forced to depend on interfaces they do not use.”**

This means it’s better to have **small, specific interfaces** than a single large one that does too much.

---

## 🎯 Why ISP?
✅ Prevents bloated or “fat” interfaces  
✅ Reduces unnecessary dependencies between components  
✅ Improves clarity and intent in design  
✅ Makes systems easier to maintain and extend  

---

## 🔎 Signs of ISP Violations
- An interface has **too many methods** that some clients don’t use.  
- Classes are forced to implement **empty or meaningless methods**.  
- Changes to one part of an interface cause **unrelated classes** to be recompiled or redeployed.  
- Interfaces feel like “catch-all contracts” instead of specific roles.  

---

## 🛠 Benefits of Applying ISP
- **Flexibility** → Clients depend only on what they need.  
- **Reusability** → Smaller, focused contracts can be applied in multiple contexts.  
- **Maintainability** → Reduces ripple effects when changes occur.  
- **Testability** → Easier to mock or substitute small, specific interfaces.  

---

## 🚀 How to Apply ISP
1. **Analyze client needs** → Design contracts around how they are used.  
2. **Split large interfaces** into smaller, role-based ones.  
3. **Group methods logically** → Each interface should describe a single capability or responsibility.  
4. **Favor composition** → Allow clients to depend on multiple small interfaces instead of one big one.  

---


## 💡 Summary
The Interface Segregation Principle ensures **clean, focused, and role-specific contracts**.  
When in doubt, ask yourself:  
👉 *“Is this interface forcing clients to depend on things they don’t care about?”*  
If yes → it violates ISP.  
Would you like me to also prepare the final README for DIP (Dependency Inversion Principle) so you’ll have the entire SOLID series complete?
