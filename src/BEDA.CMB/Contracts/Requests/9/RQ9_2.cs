using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 9.2.汇总查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_2 : CMBBase<RQINFO>, IRequest<RS9_2>
    {
        /// <summary>
        /// NTNETDZS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZS";
        /// <summary>
        /// 9.2.汇总查询请求内容
        /// </summary>
        public NTNETDZSY1 NTNETDZSY1 { get; set; }
    }
    /// <summary>
    /// 9.2.汇总查询请求内容
    /// </summary>
    public class NTNETDZSY1
    {
        /// <summary>
        /// 调用公式	C(4)	“FI88”
        /// </summary>
        public string FMLTRF { get; set; }
        /// <summary>
        /// 客户编号	C(10)   可使用9.1查询返回的CLTNBR
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 分行号	C(3)	附录A.48招行3位分行
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)	附录A.49信用管理产品类别
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 备用字段	C(34)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
