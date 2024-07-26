namespace DynamicFilters
{
    public static class FilterHelper
    {
        public static bool FilterExist(FilterParameters filterParameters)
        {
            return filterParameters.FirstName.Any() ||
                filterParameters.Lastname.Any() ||
                filterParameters.DOB.Any() ||
                filterParameters.CreatedOn.Any();
        }
    }
}
