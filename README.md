DependencyInjectionContainer
Welcome to the DependencyInjectionContainer project, designed to facilitate the management of dependencies in a .NET Console application, ensuring loose coupling and adherence to SOLID principles. This container automates the creation and injection of dependencies, allowing for more maintainable, testable, and scalable code.

Problem Statement
The aim is to develop a DI container that reduces the complexity of managing dependencies manually, promotes decoupling, and adheres to SOLID principles, thereby enhancing the maintainability, testability, and scalability of applications.

Project Goals
Key Features
Inversion of Control (IoC):

Inverts the control of object creation from the application to the container, promoting the Dependency Inversion Principle (DIP). High-level modules depend on abstractions rather than low-level modules.
Automatic Dependency Resolution:

Resolves dependencies automatically by analyzing constructor parameters, promoting the Single Responsibility Principle (SRP). Classes manage only their behavior and not their dependencies.
Support for Constructor Injection:

Ensures dependencies are provided at the time of object creation, aligning with the Open/Closed Principle (OCP). Classes remain open for extension but closed for modification.
Singleton and Transient Lifetimes:

Supports both singleton and transient lifetimes, offering flexibility in dependency management. Singletons ensure a single instance throughout the application's lifetime, while transient dependencies create new instances per request.
Ease of Use:

Provides a simple and intuitive API for easy registration and resolution of dependencies, enabling developers to focus on business logic rather than boilerplate code.
Example Usage
Here’s how to effectively utilize the DependencyInjectionContainer to manage dependencies:

csharp
Copy code
// Registering services
var container = new DIContainer();
container.RegisterSingleton<IService, ServiceImplementation>();
container.RegisterTransient<IRepository, RepositoryImplementation>();

// Resolving and using services
var service = container.Resolve<IService>();
service.Execute();
Benefits
Decoupling:

Reduces coupling between classes, promoting a more modular and flexible architecture.
Maintainability:

Achieves separation of concerns, making the codebase easier to maintain and evolve. Changes to dependencies do not require changes to the dependent classes.
Testability:

Facilitates unit testing by allowing easy injection of mock dependencies, ensuring classes can be tested in isolation.
Conclusion
Our custom DI container for .NET Console applications is a powerful tool that promotes SOLID principles, enhances code quality, and simplifies the management of dependencies. By leveraging this container, developers can build more robust, maintainable, and scalable applications.
