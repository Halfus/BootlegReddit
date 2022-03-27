namespace Entities.Models;

public class Vote
{    
    public Vote(short value, User user)
    {
        Value = value;
        Voter = user;
    }
    public short Value { get; set; }
    public User Voter { get; set; }


    private void Validate(short value)
    {
        
    }
}