using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 31.1.发送内部户日初日终余额及交易报文经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS31_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTIAMSTD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTIAMSTD";
        /// <summary>
        /// 31.1.发送内部户日初日终余额及交易报文经办响应内容
        /// </summary>
        public NTIAMSTDZ1 NTIAMSTDZ1 { get; set; }
    }
    /// <summary>
    /// 31.1.发送内部户日初日终余额及交易报文经办响应内容
    /// </summary>
    public class NTIAMSTDZ1
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态         	C(3)
        /// </summary>
        public string REQSTA { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名         	O(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果     	C(1)
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误描述	Z(192)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
