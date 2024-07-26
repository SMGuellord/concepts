namespace DynamicFilters
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string DOB { get; set; }
        public string CreatedOn { get; set; }

        public string UserToString()
        {
            return $"{Firstname} {Lastname} {DOB} {CreatedOn}";
        }
    }
}
