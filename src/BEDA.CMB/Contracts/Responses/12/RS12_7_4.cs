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
    /// 12.7.4.直联实时结汇根据卖出外币账号查询买入人民币账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_7_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTEXRRMB
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTEXRRMB";
        /// <summary>
        /// 12.7.4.直联实时结汇根据卖出外币账号查询买入人民币账号响应集合
        /// </summary>
        [XmlElement("NTRTAFACZ1")]
        public List<NTRTAFACZ1> List { get; set; }
    }
    /// <summary>
    /// 12.7.4.直联实时结汇根据卖出外币账号查询买入人民币账号响应内容
    /// </summary>
    public class NTRTAFACZ1
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
        /// 币种	C(2)    A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 科目      	C(8)
        /// </summary>
        public string ACCITM { get; set; }
        /// <summary>
        /// 机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 开户行名称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 保留字    	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
