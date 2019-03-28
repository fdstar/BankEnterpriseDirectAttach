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
    /// 9.4.额度附加信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTNETDZI
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTNETDZI";
        /// <summary>
        /// 9.4.额度附加信息查询响应集合
        /// </summary>
        [XmlElement("NTNETDZIZ1")]
        public List<NTNETDZIZ1> List { get; set; }
    }
    /// <summary>
    /// 9.4.额度附加信息查询响应内容
    /// </summary>
    public class NTNETDZIZ1
    {
        /// <summary>
        /// 文件区分	C(10)
        /// </summary>
        public string FLENAM { get; set; }
        /// <summary>
        /// 额度编号	C(10)
        /// </summary>
        public string RCDNUM { get; set; }
        /// <summary>
        /// 附加项目	C(6)
        /// </summary>
        public string ITMNUM { get; set; }
        /// <summary>
        /// 附加项目代码	C(20)   对应附加项目有不同的值
        /// </summary>
        public string ITMSTR { get; set; }
        /// <summary>
        /// 相关说明	Z(200)
        /// </summary>
        public string NTESTR { get; set; }
        /// <summary>
        /// 备用字段	C(42)
        /// </summary>
        public string RSVFLD { get; set; }
    }
}
