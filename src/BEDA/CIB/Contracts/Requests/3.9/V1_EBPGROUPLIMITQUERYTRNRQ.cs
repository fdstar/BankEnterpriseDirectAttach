using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.13电子商业汇票集团客户票据池额度查询请求主体
    /// </summary>
    public class V1_EBPGROUPLIMITQUERYTRNRQ : IRequest<V1_EBPGROUPLIMITQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.13电子商业汇票集团客户票据池额度查询请求主体
        /// </summary>
        public EBPGROUPLIMITQUERYTRNRQ EBPGROUPLIMITQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.13电子商业汇票集团客户票据池额度查询请求主体
    /// </summary>
    public class EBPGROUPLIMITQUERYTRNRQ : BIZRQBASE
    {
    }
}
