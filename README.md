# PhotonContainer DI

Welcome to the PhotonContainer DI project, a simple yet effective Dependency Injection (DI) container designed to facilitate the decoupling of components in .NET applications.

## Problem Statement

The goal is to develop a DI container that allows for easy registration and resolution of services, promoting loose coupling and enhancing testability in your applications.

## Project Goals

### Initial Phase

- **Register Services**: Enable the registration of services with their implementations.
- **Resolve Services**: Automatically resolve and inject dependencies where needed.

### Advanced Features

- **Automatic Resolution**: Automatically resolve nested dependencies.
- **Modularity**: Ensure the DI container is modular and maintainable.

## Example Usage

Here's how to effectively utilize the PhotonContainer to manage dependency injection:

```csharp
using PhotonContainer.Business.DIContainers;
using PhotonContainer.Business.Interfaces;
using PhotonContainer.Business.ReverseStrings;
using PhotonContainer.Business.TestStrings;

namespace PhotonContainer
{
    public class Program
    {
        static IContainers container = new PhotonDIContainer();

        public static void Main(string[] args)
        {
            DIServices();

            IStringReversals reversalService = container.Resolve<IStringReversals>();

            Console.WriteLine($"Reversed: {reversalService.ReverseString()}");

            Console.ReadLine();
        }

        private static void DIServices()
        {
            container.Register<IStringReversals, PhotonReversal>();
            container.Register<ITestStrings, TestStringOne>();

            container.Resolve<ITestStrings>();
        }
    }
}
