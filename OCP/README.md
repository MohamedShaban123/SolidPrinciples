# Open/Closed Principle (OCP) – README

---

## 📘 What is OCP?
The **Open/Closed Principle (OCP)** states that:  
**“Software entities (classes, modules, functions) should be open for extension, but closed for modification.”**

This means you should be able to **add new behavior** without changing existing, stable code.

---

## 🎯 Why OCP?
✅ Prevents breaking existing functionality  
✅ Encourages building flexible and reusable components  
✅ Reduces regression bugs when adding features  
✅ Makes the system easier to extend over time  

---

## 🔎 Signs of OCP Violations
- Adding a new feature requires **editing old classes**.  
- Existing modules are repeatedly modified whenever requirements change.  
- The codebase is fragile → small changes risk breaking other functionality.  
- A “big switch” or conditional logic grows with every new case.  

---

## 🛠 Benefits of Applying OCP
- **Stability** → Existing code remains untouched and reliable.  
- **Scalability** → New requirements are handled by extending behavior, not rewriting it.  
- **Maintainability** → Reduces ripple effects of changes.  
- **Team Collaboration** → Developers can safely add features without interfering with core logic.  

---

## 🚀 How to Apply OCP
1. **Identify areas prone to frequent changes** (business rules, calculations, policies, etc.).  
2. **Abstract behavior** → Define clear contracts (interfaces, abstract definitions).  
3. **Extend via new implementations** instead of modifying core code.  
4. **Rely on polymorphism and composition** to allow new behavior to plug in.  
5. **Refactor conditionals** → Replace large `if/else` or `switch` blocks with extensible structures.  


---

## 💡 Summary
The Open/Closed Principle ensures your system is **stable yet adaptable**.  
When in doubt, ask yourself:  
👉 *“Can I extend this functionality without touching the existing implementation?”*  
If no → it violates OCP.  
