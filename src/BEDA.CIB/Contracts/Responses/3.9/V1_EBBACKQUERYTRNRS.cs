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
    /// 3.9.1.6电子商业汇票票据流转信息查询响应主体
    /// </summary>
    public class V1_EBBACKQUERYTRNRS : IResponse
    {
        /// <summary>
        /// 3.9.1.6电子商业汇票票据流转信息查询响应主体
        /// </summary>
        public EBBACKQUERYTRNRS EBBACKQUERYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.9.1.6电子商业汇票票据流转信息查询响应主体
    /// </summary>
    public class EBBACKQUERYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.9.1.6电子商业汇票票据流转信息查询响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBBACKQUERYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.9.1.6电子商业汇票票据流转信息查询响应内容
    /// </summary>
    public class EBBACKQUERYTRN_RSBODY
    {
        /// <summary>
        /// MORE是否有下一页，Y有，N无
        /// </summary>
        [XmlAttribute]
        public string MORE { get; set; }
        /// <summary>
        /// 3.9.1.6电子商业汇票票据流转信息查询响应集合
        /// </summary>
        [XmlElement("CONTENT", Order = 0)]
        public List<EBBACKQUERYTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.1.6电子商业汇票票据流转信息查询响应明细
    /// </summary>
    public class EBBACKQUERYTRN_CONTENT
    {
        /// <summary>
        /// 流转类别
        /// </summary>
        [XmlElement(Order = 1)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 签收日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime SIGNDATE { get; set; }
        /// <summary>
        /// 签收日期 YYYY-MM-DD, 对应<see cref="SIGNDATE"/>
        /// </summary>
        [XmlElement("SIGNDATE", Order = 2)]
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
        /// 申请日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? APPDATE { get; set; }
        /// <summary>
        /// 申请日期 YYYY-MM-DD, 对应<see cref="APPDATE"/>
        /// </summary>
        [XmlElement("APPDATE", Order = 3)]
        public string APPDATEStr
        {
            get
            {
                return this.APPDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.APPDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.APPDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 申请人信息
        /// </summary>
        [XmlElement(Order = 4)]
        public ORGACCT PROPSR { get; set; }
        /// <summary>
        /// 接收人信息
        /// </summary>
        [XmlElement(Order = 5)]
        public ORGACCT RCVRR { get; set; }
        /// <summary>
        /// 贴现类型,4位(RM00:买断式,RM01回购式)
        /// </summary>
        [XmlElement(Order = 6)]
        public string DISCNTTYPE { get; set; }
        /// <summary>
        /// 贴现交易类型,4位 (TT00:贴现,TT01:再贴现,TT02:转贴现)
        /// </summary>
        [XmlElement(Order = 7)]
        public string TRADETYPE { get; set; }
        /// <summary>
        /// 贴现利率,7位百分数不含百分号(2位整数,5位小数)
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal? DISCNTRATE { get; set; }
        /// <summary>
        /// 回购日期范围
        /// </summary>
        [XmlElement(Order = 9)]
        public DATERANGE REDMDATE { get; set; }
        /// <summary>
        /// 回购利率,7位百分数不含百分号(2位整数,5位小数)
        /// </summary>
        [XmlElement(Order = 10)]
        public decimal? REDMRATE { get; set; }
        /// <summary>
        /// 拒付理由,4位见附录:拒付理由/拒签理由
        /// </summary>
        [XmlElement(Order = 11)]
        public string REPDTRSN { get; set; }
        /// <summary>
        /// 拒付备注,最大256位,拒付理由为DC09时必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string REPDTMEMO { get; set; }
        /// <summary>
        /// 追索类型
        /// </summary>
        [XmlElement(Order = 13)]
        public string RECRSTYPE { get; set; }
        /// <summary>
        /// 追索日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? RECRSDATE { get; set; }
        /// <summary>
        /// 追索日期 YYYY-MM-DD, 对应<see cref="RECRSDATE"/>
        /// </summary>
        [XmlElement("RECRSDATE", Order = 14)]
        public string RECRSDATEStr
        {
            get
            {
                return this.RECRSDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.RECRSDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RECRSDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 追索金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 15)]
        public decimal? RECRSAMT { get; set; }
        /// <summary>
        /// 同意清偿日期 YYYY-MM-DD
        /// </summary>
        [XmlIgnore]
        public DateTime? DISCHGDATE { get; set; }
        /// <summary>
        /// 同意清偿日期 YYYY-MM-DD, 对应<see cref="DISCHGDATE"/>
        /// </summary>
        [XmlElement("DISCHGDATE", Order = 16)]
        public string DISCHGDATEStr
        {
            get
            {
                return this.DISCHGDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.DISCHGDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DISCHGDATE = tmp;
                }
            }
        }
        /// <summary>
        /// 同意清偿金额,17位(15整数位,2小数位)
        /// </summary>
        [XmlElement(Order = 17)]
        public decimal? DISCHGAMT { get; set; }
        /// <summary>
        /// 交易合同号,最大30位
        /// </summary>
        [XmlElement(Order = 18)]
        public string CONTRACTID { get; set; }
        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement(Order = 19)]
        public string INVCCODE { get; set; }
        /// <summary>
        /// 保证人地址,最大60位
        /// </summary>
        [XmlElement(Order = 20)]
        public string GUARNTRADDR { get; set; }
        /// <summary>
        /// 可否转让标识,4位 (EM00:可再转让,EM01:不可再转让)
        /// </summary>
        [XmlElement(Order = 21)]
        public string NEGTBL { get; set; }
    }
}
