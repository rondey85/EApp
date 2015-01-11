﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EApp.Core.Query;
using EApp.Data.Query.Criterias;

namespace EApp.Data.Query
{
    public interface ISqlBuilder
    {
        ISqlBuilder From(string table);

        ISqlBuilder InnerJoin(string joinTable, string fromKey, string joinKey);

        ISqlBuilder LeftOuterJoin(string joinTable, string fromKey, string joinKey);

        ISqlBuilder RightOuterJoin(string joinTable, string fromKey, string joinKey);

        ISqlBuilder And(string criteria);

        ISqlBuilder And(ISqlCriteria criteria);

        ISqlBuilder Or(string criteria);

        ISqlBuilder Or(ISqlCriteria criteria);

        ISqlBuilder Filter(string column, Operator @operator, object value, bool isOr = false);

        ISqlBuilder Equals(string column, object value, bool isOr = false);

        ISqlBuilder NotEquals(string column, object value, bool isOr = false);

        ISqlBuilder Contains(string column, object value, bool isOr = false);

        ISqlBuilder StartsWith(string column, object value, bool isOr = false);

        ISqlBuilder EndsWith(string column, object value, bool isOr = false);

        ISqlBuilder GreaterThan(string column, object value, bool isOr = false);

        ISqlBuilder GreaterThanEquals(string column, object value, bool isOr = false);

        ISqlBuilder LessThan(string column, object value, bool isOr = false);

        ISqlBuilder LessThanEquals(string column, object value, bool isOr = false);

        ISqlBuilder In(string column, IEnumerable<object> values, bool isOr = false);

        ISqlBuilder NotIn(string column, IEnumerable<object> values, bool isOr = false);

        ISqlBuilder OrderBy(string column, SortOrder sortOrder);

        ISqlBuilder GroupBy(string[] columns, string having = "");

        ISqlBuilder Top(int count);

        ISqlBuilder Count(string column);

        ISqlBuilder Max(string column);

        ISqlBuilder Min(string column);

        ISqlBuilder Select(string[] columns);

        ISqlBuilder Where(string wherePredicate, IEnumerable<object> paramValues);

        string GetPredicate();

        string GetQuerySql();

        IDictionary<string, object> GetParameters();
    }
}
