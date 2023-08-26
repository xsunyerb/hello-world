namespace HelloWorldApi
{
    public class HelloMessage
    {
        public HelloMessage(string message) { 
            this.Message = message;
        }
        public string Message { get; set; }
    }
}
