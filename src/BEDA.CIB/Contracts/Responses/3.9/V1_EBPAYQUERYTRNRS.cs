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
    /// 3.9.1.11电子商业汇票待付款银票查询响应主体
    /// </summary>
    public class V1_EBPAYQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.11电子商业汇票待付款银票查询响应主体
        /// </summary>
        public EBPAYQUERYTRNRS EBPAYQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询响应主体
    /// </summary>
    public class EBPAYQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.11电子商业汇票待付款银票查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPAYQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询响应内容
    /// </summary>
    public class EBPAYQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.11电子商业汇票待付款银票查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBPAYQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.11电子商业汇票待付款银票查询响应明细
    /// </summary>
    public class EBPAYQUERYTRN_CONTENT
    {
        /// <summary>
        /// 票据号码
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据类型 0 纸票 1 电票 2全部
        /// </summary>
        [XmlElement(Order = 2)]
        public int KIND { get; set; }
        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement(Order = 3)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD, 对应<see cref="DRAWDATE"/>
        /// </summary>
        [XmlElement("DRAWDATE", Order = 4)]
        public string DRAWDATEStr
        {
            get
            {
                return this.DRAWDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRAWDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 到期日 YYYY-MM-DD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 5)]
        public string DUEDATEStr
        {
            get
            {
                return this.DUEDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 出票人信息
        /// </summary>
        [XmlElement(Order = 6)]
        public CORRELATEACCT DRAWER { get; set; }
        /// <summary>
        /// 出票人评级信息
        /// </summary>
        [XmlElement(Order = 7)]
        public CREDITINFO DRAWERCRD { get; set; }
        /// <summary>
        /// 承兑人信息
        /// </summary>
        [XmlElement(Order = 8)]
        public CORRELATEACCT ACPTR { get; set; }
        /// <summary>
        /// 承兑人评级信息
        /// </summary>
        [XmlElement(Order = 9)]
        public CREDITINFO ACPTCRD { get; set; }
        /// <summary>
        /// 收款人信息
        /// </summary>
        [XmlElement(Order = 10)]
        public CORRELATEACCT PAYEE { get; set; }
        /// <summary>
        /// 票据状态，6位的状态，同电票
        /// </summary>
        [XmlElement(Order = 11)]
        public string STATUS { get; set; }
        /// <summary>
        /// 承兑日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? ACPTDATE { get; set; }
        /// <summary>
        /// 承兑日期 YYYY-MM-DD, 对应<see cref="ACPTDATE"/>
        /// </summary>
        [XmlElement("ACPTDATE", Order = 12)]
        public string ACPTDATEStr
        {
            get
            {
                return this.ACPTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.ACPTDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACPTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑协议编号
        /// </summary>
        [XmlElement(Order = 13)]
        public string AGRMNO { get; set; }
        /// <summary>
        /// 出票保证人信息
        /// </summary>
        [XmlElement(Order = 14)]
        public CORRELATEACCT DGTR { get; set; }
        /// <summary>
        /// 担保方式（1保证金，2质押，3其它）
        /// </summary>
        [XmlElement(Order = 15)]
        public int? ASSTYPE { get; set; }
        /// <summary>
        /// 保证金金额
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal? CAUTAMT { get; set; }
        /// <summary>
        /// 保证金比例
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? CAUPCT { get; set; }
        /// <summary>
        /// 承兑费
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal? ACPTFEE { get; set; }
        /// <summary>
        /// 承诺费用，即手续费
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal? PROMSFEE { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement(Order = 20)]
        public string MEMO { get; set; }
    }
}
