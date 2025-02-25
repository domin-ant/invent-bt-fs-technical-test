# Invent BT Full Stack Technical Test

## Getting Started

For these examples the frontend does not connect to the backend and visa vera, they are standalone services so you do not need to worry about making them work together.

### Frontend

#### Option 1 = ExpressJS with Nunjucks - (Node 18 - see .nvmrc)

> To start the frontend ensure you are in the `/frontend/nunjucks` and run `npm run dev` the service will start on [http://localhost:8000](http://localhost:8000)

#### Option 2 = React (Typescript) with Bootstrap - (Node 18 - see .nvmrc)

> To start the frontend ensure you are in the `/frontend/react-typescript` and run `npm start` the service will start on [http://localhost:3000](http://localhost:3000)

#### Option 3 = React (Javascript) with Bootstrap - (Node 18 - see .nvmrc)

> To start the frontend ensure you are in the `/frontend/react-javascript` and run `npm start` the service will start on [http://localhost:3000](http://localhost:3000)

### Backend

- Java 11 - with Spring Boot 2.7.11

> To start the backend ensure you are in the `/backend/java` and run `mvn spring-boot:run` the service will start on [http://localhost:8080](http://localhost:8080)

- Typescript - (Node 18 - see .nvmrc)

> To start the backend ensure you are in the `/backend/typescript` and run `npm run build` and `npm start` the service will start on [http://localhost:3010](http://localhost:3010)

- C# - with .NET 8

> To start the backend ensure you are in the `/backend/csharpdotnet-8/dotnet8` and run `dotnet run` the service will start on [http://localhost:5050](http://localhost:5050)

## Task

### Scenario: Shopping cart

Allow one hour to complete as much as possible.
Please work as you would normally do

> Advice: We would rather you did it properly and completed less than completed it all with poor quality or attention to details. We are looking for your best work.
>
> Things to consider: code quality, unit tests, extensibility, maintainability, etc.

- You are building a checkout system for a shop which only sells apples and oranges.

- Apples cost 60p and oranges cost 25p.
  
#### Frontend Requirements

- Create a webpage that displays both apples and oranges with plus and minus buttons to add and remove items from the cart
- Display the quantity of each item in the cart and the total cost
- Just store the data in the state of the page, no need to persist it
- No need to worry about styling unless you have time

> Think about edge cases having a negative quantity of items, etc.

#### Backend Requirements

- Build a checkout system which takes a list of items scanned at the till and outputs the total cost. See /total endpoint
- For example: [ Apple, Apple, Orange, Apple ] => £2.05
- Make reasonable assumptions about the inputs to your solution; for example, many candidates take a list of strings as input

> Think about edge cases and how you would handle them e.g. empty list, null, invalid items, etc.
