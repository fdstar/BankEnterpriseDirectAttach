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
    /// 备付金信息核对结果查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBFJCRQ : RsBase
    {
        /// <summary>
        /// 预警标识varchar(10), 0:无预警,1:有预警
        /// </summary>
        [XmlElement("checkStatus")]
        public string CheckStatus { get; set; }
        /// <summary>
        /// 预警日期varchar(10) 
        /// </summary>
        [XmlIgnore]
        public DateTime RepDate { get; set; }
        /// <summary>
        /// 预警日期varchar(10), 对应<see cref="RepDate"/>
        /// </summary>
        [XmlElement("repDate")]
        public string RepDateStr
        {
            get
            {
                return this.RepDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RepDate = tmp;
                }
            }
        }
        /// <summary>
        /// 备付金机构名称varchar(200)
        /// </summary>
        [XmlElement("payOrgNm")]
        public string PayOrgNm { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ReserveCheck> List { get; set; }
    }
    /// <summary>
    /// 备付金信息核对结果
    /// </summary>
    public class ReserveCheck
    {
        /// <summary>
        /// 账号varchar(32)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 一级规则编号（核对内容）varchar(10), 值域参见附录4.11
        /// </summary>
        [XmlElement("bfjhdnr")]
        public string Bfjhdnr { get; set; }
        /// <summary>
        /// 二级规则编号（核对序号）varchar(10)，值域参见附录4.12
        /// </summary>
        [XmlElement("bfjhdxh")]
        public string Bfjhdxh { get; set; }
        /// <summary>
        /// 报表值（报表中的数据值）decimal(18,2)
        /// </summary>
        [XmlElement("bfjsjz")]
        public decimal Bfjsjz { get; set; }
        /// <summary>
        /// 公式值1 decimal(18,2)
        /// </summary>
        [XmlElement("bfjgsz1")]
        public decimal Bfjgsz1 { get; set; }
        /// <summary>
        /// 公式值2 decimal(18,2)
        /// </summary>
        [XmlElement("bfjgsz2")]
        public decimal Bfjgsz2 { get; set; }
    }
}
