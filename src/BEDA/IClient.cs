using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA
{
    /// <summary>
    /// 客户端访问方法定义
    /// </summary>
    /// <typeparam name="TRq">客户端请求实体泛型</typeparam>
    /// <typeparam name="TRs">服务端响应实体泛型</typeparam>
    public interface IClient<TRq, TRs>
    {
        /// <summary>
        /// <see cref="RestSharp.RestClient"/>
        /// </summary>
        IRestClient RestClient { get; }
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        TRs Execute(TRq request);
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        Task<TRs> ExecuteAsync(TRq request);
    }
}
