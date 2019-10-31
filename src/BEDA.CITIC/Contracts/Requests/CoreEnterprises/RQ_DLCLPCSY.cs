using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 日终借款企业额度同步请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCLPCSY : RqBase<RS_DLCLPCSY>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCLPCSY"; set { } }

        /// <summary>
        /// 文件名称varchar(30), 额度信息：CREDIT
        /// </summary>
        [XmlElement("fileName")]
        public string FileName { get; set; }
        /// <summary>
        /// 文件序号 int (2)
        /// </summary>
        [XmlElement("fileSeq")]
        public int FileSeq { get; set; }
        /// <summary>
        /// 文件日期 char(8)格式YYYYMMDD ，可空
        /// </summary>
        [XmlIgnore]
        public DateTime? FileDate { get; set; }
        /// <summary>
        /// 文件日期 char(8)格式YYYYMMDD ，可空, 对应<see cref="FileDate"/>
        /// </summary>
        [XmlElement("fileDate")]
        public string FileDateStr
        {
            get
            {
                return this.FileDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.FileDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FileDate = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(100) ，可空,按约定上送
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
    }
}