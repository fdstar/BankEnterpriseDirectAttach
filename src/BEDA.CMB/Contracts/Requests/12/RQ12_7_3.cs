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
    /// 12.7.3.支付机构查询帐号列表信息请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_7_3 : CMBBase<RQINFO>, IRequest<RS12_7_3>
    {
        /// <summary>
        /// NTCUSAC2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCUSAC2";
        /// <summary>
        /// 12.7.3.支付机构查询帐号列表信息请求内容
        /// </summary>
        public NTCUSAC2X NTCUSAC2X { get; set; }
    }
    /// <summary>
    /// 12.7.3.支付机构查询帐号列表信息请求内容
    /// </summary>
    public class NTCUSAC2X
    {
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
    }
}
