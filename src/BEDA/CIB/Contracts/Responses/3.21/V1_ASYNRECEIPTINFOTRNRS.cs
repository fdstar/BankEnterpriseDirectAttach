using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Responses
{
    /// <summary>
    /// 3.21.2同步电子回单响应主体
    /// </summary>
    public class V1_ASYNRECEIPTINFOTRNRS : IResponse
    {
        /// <summary>
        /// 3.21.2同步电子回单响应主体
        /// </summary>
        public ASYNRECEIPTINFOTRNRS ASYNRECEIPTINFOTRNRS { get; set; }
    }
    /// <summary>
    /// 3.21.2同步电子回单响应主体
    /// </summary>
    public class ASYNRECEIPTINFOTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.21.2同步电子回单响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public ASYNRECEIPTINFOTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.21.2同步电子回单响应内容
    /// </summary>
    public class ASYNRECEIPTINFOTRN_RSBODY
    {
        /// <summary>
        /// 是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 处理结果状态 0未处理 1处理中 2处理成功 3处理失败 必回
        /// </summary>
        [XmlElement(Order = 0)]
        public int STATUS { get; set; }
        /// <summary>
        /// 唯一标识（12位）	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string SRVC_NO { get; set; }
        /// <summary>
        /// 返回文件总数	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public int FILESUM { get; set; }
        /// <summary>
        /// 查询账户代号，最长18位	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 回单类型 01：交易明细回单 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string RECEIPT_TYPE { get; set; }
        /// <summary>
        /// 过期日 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime DUE_DATE { get; set; }
        /// <summary>
        /// 过期日 YYYY-MM-DD, 对应<see cref="DUE_DATE"/> 必回
        /// </summary>
        [XmlElement("DUE_DATE", Order = 5)]
        public string DUE_DATEStr
        {
            get
            {
                return this.DUE_DATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUE_DATE = tmp;
                }
            }
        }
        /// <summary>
        /// 3.21.2同步电子回单响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 6)]
        public List<ASYNRECEIPTINFOTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.21.2同步电子回单响应明细
    /// </summary>
    public class ASYNRECEIPTINFOTRN_CONTENT
    {
        /// <summary>
        /// 序号（从1开始递增）	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public int SEQ { get; set; }
        /// <summary>
        /// 文件ID 其中：zip文件格式的文件名是随机 pdf文件格式的文件名是ATTACHINFO的值    必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string FILE_ID { get; set; }
        /// <summary>
        /// 文件名	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string FILE_NAME { get; set; }
    }
}
