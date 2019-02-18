using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.4.4工资发放服务请求主体
    /// </summary>
    public class V1_RPAYOFFINQTRNRQ : IRequest<V1_RPAYOFFINQTRNRS>
    {
        /// <summary>
        /// 3.4.4工资发放服务请求
        /// </summary>
        public RPAYOFFINQTRNRQ RPAYOFFINQTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.4.4工资发放服务请求
    /// </summary>
    public class RPAYOFFINQTRNRQ : XFERINQTRNRQ
    {
    }
}
