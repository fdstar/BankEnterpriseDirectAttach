using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEDA.CMB.Contracts
{
    /// <summary>
    /// 招商银行报文包含主体
    /// </summary>
    /// <typeparam name="TINFO"></typeparam>
    public abstract class CMBBase<TINFO>
        where TINFO : INFO
    {
        /// <summary>
        /// 请求/响应报文头信息
        /// </summary>
        public TINFO INFO { get; set; }
        /// <summary>
        /// 获取业务对应的业务函数名
        /// </summary>
        /// <returns></returns>
        public abstract string GetFUNNAM();
    }
}
