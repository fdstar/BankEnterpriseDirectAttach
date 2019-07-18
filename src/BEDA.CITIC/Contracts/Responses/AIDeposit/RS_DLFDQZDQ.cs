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
    /// 组合型智能存款明细查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLFDQZDQ : RsBase
    {
        /// <summary>
        /// 账户总余额decimal(15,2)
        /// </summary>
        [XmlElement("accBal")]
        public decimal AccBal { get; set; }
        /// <summary>
        /// 业务部分冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("bsnFrzAmt")]
        public decimal BsnFrzAmt { get; set; }
        /// <summary>
        /// 司法部分冻结金额decimal(15,2)
        /// </summary>
        [XmlElement("lawFrzAmt")]
        public decimal LawFrzAmt { get; set; }
        /// <summary>
        /// 活期留存余额decimal(15,2)
        /// </summary>
        [XmlElement("curAccBal")]
        public decimal CurAccBal { get; set; }
        /// <summary>
        /// 子账户汇总金额decimal(15,2)
        /// </summary>
        [XmlElement("sbsmAmt")]
        public decimal SbsmAmt { get; set; }
        /// <summary>
        /// 冻结标志 char(1) 0：正常；1：部分冻结；2：全部冻结
        /// </summary>
        [XmlElement("xsfzFg")]
        public int XsfzFg { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<MixedTypeAIDepositDetail> List { get; set; }
    }
    /// <summary>
    /// 组合型智能存款明细
    /// </summary>
    public class MixedTypeAIDepositDetail
    {
        /// <summary>
        /// 存款序号varchar(254)
        /// </summary>
        [XmlElement("accSeq")]
        public string AccSeq { get; set; }
        /// <summary>
        /// 起存日期char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 起存日期char(8)，格式YYYYMMDD, 对应<see cref="StartDate"/>
        /// </summary>
        [XmlElement("startDate")]
        public string StartDateStr
        {
            get
            {
                return this.StartDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.StartDate = tmp;
                }
            }
        }
        /// <summary>
        /// 原始本金decimal(15,2)
        /// </summary>
        [XmlElement("orbl")]
        public decimal Orbl { get; set; }
        /// <summary>
        /// 账户余额 decimal(15,2)
        /// </summary>
        [XmlElement("balance")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 已存天数 int
        /// </summary>
        [XmlElement("inDays")]
        public int InDays { get; set; }
        /// <summary>
        /// 匹配储种 char(3) D01：1天通知；D07：7天通知；M03：3个月定期；M06：6个月定期；Y01：12个月定期；000：储种为空
        /// </summary>
        [XmlElement("mtPerd")]
        public string MtPerd { get; set; }
        /// <summary>
        /// 匹配利率decimal(9,7)
        /// </summary>
        [XmlElement("mtRate")]
        public decimal MtRate { get; set; }
        /// <summary>
        /// 匹配利率decimal(9,7)
        /// </summary>
        [XmlElement("ssInrt")]
        public decimal SsInrt { get; set; }
    }
}
