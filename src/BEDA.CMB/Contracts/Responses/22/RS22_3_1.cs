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
    /// 22.3.1.查询票据管家业务控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_3_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILCTL";
        /// <summary>
        /// 22.3.1.查询票据管家业务控制信息响应集合
        /// </summary>
        [XmlElement("NTQPYACCZ")]
        public List<NTQPYACCZ> List { get; set; }
        /// <summary>
        /// 22.3.1.查询票据管家业务控制信息响应内容
        /// </summary>
        public NTQBSCTLZ NTQBSCTLZ { get; set; }
    }
    /// <summary>
    /// 22.3.1.查询票据管家业务控制信息响应内容
    /// </summary>
    public class NTQPYACCZ
    {
        /// <summary>
        /// 帐户注解	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 状态	C(1)
        /// </summary>
        public string ACCFLG { get; set; }
    }
}
