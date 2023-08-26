namespace HelloWorldApi
{
    public class HelloMessageDto
    {
        public HelloMessageDto(string message) { 
            this.Message = message;
        }
        public string Message { get; set; }
    }
}
