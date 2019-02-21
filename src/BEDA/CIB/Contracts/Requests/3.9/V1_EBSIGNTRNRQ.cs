using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求主体
    /// </summary>
    public class V1_EBSIGNTRNRQ : IRequest<V1_EBSIGNTRNRS>
    {
        /// <summary>
        /// 3.9.2.15电子商业汇票通用签收/拒签请求主体
        /// </summary>
        public EBSIGNTRNRQ EBSIGNTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求主体
    /// </summary>
    public class EBSIGNTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.2.15电子商业汇票通用签收/拒签请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBSIGNTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求内容
    /// </summary>
    public class EBSIGNTRN_RQBODY
    {
        /// <summary>
        /// 票据总笔数,8位整数	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public int TOTALCOUNT
        {
            get
            {
                return this.List?.Count ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 票据总金额, 17位(15整数位,2小数位) 	必输
        /// </summary>
        [XmlElement(Order = 4)]
        public decimal TOTALAMT
        {
            get
            {
                return this.List?.Sum(c => c.BILLAMT) ?? 0;
            }
            set { }
        }
        /// <summary>
        /// 签收日期 YYYY-MM-DD 必输
        /// </summary>
        [XmlIgnore]
        public DateTime SIGNDATE { get; set; }
        /// <summary>
        /// 签收日期 YYYY-MM-DD, 对应<see cref="SIGNDATE"/> 必输
        /// </summary>
        [XmlElement("SIGNDATE", Order = 5)]
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
        /// 签收人账户代号,最大32位	必输
        /// </summary>
        [XmlElement(Order = 6)]
        public string ACCTID { get; set; }
        /// <summary>
        /// 签收结果,4位 (SU00:同意签收, SU01:拒绝签收)	必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string SIGNRSLT { get; set; }
        /// <summary>
        /// 拒签理由, 4位见附录:拒付理由/拒签理由，拒签时必输	非必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string RJRSN { get; set; }
        /// <summary>
        /// 拒签备注,最大256位，拒签理由为DC09，CP06时必输	非必输
        /// </summary>
        [XmlElement(Order = 9)]
        public string RJMEMO { get; set; }
        /// <summary>
        /// 签收人备注,最大256位	非必输
        /// </summary>
        [XmlElement(Order = 10)]
        public string SIGNMEMO { get; set; }
        /// <summary>
        /// 3.9.2.15电子商业汇票通用签收/拒签请求集合
        /// </summary>
        [XmlElement("CONTENT", Order = 30)]
        public List<EBSIGNTRN_CONTENT> List { get; set; }
    }
    /// <summary>
    /// 3.9.2.15电子商业汇票通用签收/拒签请求明细
    /// </summary>
    public class EBSIGNTRN_CONTENT
    {
        /// <summary>
        /// 小序号,4位	必输
        /// </summary>
        [XmlElement(Order = 0)]
        public int INDX { get; set; }
        /// <summary>
        /// 票据号码,30位	必输
        /// </summary>
        [XmlElement(Order = 1)]
        public string BILLCODE { get; set; }
        /// <summary>
        /// 票据金额,17位(15整数位,2小数位)	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public decimal BILLAMT { get; set; }
        /// <summary>
        /// 业务类型,2位,见: 附录3-通用签收业务类型对照表	必输
        /// </summary>
        [XmlElement(Order = 3)]
        public string BUSINESSTYPE { get; set; }
        /// <summary>
        /// 签收人地址,1-60位	非必输
        /// </summary>
        [XmlElement(Order = 4)]
        public string ADDR { get; set; }
        /// <summary>
        /// 到期无条件支付委托,4位只能是CC00	必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string ENTRSPAY { get; set; } = "CC00";
        /// <summary>
        /// 承兑人信用等级信息	非必输                              
        /// </summary>
        [XmlElement(Order = 6)]
        public CREDITINFO ACPTRCRD { get; set; }
        /// <summary>
        /// 协议号,承兑,贴现时有效,0-30位	非必输
        /// </summary>
        [XmlElement(Order = 7)]
        public string AGRM { get; set; }
        /// <summary>
        /// 业务标识号,最大35位，待签收票据查询中获取	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public string BIZFLAG { get; set; }
    }
}
