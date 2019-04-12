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
    /// 19.1.3.额度查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ19_1_3 : CMBBase<RQINFO>, IRequest<RS19_1_3>
    {
        /// <summary>
        /// NTNETDZC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZC";
        /// <summary>
        /// 19.1.3.额度查询请求内容
        /// </summary>
        public NTNETDZC NTNETDZCY1 { get; set; }
    }
    /// <summary>
    /// 19.1.3.额度查询请求内容
    /// </summary>
    public class NTNETDZC
    {
        /// <summary>
        /// 调用公式	C(4)	“FI88”
        /// </summary>
        public string FMLTRF { get; set; }
        /// <summary>
        /// 客户编号	C(10)   可使用SDKECPREL查询返回的CLTNBR
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 产品类别	C(8)	填”03030000”
        /// </summary>
        public string BUSTYP { get; set; }
    }
}
