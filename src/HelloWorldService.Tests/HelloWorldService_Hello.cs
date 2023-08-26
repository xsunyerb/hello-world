using Xunit;
using HelloWorld.Services;

namespace HelloWorld.UnitTests.Services
{
    public class HelloWorldService_Hello
    {
        private readonly HelloWorldService _helloWorldService;

        public HelloWorldService_Hello()
        {
            _helloWorldService = new HelloWorldService();
        }

        [Theory]
        [InlineData("user1")]
        [InlineData("user2")]
        [InlineData("user3")]
        public void Hello_UsernameIsValid_ReturnHappyBirthday(string username)
        {
            string result = _helloWorldService.Hello(username);

            Assert.Equal($"Hello, {username}! Happy birthday!", result);
        }
    }
}