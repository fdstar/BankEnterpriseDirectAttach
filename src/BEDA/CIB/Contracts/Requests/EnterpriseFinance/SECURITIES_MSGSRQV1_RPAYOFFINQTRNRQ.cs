using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 工资发放服务请求主体
    /// </summary>
    public class SECURITIES_MSGSRQV1_RPAYOFFINQTRNRQ : IRequest<SECURITIES_MSGSRSV1_RPAYOFFINQTRNRS>
    {
        /// <summary>
        /// 工资发放服务请求
        /// </summary>
        public RPAYOFFINQTRNRQ RPAYOFFINQTRNRQ { get; set; }
    }
    /// <summary>
    /// 工资发放服务请求
    /// </summary>
    public class RPAYOFFINQTRNRQ : XFERINQTRNRQ
    {
    }
}
