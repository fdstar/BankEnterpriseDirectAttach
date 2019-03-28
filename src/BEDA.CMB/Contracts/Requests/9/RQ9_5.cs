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
    /// 9.5.业务查询请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ9_5 : CMBBase<RQINFO>, IRequest<RS9_5>
    {
        /// <summary>
        /// NTNETDZB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZB";
        /// <summary>
        /// 9.5.业务查询请求内容
        /// </summary>
        public NTNETDZBY1 NTNETDZBY1 { get; set; }
    }
    /// <summary>
    /// 9.5.业务查询请求内容
    /// </summary>
    public class NTNETDZBY1
    {
        /// <summary>
        /// 调用公式	C(4)	FI88:查询所有业务 FI81:查询待还款网上业务
        /// </summary>
        public string FMLTRF { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTCOD { get; set; }
        /// <summary>
        /// 产品类别	C(8)	附录A.49信用管理产品类别
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 额度编号	C(10)   可以查询额度项下的业务
        /// </summary>
        public string CRLNUM { get; set; }
        /// <summary>
        /// 分行号	C(3)	附录A.48招行3位分行
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 部门号	C(4)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)	附录A.3
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNUM { get; set; }
        /// <summary>
        /// 账号所在的分行号	C(3)	附录A.48招行3位分行
        /// </summary>
        public string ACCBBK { get; set; }
        /// <summary>
        /// 备用字段	C(58)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
