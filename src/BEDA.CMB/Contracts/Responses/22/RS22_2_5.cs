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
    /// 22.2.5.票据挂失止付定制查询票据明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_2_5 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBLQINF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBLQINF";
        /// <summary>
        /// 22.2.5.票据挂失止付定制查询票据明细响应内容
        /// </summary>
        public NTBLQINFZ1 NTBLQINFZ1 { get; set; }
    }
    /// <summary>
    /// 22.2.5.票据挂失止付定制查询票据明细响应内容
    /// </summary>
    public class NTBLQINFZ1
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
        /// 我行承兑标志	C(1)  
        /// </summary>
        public string INRFLG { get; set; }
        /// <summary>
        /// 银行码	C(3)
        /// </summary>
        public string BNKNBR { get; set; }
        /// <summary>
        /// 银票付款行行号或商票付款人开户行行号	F(12)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 付款客户号	C(10)
        /// </summary>
        public string PAYCLT { get; set; }
        /// <summary>
        /// 付款企业代码	Z(30)
        /// </summary>
        public string PAYCTF { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 付款人账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
    }
}
