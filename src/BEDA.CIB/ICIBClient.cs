using BEDA.CIB.Contracts.Requests;
using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB
{
    /// <summary>
    /// 兴业银行客户端接口约定
    /// </summary>
    public interface ICIBClient : IClient
    {
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        FOXRS Execute(FOXRQ request);
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        Task<FOXRS> ExecuteAsync(FOXRQ request);
        /// <summary>
        /// 发起业务请求 注意必定返回响应内容
        /// </summary>
        /// <typeparam name="TRq"></typeparam>
        /// <typeparam name="TRs"></typeparam>
        /// <param name="request">请求实体</param>
        /// <returns></returns>
        FOXRS<TRs> Execute<TRq, TRs>(FOXRQ<TRq, TRs> request)
            where TRq : IRequest<TRs>
            where TRs : IResponse, new();

        /// <summary>
        /// 发起业务请求 注意必定返回响应内容
        /// </summary>
        /// <typeparam name="TRq"></typeparam>
        /// <typeparam name="TRs"></typeparam>
        /// <param name="request">请求实体</param>
        /// <returns>必定返回响应内容</returns>
        Task<FOXRS<TRs>> ExecuteAsync<TRq, TRs>(FOXRQ<TRq, TRs> request)
            where TRq : IRequest<TRs>
            where TRs : IResponse, new();
    }
}
