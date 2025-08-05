namespace Demo
{
    #region Demo
    //interface INotificationService
    //{
    //    void SendNotification(string recipient, string message);
    //}

    //class EmailNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending EMAIL to {recipient}: {message}");  
    //    }
    //}

    //class SmsNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending SMS to {recipient}: {message}");
    //    }
    //}

    //class PushNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Sending PUSH notification to {recipient}: {message}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        INotificationService emailService = new EmailNotificationService();
    //        INotificationService smsService = new SmsNotificationService();
    //        INotificationService pushService = new PushNotificationService();

    //        emailService.SendNotification("ahmed@email.com", "Welcome to our system!");
    //        smsService.SendNotification("01012345678", "Your code is 7890");
    //        pushService.SendNotification("user123", "You have a new message.");
    //    }

    //interface IAuthenticationService
    //{
    //    bool AuthenticateUser(string username, string password);
    //    bool AuthorizeUser(string username, string role);
    //}

    //class BasicAuthenticationService : IAuthenticationService
    //{
    //    private string storedUser = "admin";
    //    private string storedPass = "1234";
    //    private string storedRole = "admin";

    //    public bool AuthenticateUser(string username, string password)
    //    {
    //        return username == storedUser && password == storedPass;
    //    }

    //    public bool AuthorizeUser(string username, string role)
    //    {
    //        return username == storedUser && role == storedRole;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        IAuthenticationService authService = new BasicAuthenticationService();

    //        bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
    //        Console.WriteLine($"Authenticated: {isAuthenticated}");

    //        bool isAuthorized = authService.AuthorizeUser("admin", "admin");
    //        Console.WriteLine($"Authorized: {isAuthorized}");
    //    }

    //interface IShape
    //{
    //    double Area { get; }
    //    void DisplayShapeInfo();
    //}

    //interface ICircle : IShape
    //{
    //    double Radius { get; }
    //}

    //interface IRectangle : IShape
    //{
    //    double Width { get; }
    //    double Height { get; }
    //}

    //class Circle : ICircle
    //{
    //    public double Radius { get; private set; }

    //    public double Area => Math.PI * Radius * Radius;

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Circle with radius {Radius}, Area = {Area:F2}");
    //    }
    //}

    //class Rectangle : IRectangle
    //{
    //    public double Width { get; private set; }
    //    public double Height { get; private set; }

    //    public double Area => Width * Height;

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle {Width}x{Height}, Area = {Area}");
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        ICircle circle = new Circle(5);
    //        circle.DisplayShapeInfo();

    //        IRectangle rect = new Rectangle(4, 6);
    //        rect.DisplayShapeInfo();
    //    }
        #endregion

    }
