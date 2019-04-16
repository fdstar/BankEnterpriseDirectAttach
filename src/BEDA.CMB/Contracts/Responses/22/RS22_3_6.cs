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
    /// 22.3.6.票据信息综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS22_3_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTBILQRL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBILQRL";
        /// <summary>
        /// 22.3.6.票据信息综合查询响应集合
        /// </summary>
        [XmlElement("NTBILQRLZ1")]
        public List<NTBILQRLZ1> List { get; set; }
    }
    /// <summary>
    /// 22.3.6.票据信息综合查询响应内容
    /// </summary>
    public class NTBILQRLZ1
    {
        /// <summary>
        /// 票据号	C(20)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据标示号	C(20)
        /// </summary>
        public string BILSYN { get; set; }
        /// <summary>
        /// 票据种类	C(1)
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票面金额	M
        /// </summary>
        public decimal BILAMT { get; set; }
        /// <summary>
        /// 托管日期	D
        /// </summary>
        public string INPDAT { get; set; }
        /// <summary>
        /// 托管时间	T
        /// </summary>
        public string INPTIM { get; set; }
        /// <summary>
        /// 托管时间 由<see cref="INPDAT"/>和<see cref="INPTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime? TrusteeshipTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.INPDAT, this.INPTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return null;
            }
        }
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
        /// 出票日	D, 对应<see cref="ENDDAT"/>
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
        /// 银票出票人或商票付款人	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 出票人账号/付款人账号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 付款行行号/付款人开户行行号	C(12)
        /// </summary>
        public string BRDNBR { get; set; }
        /// <summary>
        /// 付款行名称/付款人开户行名称	Z(62)
        /// </summary>
        public string PAYBNK { get; set; }
        /// <summary>
        /// 付款行地址	Z(62)
        /// </summary>
        public string PAYADR { get; set; }
        /// <summary>
        /// 收款人全称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款人开户行	Z(62)
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string OWNNAM { get; set; }
        /// <summary>
        /// 持票人账号	C(35)
        /// </summary>
        public string OWNACC { get; set; }
        /// <summary>
        /// 持票人开户行	Z(62)
        /// </summary>
        public string OWNBNK { get; set; }
        /// <summary>
        /// 托管机构	C(6)	
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 票据状态	C(2)
        /// </summary>
        public string BILSTS { get; set; }
        /// <summary>
        /// 查询查复状态	C(2)
        /// </summary>
        public string QRYSTS { get; set; }
        /// <summary>
        /// 合同号	C(10)
        /// </summary>
        public string CTRNUM { get; set; }
        /// <summary>
        /// 承兑协议编号	C(60)
        /// </summary>
        public string PTCNUM { get; set; }
        /// <summary>
        /// 承兑日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PTCDAT { get; set; }
        /// <summary>
        /// 承兑日期	D, 对应<see cref="PTCDAT"/>
        /// </summary>
        [XmlElement("PTCDAT")]
        public string PTCDATStr
        {
            get
            {
                return this.PTCDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PTCDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PTCDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易合同号	C(60)
        /// </summary>
        public string CTRNBR { get; set; }
        /// <summary>
        /// 上一持票人名称	Z(62)
        /// </summary>
        public string LHDNAM { get; set; }
        /// <summary>
        /// 上一持票人账号	C(35)
        /// </summary>
        public string LHDACC { get; set; }
        /// <summary>
        /// 上一持票人开户行	Z(62)
        /// </summary>
        public string LHDBNK { get; set; }
        /// <summary>
        /// 是否背书	C(1)
        /// </summary>
        public string TRFFLG { get; set; }
        /// <summary>
        /// 背书次数	F(3,0)
        /// </summary>
        public string TRFTMS { get; set; }
        /// <summary>
        /// 说明	Z(200)  总共有00——27 共28种选项：
        /// 04  已发出托收033报文成功后记录,纸票发出托收.
        /// 05  发送失败从申请表向人行发送报文失败033报文确认失败.
        /// 06  已拒付托收拒付/提示付款对方拒绝签收都有.
        /// 07  托收已划回托收款项划回仅纸票.
        /// 15  追索成功.
        /// 23  作废不使用无需显示.
        /// </summary>
        public string DSCTXT { get; set; }
        /// <summary>
        /// 是否公示催告	C(1)
        /// </summary>
        public string LSTFLG { get; set; }
        /// <summary>
        /// 应收应付标志	C(1)    1 应收 2 应付
        /// </summary>
        public string PAYFLG { get; set; }
        /// <summary>
        /// 银行管理类型	C(1)
        /// </summary>
        public string MNGTYP { get; set; }
    }
}
