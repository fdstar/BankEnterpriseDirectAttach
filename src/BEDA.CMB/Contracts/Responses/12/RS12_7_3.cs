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
    /// 12.7.3.支付机构查询帐号列表信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCUSAC2
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCUSAC2";
        /// <summary>
        /// 12.7.3.支付机构查询帐号列表信息响应集合
        /// </summary>
        [XmlElement("NTCUSAC2Z")]
        public List<NTCUSAC2Z> List { get; set; }
    }
    /// <summary>
    /// 12.7.3.支付机构查询帐号列表信息响应内容
    /// </summary>
    public class NTCUSAC2Z
    {
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 户名	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 开户行名称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
    }
}
