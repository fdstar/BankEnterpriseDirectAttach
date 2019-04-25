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
    /// 23.1.查询公司卡业务控制信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCRDCTL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCRDCTL";
        /// <summary>
        /// 23.1.查询公司卡业务控制信息响应集合
        /// </summary>
        [XmlElement("NTOPRACCZ")]
        public List<NTOPRACCZ> List { get; set; }
    }
    /// <summary>
    /// 23.1.查询公司卡业务控制信息响应内容
    /// </summary>
    public class NTOPRACCZ
    {
        /// <summary>
        /// 分行号     	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号   	C(35)   公司卡业务下可用的结算账户
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 帐户注解   	Z(62)
        /// </summary>
        public string ACCNAM { get; set; }
        /// <summary>
        /// 币种       	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 客户关系编号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 保留字 30  	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
