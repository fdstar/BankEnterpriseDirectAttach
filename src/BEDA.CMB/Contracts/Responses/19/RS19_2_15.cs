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
    /// 19.2.15.票据信息综合查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS19_2_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKMAGINQ
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKMAGINQ";
        /// <summary>
        /// 19.2.15.票据信息综合查询响应集合
        /// </summary>
        [XmlElement("NTMAGINQZ")]
        public List<NTMAGINQZ> List { get; set; }
    }
    /// <summary>
    /// 19.2.15.票据信息综合查询响应内容
    /// </summary>
    public class NTMAGINQZ
    {
        /// <summary>
        /// 票据流水号	C(10)
        /// </summary>
        public string SEQNBR { get; set; }
        /// <summary>
        /// 票据类型	C(3)
        /// </summary>
        public string TKTTYP { get; set; }
        /// <summary>
        /// 网上票据标志	C(1)
        /// </summary>
        public string NETFLG { get; set; }
        /// <summary>
        /// 汇票号标志	C(4)
        /// </summary>
        public string TKTSQF { get; set; }
        /// <summary>
        /// 汇票号	C(20)
        /// </summary>
        public string TKTSEQ { get; set; }
        /// <summary>
        /// 付款人联行号	C(20)   电子票为机构号；托管实票为联行号，信息提示字段
        /// </summary>
        public string OPNBNK { get; set; }
        /// <summary>
        /// 票据中心标志	C(6)
        /// </summary>
        public string OPNBRH { get; set; }
        /// <summary>
        /// 付款行全称	Z(62)
        /// </summary>
        public string BNKNAM { get; set; }
        /// <summary>
        /// 付款行地址	Z(62)
        /// </summary>
        public string BNKADR { get; set; }
        /// <summary>
        /// 出票人名称	Z(62)
        /// </summary>
        public string PAYNAM { get; set; }
        /// <summary>
        /// 出票人帐号	C(35)
        /// </summary>
        public string PAYACC { get; set; }
        /// <summary>
        /// 出票人分行号	C(2)
        /// </summary>
        public string PAYBBK { get; set; }
        /// <summary>
        /// 企业银行编号	C(8)
        /// </summary>
        public string MCHNTB { get; set; }
        /// <summary>
        /// 客户编号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 汇票币种	C(2)
        /// </summary>
        public string TKTCUY { get; set; }
        /// <summary>
        /// 汇票金额	M
        /// </summary>
        public decimal? TKTAMT { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDTA { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="OPNDTA"/>
        /// </summary>
        [XmlElement("OPNDTA")]
        public string OPNDTAStr
        {
            get
            {
                return this.OPNDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDTA { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="ENDDTA"/>
        /// </summary>
        [XmlElement("ENDDTA")]
        public string ENDDTAStr
        {
            get
            {
                return this.ENDDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 承兑协议号	C(10)
        /// </summary>
        public string TSTSEQ { get; set; }
        /// <summary>
        /// 收款人企业银行编号	C(8)
        /// </summary>
        public string RCVNTB { get; set; }
        /// <summary>
        /// 收款人客户编号	C(10)
        /// </summary>
        public string RCVNBR { get; set; }
        /// <summary>
        /// 收款人开户行联行号	C(6)  电子票为机构号；托管实票为联行号前6位，信息提示字段
        /// </summary>
        public string RCVBNK { get; set; }
        /// <summary>
        /// 收款人票据中心标志	C(6)
        /// </summary>
        public string RCVBRH { get; set; }
        /// <summary>
        /// 收款人开户行名称	Z(62)
        /// </summary>
        public string RBKNAM { get; set; }
        /// <summary>
        /// 收款人名称	Z(62)
        /// </summary>
        public string RCVNAM { get; set; }
        /// <summary>
        /// 收款人账号	C(35)
        /// </summary>
        public string RCVACC { get; set; }
        /// <summary>
        /// 收款人分行号	C(2)
        /// </summary>
        public string RCVBBK { get; set; }
        /// <summary>
        /// 持票人企业银行编号	C(8)
        /// </summary>
        public string LSTNTB { get; set; }
        /// <summary>
        /// 持票人客户编号	C(10)
        /// </summary>
        public string LSTNBR { get; set; }
        /// <summary>
        /// 持票人名称	Z(62)
        /// </summary>
        public string LSTNAM { get; set; }
        /// <summary>
        /// 托管票据中心标志	C(6)
        /// </summary>
        public string SAVBRH { get; set; }
        /// <summary>
        /// 托管票据中心名称	Z(62)
        /// </summary>
        public string SAVNAM { get; set; }
        /// <summary>
        /// 托管票据来源标志	C(10)
        /// </summary>
        public string SAVSOC { get; set; }
        /// <summary>
        /// 背书标志	C(1)
        /// </summary>
        public string WRTFLG { get; set; }
        /// <summary>
        /// 不可转让标志	C(1)
        /// </summary>
        public string TRMFLG { get; set; }
        /// <summary>
        /// 票据当前交易状态	C(1)
        /// </summary>
        public string TRSSTA { get; set; }
        /// <summary>
        /// 托管日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? HADIND { get; set; }
        /// <summary>
        /// 托管日期	D, 对应<see cref="HADIND"/>
        /// </summary>
        [XmlElement("HADIND")]
        public string HADINDStr
        {
            get
            {
                return this.HADIND?.ToString("yyyyMMdd");
            }
            set
            {
                this.HADIND = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.HADIND = tmp;
                }
            }
        }
        /// <summary>
        /// 汇票状态	C(1)
        /// </summary>
        public string TKTSTA { get; set; }
        /// <summary>
        /// 记录状态	C(1)
        /// </summary>
        public string RCDSTS { get; set; }
        /// <summary>
        /// 托管日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? MNTDTA { get; set; }
        /// <summary>
        /// 托管日期	D, 对应<see cref="MNTDTA"/>
        /// </summary>
        [XmlElement("MNTDTA")]
        public string MNTDTAStr
        {
            get
            {
                return this.MNTDTA?.ToString("yyyyMMdd");
            }
            set
            {
                this.MNTDTA = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTDTA = tmp;
                }
            }
        }
        /// <summary>
        /// 保留字段	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
