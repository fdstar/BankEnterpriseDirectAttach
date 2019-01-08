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
    public interface ICIBClient : IClient<FOXRQ, FOXRS>
    {
        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="TRq"></typeparam>
        /// <typeparam name="TRs"></typeparam>
        /// <param name="request">请求实体</param>
        /// <returns></returns>
        FOXRS<TRs> Execute<TRq, TRs>(FOXRQ<TRq, TRs> request)
            where TRq : IRequest<TRs>
            where TRs : IResponse;

        /// <summary>
        /// 发起业务请求
        /// </summary>
        /// <typeparam name="TRq"></typeparam>
        /// <typeparam name="TRs"></typeparam>
        /// <param name="request">请求实体</param>
        /// <returns></returns>
        Task<FOXRS<TRs>> ExecuteAsync<TRq, TRs>(FOXRQ<TRq, TRs> request)
            where TRq : IRequest<TRs>
            where TRs : IResponse;
    }
}
