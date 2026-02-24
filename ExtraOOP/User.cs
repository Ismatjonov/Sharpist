namespace ExtraOOP;

public class User
{
    string name = "";
    string email = "";
    string phone = "";

    public string this[string progname]
    {
        get
        {
            switch (progname)
            {
                case "name": return name;
                case "email": return email;
                case "phone": return phone;
                default: throw new Exception("Unknown Property Name");
            }
        }
        set
        {
            switch (progname)
            {
                case "name":
                    name = value;
                    break;
                case "email":
                    email = value;
                    break;
                case "phone":
                    phone = value;
                    break;
                default: throw new Exception("Unknown Property Name");
            }
        }
    }
}