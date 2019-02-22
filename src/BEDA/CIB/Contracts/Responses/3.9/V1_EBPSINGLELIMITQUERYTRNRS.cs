using BEDA.Utils;
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
    /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询响应主体
    /// </summary>
    public class V1_EBPSINGLELIMITQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询响应主体
        /// </summary>
        public EBPSINGLELIMITQUERYTRNRS EBPSINGLELIMITQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询响应主体
    /// </summary>
    public class EBPSINGLELIMITQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPSINGLELIMITQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.12电子商业汇票单一客户票据池额度信息查询响应内容
    /// </summary>
    public class EBPSINGLELIMITQUERYTRN_RSBODY
    {
        /// <summary>
        /// 客户名称	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string CUSTNAME { get; set; }
        /// <summary>
        /// 合同编号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string CONTRACTNO { get; set; }
        /// <summary>
        /// 合同日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime CONTRACTDATE { get; set; }
        /// <summary>
        /// 合同日期，格式yyyy-MM-dd ,对应<see cref="CONTRACTDATE"/> 必回
        /// </summary>
        [XmlElement("CONTRACTDATE", Order = 3)]
        public string CONTRACTDATEStr
        {
            get
            {
                return this.CONTRACTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CONTRACTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 签约机构号	必回
        /// </summary>
        [XmlElement(Order = 4)]
        public string SIGNORGNO { get; set; }
        /// <summary>
        /// 签约机构名称	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string SIGNORGNAME { get; set; }
        /// <summary>
        /// 签约日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime SIGNDATE { get; set; }
        /// <summary>
        /// 签约日期，格式yyyy-MM-dd ,对应<see cref="SIGNDATE"/> 必回
        /// </summary>
        [XmlElement("SIGNDATE", Order = 6)]
        public string SIGNDATEStr
        {
            get
            {
                return this.SIGNDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SIGNDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 票据池状态, 0-已解约  1-已签约	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public int BILLPOOLSTATUS { get; set; }
        /// <summary>
        /// 保证金账户	非必回
        /// </summary>
        [XmlElement(Order = 8)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 票据质押额度	必回
        /// </summary>
        [XmlElement(Order = 9)]
        public decimal BILLREMAINS { get; set; }
        /// <summary>
        /// 保证金余额（18,2）	非必回
        /// </summary>
        [XmlIgnore]
        public decimal? BAILREMAINS { get; set; }
        /// <summary>
        /// 保证金余额（18,2） 对应<see cref="BAILREMAINS"/>	非必回
        /// </summary>
        [XmlElement("BAILREMAINS", Order = 10)]
        public string BAILREMAINSStr
        {
            get
            {
                return this.BAILREMAINS?.ToString();
            }
            set
            {
                this.BAILREMAINS = value.TryConvert<decimal>();
            }
        }
        /// <summary>
        /// 票据池额度	必回
        /// </summary>
        [XmlElement(Order = 11)]
        public decimal BILLPOOLLIMIT { get; set; }
        /// <summary>
        /// 低风险额度	必回
        /// </summary>
        [XmlElement(Order = 12)]
        public decimal LOWRISKLIMIT { get; set; }
        /// <summary>
        /// 非低风险额度	必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal INLOWRISKLIMIT { get; set; }
        /// <summary>
        /// 已用额度	必回
        /// </summary>
        [XmlElement(Order = 14)]
        public decimal USEDLIMIT { get; set; }
        /// <summary>
        /// 已用低风险额度	必回
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal USEDLOWRISKLIMIT { get; set; }
        /// <summary>
        /// 已用非低风险额度	必回
        /// </summary>
        [XmlElement(Order = 16)]
        public decimal USEDINLOWRISKLIMIT { get; set; }
        /// <summary>
        /// 可用额度	必回
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal AVAILLIMIT { get; set; }
        /// <summary>
        /// 可用低风险额度	必回
        /// </summary>
        [XmlElement(Order = 18)]
        public decimal AVAILLOWRISKLIMIT { get; set; }
        /// <summary>
        /// 可用非低风险额度	必回
        /// </summary>
        [XmlElement(Order = 19)]
        public decimal AVAILINLOWRISKLIMIT { get; set; }
    }
}
