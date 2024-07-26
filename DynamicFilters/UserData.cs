namespace DynamicFilters
{
    public static class UserData
    {
        public static List<User> Users()
        {
            return new List<User>(){
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Guellord",
                    Lastname = "Muhiya",
                    DOB =  "2024/05/12",
                    CreatedOn =  "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Leah",
                    Lastname = "Muhiya",
                    DOB =  "2024/04/23",
                    CreatedOn =  "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Gleah",
                    Lastname = "Muhiya",
                    DOB = "2024/01/23",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Guellord",
                    Lastname = "Sumba",
                    DOB = "2024/01/20",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Leah",
                    Lastname = "Sumba",
                    DOB = "2024/03/23",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Gleah",
                    Lastname = "Sumba",
                    DOB = "2024/05/03",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Guellord",
                    Lastname = "Guellord",
                    DOB = "2024/05/13",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Leah",
                    Lastname = "Guellord",
                    DOB = "2024/05/23",
                    CreatedOn = "2024/05/23",
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Firstname = "Gleah",
                    Lastname = "Guellord",
                    DOB = "2024/05/23",
                    CreatedOn = "2024/05/23",
                }
            };
        }
    }
}
