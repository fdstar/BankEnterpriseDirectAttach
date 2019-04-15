using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Responses
{
    /// <summary>
    /// 22.2.4.票据挂失止付定制查询综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_2_4 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBLQQRY
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQQRY";
        /// <summary>
        /// 22.2.4.票据挂失止付定制查询综合查询响应集合
        /// </summary>
        [XmlElement("NTBLQQRYZ1")]
        public List<NTBLQQRYZ1> List { get; set; }
        /// <summary>
        /// 22.2.4.票据挂失止付定制查询综合查询响应内容
        /// </summary>
        public Requests.NTBLQQRYY1 NTBLQQRYY1 { get; set; }
    }
    /// <summary>
    /// 22.2.4.票据挂失止付定制查询综合查询响应内容
    /// </summary>
    public class NTBLQQRYZ1
    {
        /// <summary>
        /// 查询账号分行号	C(2)	A.1 招行分行
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 查询账号帐号	C(35)
        /// </summary>
        public string ACCNBR { get; set; }
        /// <summary>
        /// 票据号码	C(20）
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据种类	C(3)	‘100’银票‘200’商票
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 出票日	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPNDAT { get; set; }
        /// <summary>
        /// 出票日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 银票承兑行或商票付款人开户行	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 银票出票人或商票付款人	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 收款人	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 挂失止付状态	C(1)
        /// </summary>
        public string LSTFLG { get; set; }
        /// <summary>
        /// 定制状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 定制查询日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime OPRDAT { get; set; }
        /// <summary>
        /// 定制查询日期	D, 对应<see cref="OPRDAT"/>
        /// </summary>
        [XmlElement("OPRDAT")]
        public string OPRDATStr
        {
            get
            {
                return this.OPRDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPRDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? EXPDAT { get; set; }
        /// <summary>
        /// 截止日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.EXPDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 通知次数	F(3,0)
        /// </summary>
        public string NTFITM { get; set; }
    }
}
