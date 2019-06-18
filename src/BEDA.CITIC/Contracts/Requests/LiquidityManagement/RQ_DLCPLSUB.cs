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
    /// 不归集额度计划新增经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLCPLSUB : RqBase<RS_DLCPLSUB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLCPLSUB"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
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
        /// 不归集金额 decimal(15,2)
        /// </summary>
        [XmlElement("noCollAmt")]
        public decimal NoCollAmt { get; set; }
        /// <summary>
        /// 周期 char(1) 0：日；1：周；2：月
        /// </summary>
        [XmlElement("cycle")]
        public int Cycle { get; set; }
        /// <summary>
        /// 执行日期 varchar(2)，可空，周期为1时，执行日期为1-5的数字，周期为2时，执行日期为1-31的数字
        /// </summary>
        [XmlElement("ectDate")]
        public string EctDate { get; set; }
        /// <summary>
        /// 执行时间 char(6) 只能是100000、120000、140000、160000之一
        /// </summary>
        [XmlElement("ectTime")]
        public string EctTime { get; set; }
        /// <summary>
        /// 生效日期char(8) 格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime ValidDate { get; set; }
        /// <summary>
        /// 生效日期char(8) 格式YYYYMMDD, 对应<see cref="ValidDate"/>
        /// </summary>
        [XmlElement("validDate")]
        public string ValidDateStr
        {
            get
            {
                return this.ValidDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ValidDate = tmp;
                }
            }
        }
        /// <summary>
        /// 摘要 varchar(102) 可空
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 备注 varchar(60) 可空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
