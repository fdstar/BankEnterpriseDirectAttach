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
    /// 9.1.查询所有可信用母子公司响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS9_1 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQLNREL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQLNREL";
        /// <summary>
        /// 9.1.查询所有可信用母子公司响应集合
        /// </summary>
        [XmlElement("NTQLNRELZ")]
        public List<NTQLNRELZ> List { get; set; }
    }
    /// <summary>
    /// 9.1.查询所有可信用母子公司响应内容
    /// </summary>
    public class NTQLNRELZ
    {
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 企业名称	Z(62)
        /// </summary>
        public string CORNAM { get; set; }
        /// <summary>
        /// 企业类型	C(1)	‘G’：母公司‘S’：子公司  如果是普通企业则为空；如果是集团则非空。
        /// </summary>
        public string CORFLG { get; set; }
        /// <summary>
        /// C(1)    暂无用
        /// </summary>
        public string RCVLMT { get; set; }
        /// <summary>
        /// 客户关系号	C(10)
        /// </summary>
        public string RELNBR { get; set; }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
