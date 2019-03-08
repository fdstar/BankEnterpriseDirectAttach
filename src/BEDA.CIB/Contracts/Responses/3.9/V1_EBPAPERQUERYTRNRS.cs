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
    /// 3.9.1.12电子商业汇票代保管纸质票据查询响应主体
    /// </summary>
    public class V1_EBPAPERQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.12电子商业汇票代保管纸质票据查询响应主体
        /// </summary>
        public EBPAPERQUERYTRNRS EBPAPERQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.12电子商业汇票代保管纸质票据查询响应主体
    /// </summary>
    public class EBPAPERQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.12电子商业汇票代保管纸质票据查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPAPERQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.12电子商业汇票代保管纸质票据查询响应内容
    /// </summary>
    public class EBPAPERQUERYTRN_RSBODY
        : PAGED_RSBODY<EBPAPERQUERYTRN_CONTENT>
    {
    }
    /// <summary>
    /// 3.9.1.12电子商业汇票代保管纸质票据查询响应明细
    /// </summary>
    public class EBPAPERQUERYTRN_CONTENT
    {
        /// <summary>
        /// 批量标识号
        /// </summary>
        [XmlElement(Order = 1)]
        public string BATCHNO { get; set; }
        /// <summary>
        /// 票据号码
        /// </summary>
        [XmlElement(Order = 2)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据种类 AC01银票（银承）AC02商票（商承）
        /// </summary>
        [XmlElement(Order = 3)]
        public string BILLTYPE { get; set; }
        /// <summary>
        /// 票面金额
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DRAWDATE { get; set; }
        /// <summary>
        /// 出票日 YYYY-MM-DD, 对应<see cref="DRAWDATE"/>
        /// </summary>
        [XmlElement("DRAWDATE", Order = 5)]
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
        /// 票据到期日 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime DUEDATE { get; set; }
        /// <summary>
        /// 票据到期日 YYYY-MM-DD, 对应<see cref="DUEDATE"/>
        /// </summary>
        [XmlElement("DUEDATE", Order = 6)]
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
        /// 承兑人名称
        /// </summary>
        [XmlElement(Order = 7)]
        public string NAME { get; set; }
        /// <summary>
        /// 代保管日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime KEPTDATE { get; set; }
        /// <summary>
        /// 代保管日期 YYYY-MM-DD, 对应<see cref="KEPTDATE"/>
        /// </summary>
        [XmlElement("KEPTDATE", Order = 8)]
        public string KEPTDATEStr
        {
            get
            {
                return this.KEPTDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.KEPTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 解除代保管日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? CANCELDATE { get; set; }
        /// <summary>
        /// 解除代保管日期 YYYY-MM-DD, 对应<see cref="CANCELDATE"/>
        /// </summary>
        [XmlElement("CANCELDATE", Order = 9)]
        public string CANCELDATEStr
        {
            get
            {
                return this.CANCELDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.CANCELDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CANCELDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 保证金账户代号
        /// </summary>
        [XmlElement(Order = 10)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement(Order = 11)]
        public string MEMO { get; set; }
    }
}
