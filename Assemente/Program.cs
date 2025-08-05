namespace Assemente
{
    

        #region part-1
        /*
        1- What is the primary purpose of an interface in C#?
          ans -   To define a blueprint for a class
        2-Which of the following is NOT a valid access modifier for interface members in C#?
            ans -   private
        3- Can an interface contain fields in C#?
            ans -   No, interfaces cannot contain fields
        4-In C#, can an interface inherit from another interface?
          ans -   Yes, an interface can inherit from another interface
        5-Which keyword is used to implement an interface in a class in C#?
           ans -   The 'implements' 
        6-Can an interface contain static methods in C#?
           ans -   No, interfaces cannot contain static methods
        7- In C#, can an interface have explicit access modifiers for its members?
                       ans -   No, No, all members are implicitly public
        8- What is the purpose of an explicit interface implementation in C#?
            ans -   b) To provide a clear separation between interface and class members
        9-In C#, can an interface have a constructor?
           ans -   No, interfaces cannot have constructors
        10-How can a C# class implement multiple interfaces?
            ans -   By separating interface names with commas   
         */
        #endregion
        #region part-2
        #region Q-1
        //interface IShape
        //{
        //    double Area { get; }
        //    void DisplayShapeInfo();
        //}

        //class Circle : IShape
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

        //class Rectangle : IShape
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
        //        Console.WriteLine($"Rectangle {Width} x {Height}, Area = {Area}");
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        IShape circle = new Circle(5);
        //        IShape rectangle = new Rectangle(4, 6);

        //        circle.DisplayShapeInfo();
        //        rectangle.DisplayShapeInfo();
        //    }

        #endregion
        #region Q-2
        public interface IAuthenticationService
        {
            bool AuthenticateUser(string username, string password);
            bool AuthorizeUser(string username, string role);
        }

        public class BasicAuthenticationService : IAuthenticationService
        {
            private string storedUser = "admin";
            private string storedPass = "1234";
            private string storedRole = "admin";

            public bool AuthenticateUser(string username, string password)
            {
                return username == storedUser && password == storedPass;
            }

            public bool AuthorizeUser(string username, string role)
            {
                return username == storedUser && role == storedRole;
            }
        }

        class Program
        {
            static void Main()
            {
                IAuthenticationService authService = new BasicAuthenticationService();

                bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
                Console.WriteLine($"Authenticated: {isAuthenticated}");

                bool isAuthorized = authService.AuthorizeUser("admin", "admin");
                Console.WriteLine($"Authorized: {isAuthorized}");
            }
            #endregion
            #endregion
        }

    }

