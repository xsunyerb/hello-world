using Xunit;
using HelloWorldApi;

namespace HelloWorldApi.Tests 
{
    public class HelloWorldService_Hello
    {
        private readonly HelloWorldService _helloWorldService;

        public HelloWorldService_Hello()
        {
            _helloWorldService = new HelloWorldService();
        }

        [Theory]
        [InlineData("Joe")]
        public void Hello_UsernameIsValid_ReturnHappyBirthday(string userName)
        {
            User testUser = new User(userName, DateTime.Today.AddYears(-1));
            HelloMessageDto result = _helloWorldService.Hello(testUser);

            Assert.Equal($"Hello, {userName}! Happy birthday!", result.Message);
        }

        [Theory]
        [InlineData("Joe")]
        public void Hello_UsernameIsValid_ReturnYourBirthdayIsInXDays(string userName)
        {
            DateTime birthday = DateTime.Now.AddYears(-1).AddDays(-10);
            int daysLeft = (birthday.AddYears(2) - DateTime.Now).Days;
            
            User testUser = new User(userName, birthday);
            HelloMessageDto result = _helloWorldService.Hello(testUser);

            Assert.Equal($"Hello, {userName}! Your birthday is in {daysLeft} day(s)", result.Message);
        }        
    }
}