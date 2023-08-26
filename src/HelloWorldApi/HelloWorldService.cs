namespace HelloWorldApi
{
    public class HelloWorldService
    {
        public HelloMessage Hello(User user)
        {
            if (user.Birthday.Day == DateTime.Now.Day && user.Birthday.Month == DateTime.Now.Month)
            {
                return new HelloMessage(string.Format("Hello, {0}! Happy birthday!", user.UserName));
            }
            else
            {
                DateTime nextBirthday = new(DateTime.Now.Year + 1, user.Birthday.Month, user.Birthday.Day);
                int daysLeft = (nextBirthday - DateTime.Now).Days;
                return new HelloMessage(string.Format("Hello, {0}! Your birthday is in {1} day(s)", user.UserName, daysLeft));
            }
        }
    }
}
