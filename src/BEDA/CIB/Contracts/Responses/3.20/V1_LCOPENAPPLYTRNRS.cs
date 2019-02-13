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
    /// 3.20.1进口信用证开立响应主体
    /// </summary>
    public class V1_LCOPENAPPLYTRNRS : IResponse
    {
        /// <summary>
        /// 3.20.1进口信用证开立响应主体
        /// </summary>
        public LCOPENAPPLYTRNRS LCOPENAPPLYTRNRS { get; set; }
    }
    /// <summary>
    /// 3.20.1进口信用证开立响应主体
    /// </summary>
    public class LCOPENAPPLYTRNRS : BIZRSBASE
    {
        /// <summary>
        /// 3.20.1进口信用证开立响应内容
        /// </summary>
        [XmlElement(Order = 2)]
        public LCOPENAPPLYTRN_RSBODY RSBODY { get; set; }
    }
    /// <summary>
    /// 3.20.1进口信用证开立响应内容
    /// </summary>
    public class LCOPENAPPLYTRN_RSBODY
    {
        /// <summary>
        /// 系统关联业务编号	必回
        /// </summary>
        [XmlElement(Order = 0)]
        public string XTREFERENCE { get; set; }
        /// <summary>
        /// 申请编号	必回
        /// </summary>
        [XmlElement(Order = 1)]
        public string APPLICATIONNO { get; set; }
        /// <summary>
        /// FORM OF L/C   必回
        /// I.IRREVOCABLE
        /// IT.IRREVOCABLE TRANSFERABLE
        /// </summary>
        [XmlElement(Order = 2)]
        public string LCFORMTYPE { get; set; }
        /// <summary>
        /// Nominal amount currency,3位	 必回
        /// </summary>
        [XmlElement(Order = 3)]
        public string NOMINALAMTCURR { get; set; }
        /// <summary>
        /// Nominal amount	 必回
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal NOMINALAMT { get; set; }
        /// <summary>
        /// Initial Code,5位兴业机构号，如果传空取客户所在的地区机构号(建议客户自己输)	非 必回
        /// </summary>
        [XmlElement(Order = 5)]
        public string INITIALCODE { get; set; }
        /// <summary>
        /// L/C Issued on, 日期yyyy-MM-dd	 必回 
        /// </summary>
        [XmlIgnore]
        public DateTime LCISSUEDDATE { get; set; }
        /// <summary>
        /// L/C Issued on, 日期yyyy-MM-dd, 对应<see cref="LCISSUEDDATE"/>	 必回 
        /// </summary>
        [XmlElement("LCISSUEDDATE", Order = 6)]
        public string LCISSUEDDATEStr
        {
            get
            {
                return this.LCISSUEDDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LCISSUEDDATE = tmp;
                }
            }
        }
        /// <summary>
        /// Latest Shipment Date, 日期yyyy-MM-dd	非 必回 
        /// </summary>
        [XmlIgnore]
        public DateTime? LASTESTSHIPMENTDATE { get; set; }
        /// <summary>
        /// Latest Shipment Date, 日期yyyy-MM-dd, 对应<see cref="LASTESTSHIPMENTDATE"/>	非 必回 
        /// </summary>
        [XmlElement("LASTESTSHIPMENTDATE", Order = 7)]
        public string LASTESTSHIPMENTDATEStr
        {
            get
            {
                return this.LASTESTSHIPMENTDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.LASTESTSHIPMENTDATE = null;
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LASTESTSHIPMENTDATE = tmp;
                }
            }
        }
        /// <summary>
        /// L/C Expiring on, 日期yyyy-MM-dd	 必回 
        /// </summary>
        [XmlIgnore]
        public DateTime LCEXPIRYDATE { get; set; }
        /// <summary>
        /// L/C Expiring on, 日期yyyy-MM-dd, 对应<see cref="LCEXPIRYDATE"/>	 必回 
        /// </summary>
        [XmlElement("LCEXPIRYDATE", Order = 8)]
        public string LCEXPIRYDATEStr
        {
            get
            {
                return this.LCEXPIRYDATE.ToString("yyyy-MM-dd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.LCEXPIRYDATE = tmp;
                }
            }
        }
        /// <summary>
        /// In（place）/counters of 长度：29	 必回
        /// </summary>
        [XmlElement(Order = 9)]
        public string EXPIRYPLACE { get; set; }
        /// <summary>
        /// Tenor 长度：4*40	 必回
        /// </summary>
        [XmlElement(Order = 10)]
        public string TENOR { get; set; }
        /// <summary>
        /// Applicable rules 目前仅支持：UCP LATEST VERSION 长度：30	 必回
        /// </summary>
        [XmlElement(Order = 11)]
        public string APPLICABLERULES { get; set; }
        /// <summary>
        /// Contract no. 长度：25	 必回
        /// </summary>
        [XmlElement(Order = 12)]
        public string CONTRACTNO { get; set; }
        /// <summary>
        /// Contract Amount	 必回
        /// </summary>
        [XmlElement(Order = 13)]
        public decimal CONTRACTAMT { get; set; }
        /// <summary>
        /// Applicant 长度：4*35	 必回
        /// </summary>
        [XmlElement(Order = 14)]
        public string APPLICANT { get; set; }
        /// <summary>
        /// Advising Bank 长度：4*35	 必回
        /// </summary>
        [XmlElement(Order = 15)]
        public string ADVISINGBANK { get; set; }
        /// <summary>
        /// Beneficiary 长度：4*35	 必回
        /// </summary>
        [XmlElement(Order = 16)]
        public string BENEFICIARY { get; set; }
        /// <summary>
        /// Confirm.Instructions  必回
        /// A:MAY ADD
        /// C:CONFIRM
        /// W:WITHOUT
        /// </summary>
        [XmlElement(Order = 17)]
        public string CONFIRMINSTRCTION { get; set; }
        /// <summary>
        /// Applicant Bank 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 18)]
        public string APPLICANTBANK { get; set; }
        /// <summary>
        /// 2nd advising bank 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 19)]
        public string ADVISINGBANK2ND { get; set; }
        /// <summary>
        /// Available with bank     必回
        /// A:Advising Bank
        /// I:Issuing Bank
        /// L:Iss.Bank of L/C
        /// O:Any Bank
        /// S:Specified Bank
        /// T:Transferring Bank
        /// </summary>
        [XmlElement(Order = 20)]
        public string AVBLWITHBANK { get; set; }
        /// <summary>
        /// Available by    必回
        /// A:BY ACCEPTANCE
        /// D:BY DEF PAYMENT
        /// M:BY MIXED PAYMENT
        /// N:BY NEGOTIATION
        /// P:BY PAYMENT 
        /// </summary>
        [XmlElement(Order = 21)]
        public string AVBLPYMTWAY { get; set; }
        /// <summary>
        /// Drafts at 长度：3*35	非 必回
        /// </summary>
        [XmlElement(Order = 22)]
        public string DRAFTESAT { get; set; }
        /// <summary>
        /// Drawee 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 23)]
        public string DRAWEE { get; set; }
        /// <summary>
        /// Def.Payment Details 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 24)]
        public string DEFPYMTDTL { get; set; }
        /// <summary>
        /// Mixed Payment Details 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 25)]
        public string MIXEDPYMTDTL { get; set; }
        /// <summary>
        /// Presentation Period 长度：4*35	非 必回
        /// </summary>
        [XmlElement(Order = 26)]
        public string PRESENTATIONPERIOD { get; set; }
        /// <summary>
        /// Details of Charges 长度：6*35	非 必回
        /// </summary>
        [XmlElement(Order = 27)]
        public string CHARGEDTL { get; set; }
        /// <summary>
        /// Country code,2位字母（国家代码）	 必回
        /// </summary>
        [XmlElement(Order = 28)]
        public string COUNTRYCODE { get; set; }
        /// <summary>
        /// Patial Shipment    非 必回
        /// N:NOT ALLOWED
        /// Y:ALLOWED
        /// </summary>
        [XmlElement(Order = 29)]
        public string PATIALSHIPMENT { get; set; }
        /// <summary>
        /// Transshipment    非 必回
        /// N:NOT ALLOWED
        /// Y:ALLOWED
        /// </summary>
        [XmlElement(Order = 30)]
        public string TRANSSHIPMENT { get; set; }
        /// <summary>
        /// Place of Taking in Charge/Dispatch from ,,,/Place of Receipt 长度：1*65	非 必回
        /// </summary>
        [XmlElement(Order = 31)]
        public string DISPATCHPLACE { get; set; }
        /// <summary>
        /// Port of loading/Airport of Departure 长度：1*65	非 必回
        /// </summary>
        [XmlElement(Order = 32)]
        public string LOADPORT { get; set; }
        /// <summary>
        /// Port of Discharge/Airport of Destination 长度：1*65	非 必回
        /// </summary>
        [XmlElement(Order = 33)]
        public string DISCHARGEPORT { get; set; }
        /// <summary>
        /// Place of Final Destination/For Transportation to …/Place of Delivery 长度：1*65	非 必回
        /// </summary>
        [XmlElement(Order = 34)]
        public string FINALDESTPLACE { get; set; }
        /// <summary>
        /// Shipment period 长度：6*65	非 必回
        /// </summary>
        [XmlElement(Order = 35)]
        public string SHIPMENTPERIOD { get; set; }
        /// <summary>
        /// GOODS DESCRIPTIONS 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 36)]
        public string GOODSDESC { get; set; }
        /// <summary>
        /// Documents 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 37)]
        public string DOCUMENTS { get; set; }
        /// <summary>
        /// additional conditions 长度：150*65	 必回
        /// </summary>
        [XmlElement(Order = 38)]
        public string ADDCONDITIONS { get; set; }
        /// <summary>
        /// 备注 允许中文 长度：6*35	非 必回
        /// </summary>
        [XmlElement(Order = 39)]
        public string COMMENT { get; set; }
        /// <summary>
        /// 指令处理状态	必回
        /// </summary>
        [XmlElement(Order = 40)]
        public XFERPRCSTS XFERPRCSTS { get; set; }
    }
}
