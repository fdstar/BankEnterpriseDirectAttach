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
    /// 9.2.汇总查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNETDZS
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZS";
        /// <summary>
        /// 9.2.汇总查询响应集合
        /// </summary>
        [XmlElement("NTNETDZSY1")]
        public List<NTNETDZSY1> List { get; set; }
    }
    /// <summary>
    /// 9.2.汇总查询响应内容
    /// </summary>
    public class NTNETDZSY1
    {
        /// <summary>
        /// 分行号	C(3)	附录A.48招行3位分行
        /// </summary>
        public string BBKNUM { get; set; }
        /// <summary>
        /// 机构号	C(6)
        /// </summary>
        public string BRNNUM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CRYNUM { get; set; }
        /// <summary>
        /// 放款金额	M
        /// </summary>
        public decimal USDAMT { get; set; }
        /// <summary>
        /// 余额	M
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 次数	N(5)
        /// </summary>
        public int SUMNUM { get; set; }
        /// <summary>
        /// 产品类别	C(8)	附录A.49信用管理产品类别
        /// </summary>
        public string BUSTYP { get; set; }
        /// <summary>
        /// 备用字段	C(58)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
