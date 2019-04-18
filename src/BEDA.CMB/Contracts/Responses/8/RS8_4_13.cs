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
    /// 8.4.13.查询网上转网下申请的帐号列表响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_4_13 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTFNCAPC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNCAPC";
        /// <summary>
        /// 8.4.13.查询网上转网下申请的帐号列表响应集合
        /// </summary>
        [XmlElement("NTFNCAPCZ")]
        public List<NTFNCAPCZ> List { get; set; }
    }
    /// <summary>
    /// 8.4.13.查询网上转网下申请的帐号列表响应内容
    /// </summary>
    public class NTFNCAPCZ
    {
        /// <summary>
        /// 分行号	C(2)
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 帐户注解	Z(62)
        /// </summary>
        public string FCTNAM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 定期帐号分行号	C(2)
        /// </summary>
        public string FIXBBK { get; set; }
        /// <summary>
        /// 定期帐号	C(35)   通知存款账号
        /// </summary>
        public string FIXACC { get; set; }
        /// <summary>
        /// 通知/定期帐号	C(1)	F-定期，N-通知
        /// </summary>
        public string FIXTYP { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
