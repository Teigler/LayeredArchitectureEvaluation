
 
# Architecture Creation Evaluation
This article shows different ways how to build the architecture at runtime. The architecture presented is a combination of layered architecture and the Model-View-ViewModel pattern. The evaluation was made to show the additional effort that arises without Dependency Injection (DI) (Mvvm4Layer1), with DI by factories (Mvvm4Layer2-4) and with DI container (Mvvm4Layer5).
Layered architecture is a quick and easy way to build a working software architecture. But note that there are better ways: Clean, Hexagonal, Onion Architecture etc. Better because the domain is in the centre.
Naming: 
Mvvm: Model-View-ViewModel-Pattern
4Layer: Strictly speaking, there are 6 layers. However, the Entity component is seen here in parallel with PresentationLogic, BusinessLogic and DataAccess. In addition, the API is not considered a necessary part of the component. Accordingly, View, PresentationLogic, BusinessLogic and the DataAccess form the core architecture, which all depend on the entities.
