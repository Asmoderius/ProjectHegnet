namespace Hegnet.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber {  get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }
        public Claim Claim { get; set; }
        public Role Role { get; set; }
        public Address Address { get; set; }
        public User() { }

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetAddress()
        {
            return $"{Address.RoadName} {Address.Number}";
        }
    }
}
