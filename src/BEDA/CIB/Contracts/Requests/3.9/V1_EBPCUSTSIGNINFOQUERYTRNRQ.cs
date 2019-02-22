using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.10电子商业汇票客户签约信息查询请求主体
    /// </summary>
    public class V1_EBPCUSTSIGNINFOQUERYTRNRQ : IRequest<V1_EBPCUSTSIGNINFOQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.10电子商业汇票客户签约信息查询请求主体
        /// </summary>
        public EBPCUSTSIGNINFOQUERYTRNRQ EBPCUSTSIGNINFOQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.10电子商业汇票客户签约信息查询请求主体
    /// </summary>
    public class EBPCUSTSIGNINFOQUERYTRNRQ : BIZRQBASE
    {
    }
}
