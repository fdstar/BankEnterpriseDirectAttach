using BEDA.Utils;
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
    /// 26.3.单笔开票经办响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKOPR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKOPR";
        /// <summary>
        /// 26.3.单笔开票经办响应集合
        /// </summary>
        public NTECKOPRZ NTECKOPRZ { get; set; }
    }
    /// <summary>
    /// 26.3.单笔开票经办响应内容
    /// </summary>
    public class NTECKOPRZ
    {
        /// <summary>
        /// 流程实例号   	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 支票编号     	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
        /// <summary>
        /// 请求状态     	C(3)	A.5 业务请求状态
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
        /// 业务处理结果 	C(1)	A.6 业务处理结果
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
}
