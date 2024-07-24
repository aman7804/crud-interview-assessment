This application is an ASP.NET Core Web API for managing product details in a database. It includes functionalities for creating, reading, updating, and deleting product entries. Entity Framework Core (EF Core) is used for database operations.

Progress Summary
I could not complete the whole Task, but here is what I've done so far:

**1. Created Models:**
- User: For authentication purposes.
- Product: Represents the product table in the database.

**2. Configured Database Context:**
- Created ApplicationDbContext and configured it in Program.cs.
- Ran migrations to generate the necessary database tables.

**3. Developed Authentication Services:**
- AuthService: Handles authentication logic.
- JwtUtils: Manages JWT token generation and validation.
- Interfaces (IAuthService, IJwtUtils) are used to achieve Dependency Injection.

**4. Built Controllers:**
- AuthController: Contains APIs for user registration and login.
- ProductController: Implements CRUD APIs for managing products.

You can check the Code for more Detailed info.
