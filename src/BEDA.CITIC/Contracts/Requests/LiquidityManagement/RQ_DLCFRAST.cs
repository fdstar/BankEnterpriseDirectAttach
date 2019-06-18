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
    /// 内部利率设置请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCFRAST : RqBase<RS_DLCFRAST>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCFRAST"; set { } }
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 现金池ID  char(8) 由现金池信息查询结果获取
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 归集利率 decimal(9,7) 可空，归集利率使用银行利率时必须为空，归集利率未使用银行利率时必须非空
        /// </summary>
        [XmlElement("collRate")]
        public decimal? CollRate { get; set; }
        /// <summary>
        /// 超归集下拨利率 decimal(9,7) 可空，超归集下拨利率使用银行利率时必须为空，超归集下拨利率未使用银行利率时必须非空
        /// </summary>
        [XmlElement("supRate")]
        public decimal? SupRate { get; set; }
        /// <summary>
        /// 日终填平占用利率 decimal(9,7) 可空，日终填平占用利率使用银行利率时必须为空，日终填平占用利率未使用银行利率时必须非空
        /// </summary>
        [XmlElement("dayFillUsRate")]
        public decimal? DayFillUsRate { get; set; }
        /// <summary>
        /// 日终填平上存利率 decimal(9,7) 可空，日终填平上存利率使用银行利率时必须为空，日终填平上存利率未使用银行利率时必须非空
        /// </summary>
        [XmlElement("dayFillUpRate")]
        public decimal? DayFillUpRate { get; set; }
    }
}
