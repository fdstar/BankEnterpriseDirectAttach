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
    /// 8.8.4.查询券商编号及保证金账号响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_8_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTSECCNV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTSECCNV";
        /// <summary>
        /// 8.8.4.查询券商编号及保证金账号响应集合
        /// </summary>
        [XmlElement("NTSECCNVZ2")]
        public List<NTSECCNVZ2> List { get; set; }
    }
    /// <summary>
    /// 8.8.4.查询券商编号及保证金账号响应内容
    /// </summary>
    public class NTSECCNVZ2
    {
        /// <summary>
        /// 业务类别	C(2)
        /// </summary>
        public string BIZTYP { get; set; }
        /// <summary>
        /// 货币代码	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 证券公司编号	C(6)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 保证金账号	C(30)
        /// </summary>
        public string CPRACT { get; set; }
        /// <summary>
        /// 处理状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 证券公司名称	Z(20)
        /// </summary>
        public string CNVNAM { get; set; }
    }
}
