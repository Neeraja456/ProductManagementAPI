# Product Management API

This is a simple ASP.NET Core Web API for managing products, including creating, updating, deleting, and managing stock levels.

## Features
- Create, read, update, and delete products.
- Manage stock levels by incrementing or decrementing stock.
- Unique 6-digit product IDs are generated for each product.

## Technologies Used
- .NET 6
- ASP.NET Core Web API
- Entity Framework Core (EF Core) with SQLite
- Swagger for API documentation

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

### Installation

1. **Clone the repository:**
    ```bash
    git clone https://github.com/your-username/your-repository.git
    cd your-repository
    ```

2. **Restore dependencies:**
    ```bash
    dotnet restore
    ```

3. **Set up the database:**
    - To create the database and apply migrations, run:
      ```bash
      dotnet ef migrations add InitialCreate
      dotnet ef database update
      ```

4. **Run the application:**
    ```bash
    dotnet run
    ```

    - The API will be available at `https://localhost:5001` or `http://localhost:5000`.

### Using the API
- You can use [Postman](https://www.postman.com/) or `curl` to interact with the API.
- In Swagger page, use 'https://localhost:7095/swagger/index.html'

## API Endpoints

### Products
- **POST** `/api/products`: Add a new product.
- **GET** `/api/products`: Retrieve all products.
- **GET** `/api/products/{id}`: Retrieve a product by its ID.
- **PUT** `/api/products/{id}`: Update a product.
- **DELETE** `/api/products/{id}`: Delete a product.

### Stock Management
- **PUT** `/api/products/decrement-stock/{id}/{quantity}`: Decrement the stock by a specified quantity.
- **PUT** `/api/products/add-to-stock/{id}/{quantity}`: Increment the stock by a specified quantity.
