using DynamicFilters;

var users = UserData.Users();

var request = new FilterParameters()
{
    FirstName = ["Gleah"],
    Lastname = ["Muhiya"],
    DOB = ["2024/05/23", "2024/01/23"],
    CreatedOn = ["2024/05/22", "2024/05/23"]
};

GetUserHelper userHelper = new(users);
var userQuery = userHelper.GetUserQuery(request);

foreach (var item in userQuery.GetUserList())
{
    Console.WriteLine(item.UserToString());
}

