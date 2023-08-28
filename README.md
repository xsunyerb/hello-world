# Hello World API

This API uses [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) 

## Endpoints

### PUT /hello/username

***Description***: Saves/updates the given user’s name and date of birth in the database  
***Request***: PUT /hello/username { “dateOfBirth”: “YYYY-MM-DD” }  
***Response***: 204 No Content  

username must contain only letters.  
YYYY-MM-DD must be a date before the today date.  

### GET /hello/username

***Description***: Returns hello birthday message for the given user  
***Request***: Get /hello/username  
***Response***: 200 OK  

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

## Deployment
Github action file in /.gthub/workflows folder.

## Run
### Execute locally with dotnet cli
```
cd ./src
dotnet run --project HelloWorldApi --urls http://localhost:5000
```
### Execute locally with docker
#### Create image
```
cd ./src/HelloWorldApi
docker build -t hello-world-api .
```
#### Start server
```
docker run -p 5000:5000 hello-world-api 
```
## Tests
- Unit tests execution
```
dotnet test
```
- For [Postman](https://www.postman.com/downloads/) tests, use the collection file in "/postman" folder.