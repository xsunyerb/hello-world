// using Xunit;
// using HelloWorldApi;

// namespace HelloWorldApi.Tests

// public class HelloWorldService_Hello
// {
//     private readonly HelloWorldService _helloWorldService;

//     public HelloWorldService_Hello()
//     {
//         _helloWorldService = new HelloWorldService();
//     }

//     [Theory]
//     [InlineData(new User("Joe", new DateTime("2000-01-01")))]
//     // [InlineData("user2")]
//     // [InlineData("user3")]
//     public void Hello_UsernameIsValid_ReturnHappyBirthday(User user)
//     {
//         HelloMessage result = _helloWorldService.Hello(user);

//         Assert.Equal($"Hello, {user.Username}! Happy birthday!", result.Message);
//     }
// }