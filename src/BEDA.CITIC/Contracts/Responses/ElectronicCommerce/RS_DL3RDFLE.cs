using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 对账文件下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DL3RDFLE : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReconciliationFile> List { get; set; }
    }
    /// <summary>
    /// 对账文件
    /// </summary>
    public class ReconciliationFile
    {
        /// <summary>
        /// 0：充值退回；1：充值；2：提现
        /// </summary>
        [XmlElement("type")]
        public int Type { get; set; }
        /// <summary>
        /// 总笔数 int
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get; set; }
        /// <summary>
        /// 总金额 deciam(15,2）
        /// </summary>
        [XmlElement("totalAmt")]
        public decimal TotalAmt { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("fileNm")]
        public string FileNm { get; set; }
        /// <summary>
        /// 对账文件内容 须用base64方式进行解码
        /// </summary>
        [XmlElement("fileContent")]
        public FileContent FileContent { get; set; }
    }
}
