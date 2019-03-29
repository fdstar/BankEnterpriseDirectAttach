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
    /// 10.15.资金汇总查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCFNTOT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCFNTOT";
        /// <summary>
        /// 10.15.资金汇总查询响应集合
        /// </summary>
        [XmlElement("NTCFNTOTZ")]
        public List<NTCFNTOTZ> List { get; set; }
    }
    /// <summary>
    /// 10.15.资金汇总查询响应内容
    /// </summary>
    public class NTCFNTOTZ
    {
        /// <summary>
        /// 协议编号	C(10)	
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号  	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 帐户余额	M
        /// </summary>
        public decimal BALAMT { get; set; }
        /// <summary>
        /// 可用余额	M
        /// </summary>
        public decimal AVLAMT { get; set; }
        /// <summary>
        /// 已用透支余额	M
        /// </summary>
        public decimal ODFAMT { get; set; }
        /// <summary>
        /// 透支额度	M
        /// </summary>
        public decimal CRLAMT { get; set; }
        /// <summary>
        /// 上存余额	M
        /// </summary>
        public decimal ALNCDT { get; set; }
        /// <summary>
        /// 下借余额	M
        /// </summary>
        public decimal ALNDBT { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
}
