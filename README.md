# AnotherCleanArchitectureTemplate

**!! The project run may not be working, but the solution structure is correct. !!**

Base solution template for Clean Architecture. Project dependencies are illustrated in the image below.
![alt text](Docs/Images/project-dependencies.png)

# Domain project
- This project contains the domain layer of the application, which includes domain entities, custom domain exceptions, and custom types.
- Together with the Application project, it forms the Core of the Clean Architecture.
- It should not have any dependencies on other projects.

# Application project
- This project contains business logic. It is recommended to use Mediator commands, queries, and notifications instead of a service layer implemented with interfaces. Interfaces should be used only to access external dependency services from the infrastructure layer.
- Together with the Domain project, it forms the Core of the Clean Architecture.
- Should respect CQRS principle.
- Every command or query should have its own request.
- Every query should have its own response with appropriate DTOs.
- Notifications should be used for domain events (domain changes).
- It should depend only on the Domain project.
- The output of this layer should be DTOs, not domain entities.

# Infrastructure project
- Should depend on the Application project.
- Provides implementations of Application project interfaces.
- Output of the layer should be domain entities.

# Api project
- Should depend on both the Application and Infrastructure projects, and register them in the dependency injection (DI) container.
- Exposes API endpoints to the client and invokes business logic from the Application layer.
- Due to the Api.Models project, this layer maps DTOs to shared models of the project.

# Client project
- Implements the client for the API project (e.g., via HTTP, gRPC, etc., depending on the API technology).
- Should be dependent just on Api.Models project.

# Application.Tests
- Contains unit tests for Application project.
- Should depend on Application project.
- Everything should be mocked—no real dependencies.

# Infrastructure.Tests
- Contains unit tests for the Infrastructure project.
- Should depend on the Infrastructure project.
- Mocking is required. If mocking is not possible, use the IntegrationTests project instead. Not everything needs to be tested—focus on the most important parts that do not require mocking.

# Infrastructure.Tests
- Contains integration tests for the Infrastructure project.
- Should depend on the Infrastructure project.
- Tests real dependencies, such as the database or external services.