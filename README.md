# Hello World API

## Endpoints

### PUT /hello/username

*Description*: Saves/updates the given user’s name and date of birth in the database  
*Request*: PUT /hello/username { “dateOfBirth”: “YYYY-MM-DD” }  
*Response*: 204 No Content  

username must contain only letters.  
YYYY-MM-DD must be a date before the today date.  

### GET /hello/username

*Description*: Returns hello birthday message for the given user  
*Request*: Get /hello/username  
*Response*: 200 OK  

Response Examples:  
A. If username’s birthday is in N days:  
```
{ 
    “message”: “Hello, <username>! Your birthday is in N day(s)”
}
```
B. If username’s birthday is today:  
```
{ 
    “message”: “Hello, <username>! Happy birthday!” 
}
```

## Execute 
```
dotnet run --project HelloWorldApi
```
Will run the API at http://localhost:5250/

## Run tests
```
dotnet test
```

