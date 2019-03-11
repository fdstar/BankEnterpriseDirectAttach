using BEDA.CMB.Contracts;
using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CMB
{
    /// <summary>
    /// 招商银行客户端接口约定
    /// </summary>
    public interface ICMBClient : IClient
    {
        /// <summary>
        /// 响应报文默认编码方式，如果不传递，则默认使用<see cref="RestClient.Encoding"/>
        /// </summary>
        Encoding ResponseEncoding { get; set; }
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="TRq">业务请求类型</typeparam>
        /// <typeparam name="TRs">业务响应类型</typeparam>
        /// <param name="request">请求主体</param>
        /// <param name="loginName">要使用的账户名，如果传递，则将覆盖<see cref="RQINFO.LGNNAM"/></param>
        /// <returns></returns>
        TRs Execute<TRq, TRs>(TRq request, string loginName = null)
            where TRq : CMBBase<RQINFO>, IRequest<TRs>
            where TRs : CMBBase<RSINFO>, IResponse, new();
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="TRq">业务请求类型</typeparam>
        /// <typeparam name="TRs">业务响应类型</typeparam>
        /// <param name="request">请求主体</param>
        /// <param name="loginName">要使用的账户名，如果传递，则将覆盖<see cref="RQINFO.LGNNAM"/></param>
        /// <returns></returns>
        Task<TRs> ExecuteAsync<TRq, TRs>(TRq request, string loginName = null)
            where TRq : CMBBase<RQINFO>, IRequest<TRs>
            where TRs : CMBBase<RSINFO>, IResponse, new();
    }
}
