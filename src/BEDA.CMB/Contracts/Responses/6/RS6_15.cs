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
    /// 6.15.平台查询票据明细信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS6_15 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECDPLF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECDPLF";
        /// <summary>
        /// 6.15.平台查询票据明细信息响应集合 票据正面信息明细
        /// </summary>
        [XmlElement("NTDRFDTLZ1")]
        public List<NTDRFDTLZ1> NTDRFDTLZ1List { get; set; }
        /// <summary>
        /// 6.15.平台查询票据明细信息响应内容 票据背面信息明细
        /// </summary>
        [XmlElement("NTDRFDTLZ2")]
        public List<NTDRFDTLZ2> NTDRFDTLZ2List { get; set; }
    }
    /// <summary>
    /// 6.15.平台查询票据明细信息响应内容 票据正面信息明细
    /// </summary>
    public class NTDRFDTLZ1
    {
        /// <summary>
        /// 人行电子票据号码	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 票据种类	C(4)	AC02=商承 AC01=银承  
        /// </summary>
        public string BILTYP { get; set; }
        /// <summary>
        /// 票据货币	C(2)
        /// </summary>
        public string BILCCY { get; set; }
        /// <summary>
        /// 票据金额	M
        /// </summary>
        public decimal? BILAMT { get; set; }
        /// <summary>
        /// 出票日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ISUDAT { get; set; }
        /// <summary>
        /// 出票日期	D, 对应<see cref="ISUDAT"/>
        /// </summary>
        [XmlElement("ISUDAT")]
        public string ISUDATStr
        {
            get
            {
                return this.ISUDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ISUDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ISUDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? DUEDAT { get; set; }
        /// <summary>
        /// 到期日	D, 对应<see cref="DUEDAT"/>
        /// </summary>
        [XmlElement("DUEDAT")]
        public string DUEDATStr
        {
            get
            {
                return this.DUEDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.DUEDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DUEDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 提示付款期最后一天	D
        /// </summary>
        [XmlIgnore]
        public DateTime? NTFDAT { get; set; }
        /// <summary>
        /// 提示付款期最后一天	D, 对应<see cref="NTFDAT"/>
        /// </summary>
        [XmlElement("NTFDAT")]
        public string NTFDATStr
        {
            get
            {
                return this.NTFDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.NTFDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NTFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 不得转让标记	C(4)	EM01=不得转让 EM00=可再转让
        /// </summary>
        public string NOTTRF { get; set; }
        /// <summary>
        /// 到期无条件支付委托	C(4)	CC01=不含委托/不承诺兑付 CC00=含委托/承诺兑付.
        /// </summary>
        public string PAYAGT { get; set; }
        /// <summary>
        /// 到期无条件支付承诺	C(4)	CC01=不含委托/不承诺兑付 CC00=含委托/承诺兑付.
        /// </summary>
        public string PAYPMT { get; set; }
        /// <summary>
        /// 票据产品实例号	C(10)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 票据管理机构	C(6)
        /// </summary>
        public string MNGBRN { get; set; }
        /// <summary>
        /// 出票人客户类型	C(4)	RC05=财务公司 RC04=被代理财务公司 RC03=被代理行 RC02=人民银行 RC01=企业 RC00=银行
        /// </summary>
        public string DRWTYP { get; set; }
        /// <summary>
        /// 出票人组织机构代码	C(20)
        /// </summary>
        public string DRWORG { get; set; }
        /// <summary>
        /// 出票人名称	Z(200)
        /// </summary>
        public string DRWNAM { get; set; }
        /// <summary>
        /// 出票人行号	C(12)
        /// </summary>
        public string DRWBRD { get; set; }
        /// <summary>
        /// 出票人开户银行	Z(200)
        /// </summary>
        public string DRWBAM { get; set; }
        /// <summary>
        /// 出票人账号	C(35)
        /// </summary>
        public string DRWEAC { get; set; }
        /// <summary>
        /// 出票人客户号	C(10)   我行客户有值
        /// </summary>
        public string DRWCLT { get; set; }
        /// <summary>
        /// 出票人开户机构	C(6)    我行客户有值
        /// </summary>
        public string DRWBRN { get; set; }
        /// <summary>
        /// 出票人信用等级	C(3)
        /// </summary>
        public string DRWRAT { get; set; }
        /// <summary>
        /// 出票人评级机构	Z(200)
        /// </summary>
        public string DRWCAG { get; set; }
        /// <summary>
        /// 出票人评级到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? DRWDUE { get; set; }
        /// <summary>
        /// 出票人评级到期日	D, 对应<see cref="DRWDUE"/>
        /// </summary>
        [XmlElement("DRWDUE")]
        public string DRWDUEStr
        {
            get
            {
                return this.DRWDUE?.ToString("yyyyMMdd");
            }
            set
            {
                this.DRWDUE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DRWDUE = tmp;
                }
            }
        }
        /// <summary>
        /// 权利人客户类型	C(4)	RC05=财务公司 RC04=被代理财务公司 RC03=被代理行 RC02=人民银行 RC01=企业 RC00=银行
        /// </summary>
        public string OWNTYP { get; set; }
        /// <summary>
        /// 权利人组织机构代码	C(20)
        /// </summary>
        public string OWNORG { get; set; }
        /// <summary>
        /// 权利人名称	Z(200)
        /// </summary>
        public string OWNNAM { get; set; }
        /// <summary>
        /// 权利人行号	C(12)
        /// </summary>
        public string OWNBRD { get; set; }
        /// <summary>
        /// 权利人账号	C(35)
        /// </summary>
        public string OWNEAC { get; set; }
        /// <summary>
        /// 权利人客户号	C(10)   我行客户有值
        /// </summary>
        public string OWNCLT { get; set; }
        /// <summary>
        /// 权利人开户机构	C(6)    我行客户有值
        /// </summary>
        public string OWNBRN { get; set; }
        /// <summary>
        /// 收票人客户类型	C(4)	RC05=财务公司 RC04=被代理财务公司 RC03=被代理行 RC02=人民银行 RC01=企业 RC00=银行
        /// </summary>
        public string PYETYP { get; set; }
        /// <summary>
        /// 收票人组织机构代码	C(20)
        /// </summary>
        public string PYEORG { get; set; }
        /// <summary>
        /// 收票人名称	Z(200)
        /// </summary>
        public string PYENAM { get; set; }
        /// <summary>
        /// 收票人行号	C(12)
        /// </summary>
        public string PYEBRD { get; set; }
        /// <summary>
        /// 收票人开户银行	Z(200)
        /// </summary>
        public string PYEBAM { get; set; }
        /// <summary>
        /// 收票人账号	C(35)
        /// </summary>
        public string PYEEAC { get; set; }
        /// <summary>
        /// 收票人客户号	C(10)   我行客户有值
        /// </summary>
        public string PYECLT { get; set; }
        /// <summary>
        /// 收票人开户机构	C(6)    我行客户有值
        /// </summary>
        public string PYEBRN { get; set; }
        /// <summary>
        /// 承兑人客户类型	C(4)	RC05=财务公司 RC04=被代理财务公司 RC03=被代理行 RC02=人民银行 RC01=企业 RC00=银行
        /// </summary>
        public string ACPTYP { get; set; }
        /// <summary>
        /// 承兑人组织机构代码	C(20)
        /// </summary>
        public string ACPORG { get; set; }
        /// <summary>
        /// 承兑人名称	Z(200)
        /// </summary>
        public string ACPNAM { get; set; }
        /// <summary>
        /// 承兑人行号	C(12)
        /// </summary>
        public string ACPBRD { get; set; }
        /// <summary>
        /// 承兑人开户银行	Z(200)
        /// </summary>
        public string ACPBAM { get; set; }
        /// <summary>
        /// 承兑人账号	C(35)
        /// </summary>
        public string ACPEAC { get; set; }
        /// <summary>
        /// 承兑人客户号	C(10)   我行客户有值
        /// </summary>
        public string ACPCLT { get; set; }
        /// <summary>
        /// 承兑人开户机构	C(6)    我行客户有值
        /// </summary>
        public string ACPBRN { get; set; }
        /// <summary>
        /// 承兑人信用等级	C(3)
        /// </summary>
        public string ACPRAT { get; set; }
        /// <summary>
        /// 承兑人评级机构	Z(200)
        /// </summary>
        public string ACPCAG { get; set; }
        /// <summary>
        /// 承兑人评级到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime ACPDUE { get; set; }
        /// <summary>
        /// 承兑人评级到期日	D, 对应<see cref="ACPDUE"/>
        /// </summary>
        [XmlElement("ACPDUE")]
        public string ACPDUEStr
        {
            get
            {
                return this.ACPDUE.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ACPDUE = tmp;
                }
            }
        }
        /// <summary>
        /// 未结前手行号	C(12)
        /// </summary>
        public string NOEBRD { get; set; }
        /// <summary>
        /// 未结前手账号	C(35)
        /// </summary>
        public string NOEEAC { get; set; }
        /// <summary>
        /// 未结前手客户号	C(10)   我行客户有值
        /// </summary>
        public string NOECLT { get; set; }
        /// <summary>
        /// 未结前手开户机构	C(6)    我行客户有值
        /// </summary>
        public string NOEBRN { get; set; }
        /// <summary>
        /// 追索标志	C(4)	RT01=非拒付追索 RT00=拒付追索
        /// </summary>
        public string CLMTAG { get; set; }
        /// <summary>
        /// 我行管理标志	C(1)	Y：在我行管理 N：在他行管理
        /// </summary>
        public string CMBTAG { get; set; }
        /// <summary>
        /// 人行票据状态	C(6)	附录A.50
        /// </summary>
        public string PBLSTS { get; set; }
        /// <summary>
        /// 最后背书不得转让标记	C(4)	EM01=不得转让 EM00=可再转让
        /// </summary>
        public string ENDTRF { get; set; }
        /// <summary>
        /// 交易合同编号	Z(62)
        /// </summary>
        public string CNTNBR { get; set; }
        /// <summary>
        /// 备注	Z(800)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 保留字	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
    /// <summary>
    /// 6.15.平台查询票据明细信息响应内容 票据背面信息明细
    /// </summary>
    public class NTDRFDTLZ2
    {
        /// <summary>
        /// 人民银行票号	C(30)
        /// </summary>
        public string BILNBR { get; set; }
        /// <summary>
        /// 行为流水	F(4,0)
        /// </summary>
        public string ACTSEQ { get; set; }
        /// <summary>
        /// 对应请求流水	F(4,0)
        /// </summary>
        public string RQSSEQ { get; set; }
        /// <summary>
        /// 业务编码	C(2)	附录A.51
        /// </summary>
        public string BUSCOD { get; set; }
        /// <summary>
        /// 业务子类型	C(2)
        /// </summary>
        public string SUBTYP { get; set; }
        /// <summary>
        /// 发起方组织机构代码	C(20)
        /// </summary>
        public string ISCORG { get; set; }
        /// <summary>
        /// 发起方名称	Z(350)
        /// </summary>
        public string ISCNAM { get; set; }
        /// <summary>
        /// 发起方行号	C(12)
        /// </summary>
        public string ISCBRD { get; set; }
        /// <summary>
        /// 发起方承接行号	C(12)
        /// </summary>
        public string ISCAGC { get; set; }
        /// <summary>
        /// 发起方账号	C(35)
        /// </summary>
        public string ISCEAC { get; set; }
        /// <summary>
        /// 发起方客户号	C(10)   我行客户有值
        /// </summary>
        public string ISCCLT { get; set; }
        /// <summary>
        /// 发起方开户机构	C(6)    我行客户有值
        /// </summary>
        public string ISCBRN { get; set; }
        /// <summary>
        /// 对手方组织机构代码	C(20)
        /// </summary>
        public string OPCORG { get; set; }
        /// <summary>
        /// 对手方名称	Z(350)
        /// </summary>
        public string OPCNAM { get; set; }
        /// <summary>
        /// 对手方行号	C(12)
        /// </summary>
        public string OPCBRD { get; set; }
        /// <summary>
        /// 对手方承接行号	C(12)
        /// </summary>
        public string OPCAGC { get; set; }
        /// <summary>
        /// 对手方账号	C(35)
        /// </summary>
        public string OPCEAC { get; set; }
        /// <summary>
        /// 对手方客户号	C(10)   我行客户有值
        /// </summary>
        public string OPCCLT { get; set; }
        /// <summary>
        /// 对手方开户机构	C(6)    我行客户有值
        /// </summary>
        public string OPCBRN { get; set; }
        /// <summary>
        /// 对手方信用等级	C(3)
        /// </summary>
        public string OPCRAT { get; set; }
        /// <summary>
        /// 对手方评级机构	Z(100)
        /// </summary>
        public string OPCCAG { get; set; }
        /// <summary>
        /// 对手方评级到期日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPCDUE { get; set; }
        /// <summary>
        /// 对手方评级到期日	D, 对应<see cref="OPCDUE"/>
        /// </summary>
        [XmlElement("OPCDUE")]
        public string OPCDUEStr
        {
            get
            {
                return this.OPCDUE?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPCDUE = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPCDUE = tmp;
                }
            }
        }
        /// <summary>
        /// 签收日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SGNDAT { get; set; }
        /// <summary>
        /// 签收日期	D, 对应<see cref="SGNDAT"/>
        /// </summary>
        [XmlElement("SGNDAT")]
        public string SGNDATStr
        {
            get
            {
                return this.SGNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SGNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SGNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 回复标记	C(4)	SU01=拒绝签收 SU00=同意签收
        /// </summary>
        public string ANSCOD { get; set; }
        /// <summary>
        /// 交易合同编号	Z(62)
        /// </summary>
        public string CNTNBR { get; set; }
        /// <summary>
        /// 发票号码 	Z(62)
        /// </summary>
        public string INVNBR { get; set; }
        /// <summary>
        /// 协议编号	Z(62)
        /// </summary>
        public string CNVNBR { get; set; }
        /// <summary>
        /// 到期无条件支付委托	C(1)	Y/N
        /// </summary>
        public string PAYAGT { get; set; }
        /// <summary>
        /// 到期无条件支付承诺	C(1)	Y/N
        /// </summary>
        public string PAYPMT { get; set; }
        /// <summary>
        /// 不能转让标记	C(1)
        /// </summary>
        public string NOTTRF { get; set; }
        /// <summary>
        /// 线上清算标记	C(1)
        /// </summary>
        public string DVPTAG { get; set; }
        /// <summary>
        /// 贴现种类	C(2)
        /// </summary>
        public string DISTYP { get; set; }
        /// <summary>
        /// 贴现类型	C(4)
        /// </summary>
        public string DISMOD { get; set; }
        /// <summary>
        /// 贴现利率	F(11,7)
        /// </summary>
        public decimal? DISINR { get; set; }
        /// <summary>
        /// 贴现实付金额	M
        /// </summary>
        public decimal? FCTAMT { get; set; }
        /// <summary>
        /// 赎回开放日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? OPNDAT { get; set; }
        /// <summary>
        /// 赎回开放日	D, 对应<see cref="OPNDAT"/>
        /// </summary>
        [XmlElement("OPNDAT")]
        public string OPNDATStr
        {
            get
            {
                return this.OPNDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.OPNDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.OPNDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回截止日	D
        /// </summary>
        [XmlIgnore]
        public DateTime? ENDDAT { get; set; }
        /// <summary>
        /// 赎回截止日	D, 对应<see cref="ENDDAT"/>
        /// </summary>
        [XmlElement("ENDDAT")]
        public string ENDDATStr
        {
            get
            {
                return this.ENDDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.ENDDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ENDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 贴现赎回利率	F(11,7)
        /// </summary>
        public decimal? BCKINR { get; set; }
        /// <summary>
        /// 贴现赎回金额	M
        /// </summary>
        public decimal? BCKAMT { get; set; }
        /// <summary>
        /// 提示付款申请日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PYADAT { get; set; }
        /// <summary>
        /// 提示付款申请日期	D, 对应<see cref="PYADAT"/>
        /// </summary>
        [XmlElement("PYADAT")]
        public string PYADATStr
        {
            get
            {
                return this.PYADAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PYADAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PYADAT = tmp;
                }
            }
        }
        /// <summary>
        /// 交易币种	C(2)
        /// </summary>
        public string TRXCCY { get; set; }
        /// <summary>
        /// 交易金额	M
        /// </summary>
        public decimal? TRXAMT { get; set; }
        /// <summary>
        /// 拒付代码	C(4)
        /// </summary>
        public string RFSCOD { get; set; }
        /// <summary>
        /// 备注信息	Z(256)
        /// </summary>
        public string DESTXT { get; set; }
        /// <summary>
        /// 追索类型	C(4)	RT01=非拒付追索 RT00=拒付追索
        /// </summary>
        public string TROTYP { get; set; }
        /// <summary>
        /// 追索通知日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? INFDAT { get; set; }
        /// <summary>
        /// 追索通知日期	D, 对应<see cref="INFDAT"/>
        /// </summary>
        [XmlElement("INFDAT")]
        public string INFDATStr
        {
            get
            {
                return this.INFDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.INFDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.INFDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 清偿日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? DSCDAT { get; set; }
        /// <summary>
        /// 清偿日期	D, 对应<see cref="DSCDAT"/>
        /// </summary>
        [XmlElement("DSCDAT")]
        public string DSCDATStr
        {
            get
            {
                return this.DSCDAT?.ToString("yyyyMMdd");
            }
            set
            {
                this.DSCDAT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DSCDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 清偿金额	M
        /// </summary>
        public decimal? DSCAMT { get; set; }
        /// <summary>
        /// 入账行号	C(12)
        /// </summary>
        public string ACCBRD { get; set; }
        /// <summary>
        /// 入账账号	C(35)
        /// </summary>
        public string ACCEAC { get; set; }
        /// <summary>
        /// 保留字	C(30)
        /// </summary>
        public string RSV30Z { get; set; }
    }
}
