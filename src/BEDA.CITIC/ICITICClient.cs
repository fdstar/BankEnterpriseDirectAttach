using BEDA.CITIC.Contracts.Requests;
using BEDA.CITIC.Contracts.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CITIC
{
    /// <summary>
    /// 中信银行客户端接口约定
    /// </summary>
    public interface ICITICClient : IClient
    {
        /// <summary>
        /// 响应报文默认编码方式，如果不传递，则默认使用<see cref="RestClient.Encoding"/>
        /// </summary>
        Encoding ResponseEncoding { get; set; }
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="Rs"></typeparam>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Rs Execute<Rs>(RqBase<Rs> request, string userName = null) where Rs : RsBase, new();
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="Rs"></typeparam>
        /// <param name="request"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<Rs> ExecuteAsync<Rs>(RqBase<Rs> request, string userName = null) where Rs : RsBase, new();
    }
}
