namespace DynamicFilters
{
    public class GetUserHelper
    {
        public List<User> _itemList;

        public GetUserHelper(List<User> itemList)
        {
            _itemList = itemList;
        }

        public QueryBuilder<User> GetUserQuery(FilterParameters request)
        {
            QueryBuilder<User> queryBuilder = new(_itemList, request);
            if (FilterHelper.FilterExist(request))
            {
                AddFilterFirstNamesExpresion(request, queryBuilder);
                AddFilterLastNamesExpression(request, queryBuilder);
                AddFilterDOBsExpression(request, queryBuilder);
                AddFilterCreatedDatesExpression(request, queryBuilder);
            }

            return queryBuilder;
        }


        public void AddFilterFirstNamesExpresion(FilterParameters request, QueryBuilder<User> queryBuilder)
        {
            if (request.FirstName.Any())
            {
                queryBuilder.AddWhereExpression(user => request.FirstName.Contains(user.Firstname));
            }
        }

        public void AddFilterLastNamesExpression(FilterParameters request, QueryBuilder<User> queryBuilder)
        {
            if (request.Lastname.Any())
            {
                queryBuilder.AddWhereExpression(user => request.Lastname.Contains(user.Lastname));
            }
        }

        public void AddFilterDOBsExpression(FilterParameters request, QueryBuilder<User> queryBuilder)
        {
            if (request.DOB.Any())
            {
                queryBuilder.AddWhereExpression(user => request.DOB.Contains(user.DOB));
            }
        }
        public void AddFilterCreatedDatesExpression(FilterParameters request, QueryBuilder<User> queryBuilder)
        {
            if (request.CreatedOn.Any())
            {
                queryBuilder.AddWhereExpression(user => request.CreatedOn.Contains(user.CreatedOn));
            }
        }
    }
}
