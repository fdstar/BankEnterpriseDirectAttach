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
    /// 3.9.3.13电子商业汇票集团客户票据池额度查询响应主体
    /// </summary>
    public class V1_EBPGROUPLIMITQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.3.13电子商业汇票集团客户票据池额度查询响应主体
        /// </summary>
        public EBPGROUPLIMITQUERYTRNRS EBPGROUPLIMITQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.3.13电子商业汇票集团客户票据池额度查询响应主体
    /// </summary>
    public class EBPGROUPLIMITQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.3.13电子商业汇票集团客户票据池额度查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPGROUPLIMITQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.13电子商业汇票集团客户票据池额度查询响应内容
    /// </summary>
    public class EBPGROUPLIMITQUERYTRN_RSBODY
    {
        /// <summary>
        /// 集团客户号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string GRPCID { get; set; }
        /// <summary>
        /// 集团票据池编号	必回
        /// </summary>
        [XmlElement(Order = 2)]
        public string GRPBILLPOOLNO { get; set; }
        /// <summary>
        /// 集团客户名称	必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string GRPNAME { get; set; }
        /// <summary>
        /// 签约日期 YYYY-MM-DD 必回
        /// </summary>
        [XmlIgnore]
        public DateTime SIGNDATE { get; set; }
        /// <summary>
        /// 签约日期，格式yyyy-MM-dd ,对应<see cref="SIGNDATE"/> 必回
        /// </summary>
        [XmlElement("SIGNDATE", Order = 4)]
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
        /// 票据质押额度	必回
        /// </summary>
        [XmlElement(Order = 5)]
        public decimal BILLREMAINS { get; set; }
        /// <summary>
        /// 保证金余额（18,2）	非必回
        /// </summary>
        [XmlIgnore]
        public decimal? BAILREMAINS { get; set; }
        /// <summary>
        /// 保证金余额（18,2） 对应<see cref="BAILREMAINS"/>	非必回
        /// </summary>
        [XmlElement("BAILREMAINS", Order = 6)]
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
        /// 低风险额度	必回
        /// </summary>
        [XmlElement(Order = 7)]
        public decimal LOWRISKLIMIT { get; set; }
        /// <summary>
        /// 非低风险额度	必回
        /// </summary>
        [XmlElement(Order = 8)]
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
        [XmlElement(Order = 20)]
        public decimal AVAILLIMIT { get; set; }
        /// <summary>
        /// 可用低风险额度	必回
        /// </summary>
        [XmlElement(Order = 21)]
        public decimal AVAILLOWRISKLIMIT { get; set; }
        /// <summary>
        /// 可用非低风险额度	必回
        /// </summary>
        [XmlElement(Order = 22)]
        public decimal AVAILINLOWRISKLIMIT { get; set; }
    }
}
