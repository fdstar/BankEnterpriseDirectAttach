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
    /// 7.4.委托贷款放款经办请求响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS7_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// LoanOutApply
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "LoanOutApply";
        /// <summary>
        /// 7.4.委托贷款放款经办请求响应内容
        /// </summary>
        public NTOPRRSTZ NTOPRRSTZ { get; set; }
    }
    /// <summary>
    /// 7.4.委托贷款放款经办请求响应内容
    /// </summary>
    public class NTOPRRSTZ
    {
        /// <summary>
        /// 请求状态	C(3,3)	请求状态
        /// </summary>
        public string REQSTS { get; set; }
        /// <summary>
        /// 待处理操作序列	C(3)
        /// </summary>
        public string OPRSQN { get; set; }
        /// <summary>
        /// 操作别名	Z(32)
        /// </summary>
        public string OPRALS { get; set; }
        /// <summary>
        /// 业务处理结果	C(1,1)	A.6 业务处理结果
        /// </summary>
        public string RTNFLG { get; set; }
        /// <summary>
        /// 错误描述	Z(92)
        /// </summary>
        public string ERRTXT { get; set; }
    }
}
