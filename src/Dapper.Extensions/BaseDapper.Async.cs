﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Extensions
{
    public abstract partial class BaseDapper
    {
        public virtual async Task<List<TReturn>> QueryAsync<TReturn>(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync<TReturn>(sql, param, Transaction, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object param = null, string splitOn = "Id",
            int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default,
            string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, string splitOn = "Id",
            int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default,
            string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null,
            string splitOn = "Id", int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default,
            string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null,
            string splitOn = "Id", int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default,
            string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null,
            string splitOn = "Id", int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default,
            string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<List<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, string splitOn = "Id", int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null, bool buffered = true)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, map, param, Transaction, buffered, splitOn, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }


        public virtual async Task<List<dynamic>> QueryAsync(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => (await Conn.Value.QueryAsync(sql, param, Transaction, commandTimeout, commandType)).ToList(), sql, param, cacheKey, cacheExpire);
        }


        public virtual async Task<TReturn> QueryFirstOrDefaultAsync<TReturn>(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => await Conn.Value.QueryFirstOrDefaultAsync<TReturn>(sql, param, Transaction, commandTimeout, commandType), sql, param, cacheKey, cacheExpire);
        }


        public virtual async Task<dynamic> QueryFirstOrDefaultAsync(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => await Conn.Value.QueryFirstOrDefaultAsync(sql, param, Transaction, commandTimeout, commandType), sql, param, cacheKey, cacheExpire);
        }


        public virtual async Task<dynamic> QuerySingleOrDefaultAsync(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => await Conn.Value.QuerySingleOrDefaultAsync(sql, param, Transaction, commandTimeout, commandType), sql, param, cacheKey, cacheExpire);
        }


        public virtual async Task<TReturn> QuerySingleOrDefaultAsync<TReturn>(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () => await Conn.Value.QuerySingleOrDefaultAsync<TReturn>(sql, param, Transaction, commandTimeout, commandType), sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task QueryMultipleAsync(string sql, Action<SqlMapper.GridReader> reader, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            using (var multi = await Conn.Value.QueryMultipleAsync(sql, param, Transaction, commandTimeout, commandType))
            {
                reader(multi);
            }
        }


        public virtual async Task<(List<TReturn1> Result1, List<TReturn2> Result2)> QueryMultipleAsync<TReturn1, TReturn2>(string sql,
          object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, param, Transaction, commandTimeout, commandType))
                {
                    return ((await multi.ReadAsync<TReturn1>()).ToList(), (await multi.ReadAsync<TReturn2>()).ToList());
                }
            }, sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<(List<TReturn1> Result1, List<TReturn2> Result2, List<TReturn3> Result3)> QueryMultipleAsync<TReturn1, TReturn2, TReturn3>(
            string sql,
            object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, param, Transaction, commandTimeout, commandType))
                {
                    return ((await multi.ReadAsync<TReturn1>()).ToList(), (await multi.ReadAsync<TReturn2>()).ToList(),
                        (await multi.ReadAsync<TReturn3>()).ToList());
                }
            }, sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<(List<TReturn1> Result1, List<TReturn2> Result2, List<TReturn3> Result3, List<TReturn4> Result4)> QueryMultipleAsync<TReturn1, TReturn2, TReturn3, TReturn4>(string sql, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, param, Transaction, commandTimeout, commandType))
                {
                    return ((await multi.ReadAsync<TReturn1>()).ToList(), (await multi.ReadAsync<TReturn2>()).ToList(),
                        (await multi.ReadAsync<TReturn3>()).ToList(), (await multi.ReadAsync<TReturn4>()).ToList());
                }
            }, sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<(List<TReturn1> Result1, List<TReturn2> Result2, List<TReturn3> Result3, List<TReturn4> Result4, List<TReturn5> Result5)> QueryMultipleAsync
            <TReturn1, TReturn2, TReturn3, TReturn4, TReturn5>(
                string sql,
                object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default, CommandType? commandType = null)
        {
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, param, Transaction, commandTimeout, commandType))
                {
                    return ((await multi.ReadAsync<TReturn1>()).ToList(), (await multi.ReadAsync<TReturn2>()).ToList(),
                        (await multi.ReadAsync<TReturn3>()).ToList(), (await multi.ReadAsync<TReturn4>()).ToList(), (await multi.ReadAsync<TReturn5>()).ToList());
                }
            }, sql, param, cacheKey, cacheExpire);
        }

        public virtual async Task<IDataReader> ExecuteReaderAsync(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await Conn.Value.ExecuteReaderAsync(sql, param, Transaction, commandTimeout, commandType);
        }

        public virtual async Task<PageResult<TReturn>> QueryPageAsync<TReturn>(string countSql, string dataSql, int pageindex, int pageSize, object param = null, int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });

            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, pars, Transaction, commandTimeout))
                {
                    var count = (await multi.ReadAsync<long>()).FirstOrDefault();
                    var data = (await multi.ReadAsync<TReturn>()).ToList();
                    var result = new PageResult<TReturn>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, param, cacheKey, cacheExpire, pageindex, pageSize);
        }

        public virtual async Task<PageResult<dynamic>> QueryPageAsync(string countSql, string dataSql, int pageindex, int pageSize, object param = null,
            int? commandTimeout = null, bool? enableCache = default, TimeSpan? cacheExpire = default, string cacheKey = default)
        {
            if (pageindex < 1)
                throw new ArgumentException("The pageindex cannot be less then 1.");
            if (pageSize < 1)
                throw new ArgumentException("The pageSize cannot be less then 1.");
            var pars = new DynamicParameters();
            if (param != null)
                pars.AddDynamicParams(param);

            pars.AddDynamicParams(new
            {
                TakeStart = (pageindex - 1) * pageSize + 1,
                TakeEnd = pageindex * pageSize,
                Skip = (pageindex - 1) * pageSize,
                Take = pageSize
            });
            var sql = $"{countSql}{(countSql.EndsWith(";") ? "" : ";")}{dataSql}";
            return await CommandExecuteAsync(enableCache, async () =>
            {
                using (var multi = await Conn.Value.QueryMultipleAsync(sql, pars, Transaction, commandTimeout))
                {
                    var count = (await multi.ReadAsync<long>()).FirstOrDefault();
                    var data = (await multi.ReadAsync()).ToList();
                    var result = new PageResult<dynamic>
                    {
                        TotalCount = count,
                        Page = pageindex,
                        PageSize = pageSize,
                        Contents = data
                    };
                    result.TotalPage = result.TotalCount % pageSize == 0
                        ? result.TotalCount / pageSize
                        : result.TotalCount / pageSize + 1;
                    if (result.Page > result.TotalPage)
                        result.Page = result.TotalPage;
                    return result;
                }
            }, sql, param, cacheKey, cacheExpire, pageindex, pageSize);

        }


        public virtual async Task<int> ExecuteAsync(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await Conn.Value.ExecuteAsync(sql, param, Transaction, commandTimeout, commandType);
        }


        public virtual async Task<TReturn> ExecuteScalarAsync<TReturn>(string sql, object param = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return await Conn.Value.ExecuteScalarAsync<TReturn>(sql, param, Transaction, commandTimeout, commandType);
        }


        protected async Task<TReturn> CommandExecuteAsync<TReturn>(bool? enableCache, Func<Task<TReturn>> execQuery, string sql, object param, string cacheKey, TimeSpan? expire, int? pageIndex = default, int? pageSize = default)
        {
            if (!IsEnableCache(enableCache))
                return await execQuery();
            cacheKey = CacheKeyBuilder.Generate(sql, param, cacheKey, pageIndex, pageSize);
            var cache = Cache.TryGet<TReturn>(cacheKey);
            if (cache.HasKey)
                return cache.Value;
            var result = await execQuery();
            Cache.TrySet(cacheKey, result, expire ?? CacheConfiguration.Expire);
            return result;
        }
    }
}
