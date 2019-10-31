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
    /// 日终借款企业额度同步响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLCLPCSY : RsBase
    {
        /// <summary>
        /// 文件名称 varchar(30) , 返回SCF端核心企业ECIF客户号+“_”+CREDIT拼装的文件名称，例：600001614307_CREDIT
        /// </summary>
        [XmlElement("fileName")]
        public string FileName { get; set; }
        /// <summary>
        /// 文件大小 int, 单位：字节
        /// </summary>
        [XmlElement("fileSize")]
        public int FileSize { get; set; }
        /// <summary>
        /// 数据条数 int
        /// </summary>
        [XmlElement("dataCount")]
        public int DataCount { get; set; }
        /// <summary>
        /// 数据内容 varchar(40000)
        /// </summary>
        [XmlElement("context")]
        public string Context { get; set; }
        /// <summary>
        /// 文件序号 int
        /// </summary>
        [XmlElement("fileSeq")]
        public int FileSeq { get; set; }
        /// <summary>
        /// 文件总数 int
        /// </summary>
        [XmlElement("fileCount")]
        public int FileCount { get; set; }
        /// <summary>
        /// 备用字段2 varchar(30) ，按约定返回
        /// </summary>
        [XmlElement("field2")]
        public string Field2 { get; set; }
        /// <summary>
        /// 备用字段3 varchar(60) ，按约定返回
        /// </summary>
        [XmlElement("field3")]
        public string Field3 { get; set; }
        /// <summary>
        /// 备用字段4 varchar(100) ，按约定返回
        /// </summary>
        [XmlElement("field4")]
        public string Field4 { get; set; }
    }
}
