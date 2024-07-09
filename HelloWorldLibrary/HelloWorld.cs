namespace ConsoleAppHelloUser
{
    public class HelloWorld
    {
        public string HelloMessage(string username)
        {
            string currentTime = DateTime.Now.ToString();
            return $"{currentTime} Hello, {username}!";
        }
    }
}
