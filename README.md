
 
# Architecture Creation Evaluation

This article shows different ways how to build the architecture at runtime. The architecture presented is a combination of layered architecture and the Model-View-ViewModel pattern. The evaluation was made to show the additional effort that arises without Dependency Injection (DI) (Mvvm4Layer1), with DI by factories (Mvvm4Layer2-4) and with DI container (Mvvm4Layer5).

Layered architecture is a quick and easy way to build a working software architecture. But note that there are better ways: Clean, Hexagonal, Onion Architecture etc. Better because the domain is in the centre.

### **Naming:** 
* **Mvvm:** Model-View-ViewModel-Pattern
* **4Layer:** Strictly speaking, there are 6 layers. However, the Entity component is seen here in parallel with PresentationLogic, BusinessLogic and DataAccess. In addition, the API is not considered a necessary part of the component. Accordingly, View, PresentationLogic, BusinessLogic and the DataAccess form the core architecture, which all depend on the entities.

### Architectural overview:

![Architectural overview](https://raw.githubusercontent.com/Teigler/LayeredArchitectureEvaluation/3bd7e1a6edbb3d973247c92a6083c0b111bcdd15/GitHubResources/Mvvm4Layer1-5.png) 



## Mvvm4Layer1 Component:

### Dependency Injection: 
No Dependency Injection for architecture structure! The class representing the layer n (e.g. BusinessLogic-Class) creates the class representing the layer n-1 (DataAccess-Class). 
-> BusinessLogic-Class creates DataAccess-Class
This results in a direct dependency that can only be resolved to a limited extent. For example, we could create another constructor in which the required dependency can be initiated.

### Architecturally important:
-> In this example the API of Mvvm4Layer1 Component must know something about the PresentationLogic- and BusinessLogic-Layer

### Tests
Constructors are not independent testable (Unit Test): 
-	Mvvm4Layer1Factory -> you can not resolve dependencies to PresentationLogic-,  BusinessLogic-, DataAccess- and Mvvm4Layer1-Class.
-	PresentationLogic-Constructor instantiates: BusinessLogic-Class
-	BusinessLogic-Constructor instantiates: DataAccess-Class
-	DataAccess-Constructor
		-> you cannot resolve dependencies to the classes instantiating in the constructors

Rest of class could be made testable as follows: you would introduce a constructor only for the tests where the required dependency can be injected. Or use setter injection.
I like to avoid the setter injection, because with it is very inconvenient to force an intra-packet set. The problem with internal setters is that they cannot be used in a public interface (in C#).

### Diagram:


![Mvvm4Layer1](https://github.com/Teigler/LayeredArchitectureEvaluation/blob/main/GitHubResources/Mvvm4Layer1.png)
