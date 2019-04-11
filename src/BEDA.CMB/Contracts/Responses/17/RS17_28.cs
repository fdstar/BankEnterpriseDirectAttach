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
    /// 17.28.查询公司卡关联付款方信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS17_28 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTDMDRQD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTDMDRQD";
        /// <summary>
        /// 17.28.查询公司卡关联付款方信息响应集合
        /// </summary>
        [XmlElement("NTDMDRQDZ1")]
        public List<NTDMDRQDZ1> NTDMDRQDZ1List { get; set; }
        /// <summary>
        /// 17.28.查询公司卡关联付款方信息响应集合 续传
        /// </summary>
        [XmlElement("NTDMDRQDZ2")]
        public List<NTDMDRQDZ2> NTDMDRQDZ2List { get; set; }
    }
    /// <summary>
    /// 17.28.查询公司卡关联付款方信息响应内容
    /// </summary>
    public class NTDMDRQDZ1
    {
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 虚拟户	C(20)
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 虚拟户户名	Z(82)
        /// </summary>
        public string DMANAM { get; set; }
        /// <summary>
        /// 公司卡号	C(20)
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 关联付方账号	C(35)
        /// </summary>
        public string RLTACC { get; set; }
        /// <summary>
        /// 入账方式	C(1)
        /// </summary>
        public string TLYOPR { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
    }
    /// <summary>
    /// 17.28.查询公司卡关联付款方信息响应内容 续传
    /// </summary>
    public class NTDMDRQDZ2
    {
        /// <summary>
        /// 续传标志	C(1)    Y：有续传，N：无续传
        /// </summary>
        public string CTNFLG { get; set; }
        /// <summary>
        /// 续传虚拟户	C(20)   有续传时非空，无续传空
        /// </summary>
        public string DMANBR { get; set; }
        /// <summary>
        /// 续传公司卡号	C(20)   有续传时非空，无续传空
        /// </summary>
        public string CDSNBR { get; set; }
        /// <summary>
        /// 续传关联付方账号	C(35)   有续传时非空，无续传空
        /// </summary>
        public string RLTACC { get; set; }
    }
}
