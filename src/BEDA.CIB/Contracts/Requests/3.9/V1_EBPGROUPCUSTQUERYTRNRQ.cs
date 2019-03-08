using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.11电子商业汇票集团关系查询请求主体
    /// </summary>
    public class V1_EBPGROUPCUSTQUERYTRNRQ : IRequest<V1_EBPGROUPCUSTQUERYTRNRS>
    {
        /// <summary>
        /// 3.9.3.11电子商业汇票集团关系查询请求主体
        /// </summary>
        public EBPGROUPCUSTQUERYTRNRQ EBPGROUPCUSTQUERYTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.11电子商业汇票集团关系查询请求主体
    /// </summary>
    public class EBPGROUPCUSTQUERYTRNRQ : BIZRQBASE
    {
    }
}
