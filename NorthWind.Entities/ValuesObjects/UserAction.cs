namespace NorthWind.Entities.ValuesObjects
{
    public class UserAction(string user, string description)
    {
        public DateTime CreatedDatetime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;
    }
}
