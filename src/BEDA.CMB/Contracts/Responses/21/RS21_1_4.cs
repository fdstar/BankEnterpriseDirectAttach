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
    /// 21.1.4.取企业银行处理结果响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS21_1_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTRTVSTS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTRTVSTS";
        /// <summary>
        /// 21.1.4.取企业银行处理结果响应内容
        /// </summary>
        public NTOPRRTNZ NTOPRRTNZ { get; set; }
        /// <summary>
        /// 21.1.4.取企业银行处理结果响应内容
        /// 业务类型为N31014网银互联协议管理时才会有返回
        /// </summary>
        public NTURLINFZ NTURLINFZ { get; set; }
    }
    /// <summary>
    /// 21.1.4.取企业银行处理结果响应内容
    /// </summary>
    public class NTOPRRTNZ
    {
        /// <summary>
        /// 流水号       	C(10)	
        /// </summary>
        public string SQRNBR { get; set; }
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 请求状态     	C(3)    附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名     	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果 	C(1)    附录 A.6
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误码       	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本     	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
    /// <summary>
    /// 21.1.4.取企业银行处理结果响应内容
    /// 业务类型为N31014网银互联协议管理时才会有返回
    /// </summary>
    public class NTURLINFZ
    {
        /// <summary>
        /// 流程实例号 	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 交易流水号 	C(11)
        /// </summary>
        public string TRXNBR { get; set; }
        /// <summary>
        /// 交易验证数据	Z(2048)
        /// </summary>
        public string URLDSP { get; set; }
    }
}
