namespace StoreAPI.Models;

public class User
{
    // TODO - Add remaining properties when adding features

    /// <summary>
    /// Represents unique identifier in database
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// First Name of User
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Last Name of User
    /// </summary>
    public string LastName { get; set; }
}