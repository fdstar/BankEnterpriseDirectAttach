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
    /// 8.3.1.查询有权经办账号列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDIACC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIACC";
        /// <summary>
        /// 8.3.1.查询有权经办账号列表响应集合
        /// </summary>
        [XmlElement("NTQACBUSZ")]
        public List<NTQACBUSZ> List { get; set; }
    }
    /// <summary>
    /// 8.3.1.查询有权经办账号列表响应内容
    /// </summary>
    public class NTQACBUSZ
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
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 帐号注释	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
    }
}
