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
    /// 23.2.取公司结算户下面所有公司卡信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS23_2 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCPRLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCPRLST";
        /// <summary>
        /// 23.2.取公司结算户下面所有公司卡信息响应集合
        /// </summary>
        [XmlElement("NTCPRLSTZ")]
        public List<NTCPRLSTZ> List { get; set; }
    }
    /// <summary>
    /// 23.2.取公司结算户下面所有公司卡信息响应内容
    /// </summary>
    public class NTCPRLSTZ
    {
        /// <summary>
        /// 公司卡   	C(20)
        /// </summary>
        public string PSBNBR { get; set; }
        /// <summary>
        /// 持卡人名称	Z(200)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 国别地区 	C(3)
        /// </summary>
        public string CLTCNR { get; set; }
        /// <summary>
        /// 证件类别 	C(3)
        /// </summary>
        public string CLTCTF { get; set; }
        /// <summary>
        /// 户口状态 	C(1)
        /// </summary>
        public string EACSTS { get; set; }
        /// <summary>
        /// 激活状态 	C(1)
        /// </summary>
        public string ACTSTS { get; set; }
        /// <summary>
        /// 开户城市 	C(6)
        /// </summary>
        public string CTYCOD { get; set; }
        /// <summary>
        /// 临时授权 	C(1)
        /// </summary>
        public string AUTSTS { get; set; }
        /// <summary>
        /// 网上支付 	C(1)
        /// </summary>
        public string ITISTS { get; set; }
    }
}
