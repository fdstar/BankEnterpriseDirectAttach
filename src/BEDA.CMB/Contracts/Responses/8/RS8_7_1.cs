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
    /// 8.7.1.归集存款协议账号查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_7_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTCMCQAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTCMCQAC";
        /// <summary>
        /// 8.7.1.归集存款协议账号查询响应集合
        /// </summary>
        [XmlElement("NTCMCQACZ1")]
        public List<NTCMCQACZ1> List { get; set; }
    }
    /// <summary>
    /// 8.7.1.归集存款协议账号查询响应内容
    /// </summary>
    public class NTCMCQACZ1
    {
        /// <summary>
        /// 分行号  	C(3) 	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 活期帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 币种    	C(2) 	附录A.3
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 帐号注解	Z(62)
        /// </summary>
        public string FCTNAM { get; set; }
    }
}
