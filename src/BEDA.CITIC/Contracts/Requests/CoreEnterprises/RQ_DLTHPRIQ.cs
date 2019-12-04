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
    /// 第三方监管信息查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLTHPRIQ : RqBase<RS_DLTHPRIQ>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLTHPRIQ"; set { } }
        /// <summary>
        /// 品牌编码varchar (10)，区分不同品牌（网络），可空
        /// </summary>
        [XmlElement("brandCD")]
        public string BrandCD { get; set; }
        /// <summary>
        /// 是否全量查询varchar(1) ，全量查询是F，增量查询是 X
        /// </summary>
        [XmlElement("zFlag")]
        public string ZFlag { get; set; }
        /// <summary>
        /// 增量日期varchar(8)，日期比如：20160718，增量查询返回更新日期为此日期0点之后的全部数据,可空
        /// </summary>
        [XmlIgnore]
        public DateTime? ZDate { get; set; }
        /// <summary>
        /// 增量日期, 对应<see cref="ZDate"/>
        /// </summary>
        [XmlElement("zDate")]
        public string ExparrDtStr
        {
            get
            {
                return this.ZDate?.ToString("yyyyMMdd");
            }
            set
            {
                this.ZDate = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ZDate = tmp;
                }
            }
        }
        /// <summary>
        /// 属性1 varchar(100) ，可空
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
    }
}
