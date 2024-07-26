using System.Linq.Expressions;

namespace DynamicFilters
{
    public class QueryBuilder<T>
    {
        public IQueryable<T> _list;
        private FilterParameters _filters;

        public QueryBuilder(List<T> list)
        {
            _list = list.AsQueryable();
        }
        public QueryBuilder(List<T> list, FilterParameters filterParameters)
        {
            _list = list.AsQueryable();
            _filters = filterParameters;
        }

        public void AddWhereExpression(Expression<Func<T, bool>> whereExpression)
        {
            if (whereExpression is not null)
            {
                _list = _list.Where(whereExpression);
            }
        }

        public List<T> GetList()
        {
            return _list.ToList();
        }
    }
}
