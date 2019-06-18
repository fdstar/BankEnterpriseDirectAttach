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
    /// 不归集额度计划管理经办查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPLMQRY : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<NoCollectionQuotaPlan> List { get; set; }
    }
    /// <summary>
    /// 不归集额度计划管理
    /// </summary>
    public class NoCollectionQuotaPlan
    {
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 成员单位账户名称 char(122)
        /// </summary>
        [XmlElement("accountNm")]
        public string AccountNm { get; set; }
        /// <summary>
        /// 币种 char(2)
        /// </summary>
        [XmlElement("cryType")]
        public string CryType { get; set; }
        /// <summary>
        /// 不归集金额 decimal(15,2)
        /// </summary>
        [XmlElement("noCollAmt")]
        public decimal NoCollAmt { get; set; }
        /// <summary>
        /// 计划编号 char(10)
        /// </summary>
        [XmlElement("planNo")]
        public string PlanNo { get; set; }
        /// <summary>
        /// 设置周期 0：日；1：周；2：月
        /// </summary>
        [XmlElement("cycle")]
        public int Cycle { get; set; }
        /// <summary>
        /// 设置日期 varchar(2) 设置周期为0(日)时，设置日期为0；设置周期为1(周)时，设置日期为星期几(1-5)；设置周期为2(月)时，设置日期为几号(1-31)
        /// </summary>
        [XmlElement("ectDate")]
        public string EctDate { get; set; }
        /// <summary>
        /// 设置时间 char(6) 格式hhmmss ，100000、120000、140000、160000之一
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
        /// 使用状态 char(1) 0：使用中；1：暂停使用；2撤销
        /// </summary>
        [XmlElement("useStt")]
        public string UseStt { get; set; }
        /// <summary>
        /// 设置不归集金额标志 char(1) 1：启用；0：未启用
        /// </summary>
        [XmlElement("noBackAmtFlg")]
        public int NoBackAmtFlg { get; set; }
        /// <summary>
        /// 录入人姓名 varchar(62)
        /// </summary>
        [XmlElement("operatorNm")]
        public string OperatorNm { get; set; }
        /// <summary>
        /// 录入日期 char(8) YYYYMMDD
        /// </summary>
        [XmlElement("operateDate")]
        public string OperateDate { get; set; }
        /// <summary>
        /// 录入时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("operateTime")]
        public string OperateTime { get; set; }
        /// <summary>
        /// 录入时间 由<see cref="OperateDate"/>和<see cref="OperateTime"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? OperatingTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.OperateDate, this.OperateTime),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
    }
}
