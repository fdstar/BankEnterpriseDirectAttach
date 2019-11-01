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
    /// 合格证状态查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCERSTT : RqBase<RS_DLCERSTT>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCERSTT"; set { } }
        /// <summary>
        /// 品牌编码varchar (10)，区分不同品牌（网络），可空
        /// </summary>
        [XmlElement("brandCD")]
        public string BrandCD { get; set; }
        /// <summary>
        /// 增量日期varchar(8)
        /// </summary>
        [XmlElement("zDate")]
        public string ZDate { get; set; }
        /// <summary>
        /// 属性1 varchar(100)，可空
        /// </summary>
        [XmlElement("field1")]
        public string Field1 { get; set; }
    }
}
