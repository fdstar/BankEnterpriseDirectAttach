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
    /// 5.1.国内信用证经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS5_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// DCOPRLCA
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "DCOPRLCA";
        /// <summary>
        /// 5.1.国内信用证经办响应集合
        /// </summary>
        [XmlElement("NTLCARTNZ")]
        public List<NTLCARTNZ> List { get; set; }
    }
    /// <summary>
    /// 24.4.网银电子对帐业务查询响应内容
    /// </summary>
    public class NTLCARTNZ
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 业务请求状态	C(3)	附录A.5
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1)	附录A.6   REQSTS=FIN时，RTNFLG才有意义
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	C(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string ERRCOD { get; set; }
        /// <summary>
        /// 错误文本	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
        /// <summary>
        /// 保留字 30    	C(50)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
