using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.7.1.直联版支付机构汇率查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_1 : CMBBase<RQINFO>, IRequest<RS12_7_1>
    {
        /// <summary>
        /// NTPBRQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPBRQRY";
        /// <summary>
        /// 12.7.1.直联版支付机构汇率查询请求内容
        /// </summary>
        public NTPBRQRYX NTPBRQRYX { get; set; }
    }
    /// <summary>
    /// 12.7.1.直联版支付机构汇率查询请求内容
    /// </summary>
    public class NTPBRQRYX
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 交易币种	C(2)	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 汇率类型	C(1)	T:实时汇率 P:专用汇率
        /// </summary>
        public string RATTYP { get; set; }
    }
}
