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
    /// 17.23.查询虚拟户关联付款方信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_23 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMARLQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMARLQ";
        /// <summary>
        /// 17.23.查询虚拟户关联付款方信息响应集合
        /// </summary>
        [XmlElement("NTDMARLQZ1")]
        public List<NTDMARLQZ1> List { get; set; }
    }
    /// <summary>
    /// 17.23.查询虚拟户关联付款方信息响应内容
    /// </summary>
    public class NTDMARLQZ1
    {
        /// <summary>
        /// 帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户编号	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 关联账号	C(35)
        /// </summary>
        public string RLTACC { get; set; }
        /// <summary>
        /// 入账方式	C(1)	Y：非关联付款方账号入对应虚拟户 N：非关联付款方账号入默认虚拟户
        /// </summary>
        public string TLYOPR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
    }
}
