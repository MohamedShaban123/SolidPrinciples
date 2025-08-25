# Single Responsibility Principle (SRP) – README

---

## 📘 What is SRP?
The **Single Responsibility Principle (SRP)** states that:  
**“A class, module, or function should have only one reason to change.”**

This means each unit in a system should be responsible for just **one job** or **concern**.  

---

## 🎯 Why SRP?
✅ Improves readability and clarity  
✅ Easier to maintain and update  
✅ Reduces bugs when making changes  
✅ Encourages reuse of smaller components  
✅ Makes testing simpler and faster  

---

## 🔎 Signs of SRP Violations
- A class mixes **multiple concerns** (e.g., validation, persistence, and logging all in one).  
- A small change in one area forces edits in unrelated logic.  
- The class or module is difficult to summarize in a single sentence.  
- Too many dependencies or responsibilities tightly coupled together.  

---

## 🛠 Benefits of Applying SRP
- **Maintainability** → Each part of the code is easier to update without affecting other areas.  
- **Flexibility** → Components can evolve independently.  
- **Testability** → Smaller, focused units are easier to isolate and test.  
- **Collaboration** → Multiple developers can work on different concerns without conflicts.  

---

## 🚀 How to Apply SRP
1. **Identify mixed responsibilities** → Look for classes doing too many jobs.  
2. **Extract responsibilities** → Separate validation, persistence, notifications, etc., into distinct components.  
3. **Delegate work** → Let each class or service handle one concern only.  
4. **Review regularly** → As the project grows, refactor to maintain SRP compliance.  

---

## 📝 Quick Checklist
- [ ] Does this class/module have only one responsibility?  
- [ ] Can its purpose be explained in one clear sentence?  
- [ ] Would a change in one area affect unrelated parts of the class?  
- [ ] Are unrelated concerns properly separated into other units?  

---

## 💡 Summary
SRP helps keep your system **clean, modular, and easy to maintain**.  
When in doubt, ask yourself:  
👉 *“Does this class/module have more than one reason to change?”*  
If yes → it violates SRP.  
