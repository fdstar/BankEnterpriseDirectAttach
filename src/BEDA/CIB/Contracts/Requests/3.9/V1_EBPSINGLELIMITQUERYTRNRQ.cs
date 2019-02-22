using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询请求主体
    /// </summary>
    public class V1_EBPSINGLELIMITQUERYTRNRQ : IRequest<V1_EBPSINGLELIMITQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询请求主体
        /// </summary>
        public EBPSINGLELIMITQUERYTRNRQ EBPSINGLELIMITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询请求主体
    /// </summary>
    public class EBPSINGLELIMITQUERYTRNRQ : BIZRQBASE
    {
    }
}
