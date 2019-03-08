using System;
using System.Collections.Generic;
using System.Text;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 登录消息请求主体
    /// </summary>
    public class SIGNONMSGSRQV1
    {
        /// <summary>
        /// 登录请求实体
        /// </summary>
        public SONRQ SONRQ { get; set; }
    }
}
