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
    /// 29.1.商户清分列表查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS29_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSTMQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSTMQRT";
        /// <summary>
        /// 29.1.商户清分列表查询响应集合
        /// </summary>
        [XmlElement("NTSTMQRTZ1")]
        public List<NTSTMQRTZ1> List { get; set; }
    }
    /// <summary>
    /// 29.1.商户清分列表查询响应内容
    /// </summary>
    public class NTSTMQRTZ1
    {
        /// <summary>
        /// 行内商户号	C(20)
        /// </summary>
        public string MCHSID { get; set; }
        /// <summary>
        /// 收款账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 收款方名称	Z(200)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 他行行号	C(20)
        /// </summary>
        public string CPRBBK { get; set; }
        /// <summary>
        /// 他行开户行 	Z(62)
        /// </summary>
        public string EACBNK { get; set; }
        /// <summary>
        /// 他行开户地  	Z(62)
        /// </summary>
        public string EACCTY { get; set; }
        /// <summary>
        /// 待清分金额	M
        /// </summary>
        public decimal CLTAMT { get; set; }
    }
}
