using BEDA.Utils;
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
    /// 电子回单下载响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLEDCDTD : RsBase
    {
        /// <summary>
        /// 回单汇总文件内容varchar(1048576)，需用base64解码后再进行zip解压缩
        /// </summary>
        [XmlElement("fileName")]
        public ReconciliationFileContent FileConTent { get; set; }
        /// <summary>
        /// 回单汇总文件名称varchar(122)
        /// </summary>
        [XmlElement("fileName")]
        public string FileName { get; set; }
        /// <summary>
        /// 数组长度int
        /// </summary>
        [XmlElement("size")]
        public int Size { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReconciliationDownload> List { get; set; }
    }
    /// <summary>
    /// 电子回单下载
    /// </summary>
    public class ReconciliationDownload
    {
        /// <summary>
        /// 回单编号varchar (28)
        /// </summary>
        [XmlElement("brSeqNo")]
        public string BrSeqNo { get; set; }
        /// <summary>
        /// 回单类型varchar (6)，100000：存款回单；100001：取款回单；200000：转账回单；200001：缴税回单；300000：收费回单；400000定期回单；400001：活期回单
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 回单PDF文件名称varchar (256)
        /// </summary>
        [XmlElement("pdfName")]
        public string PdfName { get; set; }
    }
    /// <summary>
    /// 电子回单文本内容
    /// </summary>
    public class ReconciliationFileContent
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        /// <summary>
        /// 将银行格式的字符串转化成可读的字符串
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string GetContent(Encoding encoding = null)
        {
            if (!string.IsNullOrWhiteSpace(this.Value))
            {
                var content = (encoding ?? Encoding.GetEncoding("GB18030"))
                    .GetString(GZipHelper.Decompress(Convert.FromBase64String(this.Value)));
                return content;
            }
            return null;
        }
    }
}
