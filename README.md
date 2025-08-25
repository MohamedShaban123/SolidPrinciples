# SOLID Principles – README

A practical guide to applying SOLID principles in .NET / C# projects.  
Use this as a reference for writing clean, maintainable, and testable code.

---

## 📑 Table of Contents
1. [What is SOLID?](#what-is-solid)
2. [Why SOLID?](#why-solid)
3. [Principles](#principles)
   - [S — Single Responsibility Principle](#s--single-responsibility-principle)
   - [O — Open/Closed Principle](#o--openclosed-principle)
   - [L — Liskov Substitution Principle](#l--liskov-substitution-principle)
   - [I — Interface Segregation Principle](#i--interface-segregation-principle)
   - [D — Dependency Inversion Principle](#d--dependency-inversion-principle)
4. [How to apply SOLID in real projects](#how-to-apply-solid-in-real-projects)
5. [Quick Reference](#quick-reference)

---

## 📘 What is SOLID?
**SOLID** is a set of five software design principles that help create flexible, scalable, and maintainable systems.

- **S**ingle Responsibility  
- **O**pen/Closed  
- **L**iskov Substitution  
- **I**nterface Segregation  
- **D**ependency Inversion  

> 💡 Think of SOLID as a **toolbox of principles** for writing clean code, not strict rules.

---

## 🎯 Why SOLID?
✅ Makes code easier to **understand and maintain**  
✅ Encourages **clear separation of concerns**  
✅ Improves **testability** of components  
✅ Reduces **bugs and regressions** when making changes  

⚠️ Overuse can lead to unnecessary abstraction. Balance is key.

---

## 🏛 Principles

### S — Single Responsibility Principle
> *“A class should have only one reason to change.”*

- Avoid classes that mix unrelated responsibilities (e.g., validation + persistence + logging).  
- Keeps each unit small, focused, and easier to test.  
- If you can’t summarize a class in one short sentence → it probably violates SRP.

---

### O — Open/Closed Principle
> *“Software entities should be open for extension but closed for modification.”*

- You should **add new features** by adding new code, **not rewriting old code**.  
- Use extension points (e.g., strategies, plug-ins) instead of modifying core logic.  
- Prevents introducing bugs when extending functionality.

---

### L — Liskov Substitution Principle
> *“Subtypes must be substitutable for their base types.”*

- A derived class should never break expectations of its base class.  
- Avoid child classes that disable or throw errors for base functionality.  
- Promotes **reliable polymorphism** and safer inheritance.

---

### I — Interface Segregation Principle
> *“No client should be forced to depend on methods it does not use.”*

- Prefer **small, role-specific interfaces** over large, bloated ones.  
- Prevents empty or unused implementations in classes.  
- Makes systems easier to extend and maintain.

---

### D — Dependency Inversion Principle
> *“High-level modules should not depend on low-level modules. Both should depend on abstractions.”*

- Business logic should depend on **interfaces/abstractions**, not concrete classes.  
- In practice: use **Dependency Injection (DI)**.  
- Promotes testability, flexibility, and loose coupling.

---

## 🚀 How to apply SOLID in real projects
1. **Spot “god classes”** — split them by responsibility.  
2. **Introduce abstractions** where business logic depends on infrastructure.  
3. **Use Dependency Injection** (ASP.NET Core provides this by default).  
4. **Replace long if/switch chains** with polymorphism (strategy, state, specification).  
5. **Write tests first** before refactoring to ensure behavior remains consistent.  

---

## 📝 Quick Reference
- **S** → One reason to change  
- **O** → Extend, don’t modify  
- **L** → Subtypes must not break expectations  
- **I** → Many small interfaces > one large one  
- **D** → Depend on abstractions, not concretions  
