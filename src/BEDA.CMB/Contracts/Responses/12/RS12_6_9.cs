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
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS12_6_9 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTPAYQRT
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYQRT";
        /// <summary>
        /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应内容
        /// </summary>
        public NTPAYQRTZ NTPAYQRTZ { get; set; }
        /// <summary>
        /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTPAYOUTZ")]
        public List<NTPAYOUTZ> NTPAYOUTZList { get; set; }
        /// <summary>
        /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应集合
        /// </summary>
        [XmlElement("NTPAYRCVZ")]
        public List<NTPAYRCVZ> NTPAYRCVZList { get; set; }
    }
    /// <summary>
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应内容
    /// </summary>
    public class NTPAYQRTZ
    {
        /// <summary>
        /// 本轮次笔数	N(6)
        /// </summary>
        public int LODCNT { get; set; }
        /// <summary>
        /// 本轮次接口种类	C(3)    OUT：支出 RCV：收入
        /// </summary>
        public string TRSTYP { get; set; }
    }
    /// <summary>
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应内容
    /// </summary>
    public class NTPAYOUTZ
    {
        /// <summary>
        /// 批次号 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 轮次序号	N(6)    查询,上传,不带续传,一次传输完成 按照轮次上传,下传 客户可指定查询第N轮的数据.
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 交易唯一序号	C(22)
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 汇款人类型	C(1)
        /// </summary>
        public string CLTTYP { get; set; }
        /// <summary>
        /// 证件号码	Z(30)
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 组织机构代码	C(9)
        /// </summary>
        public string ORGCOD { get; set; }
        /// <summary>
        /// 汇款人名称	Z(128)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 收款人名称	Z(128)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 汇款币种	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 汇款金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结汇汇率	F(13,8)
        /// </summary>
        public decimal EXBINR { get; set; }
        /// <summary>
        /// 结汇金额	M
        /// </summary>
        public decimal EXBAMT { get; set; }
        /// <summary>
        /// 人民币帐号/银行卡号	C(32)
        /// </summary>
        public string CCYCRD { get; set; }
        /// <summary>
        /// 现汇金额  	F(15,2)
        /// </summary>
        public decimal CFCAMT { get; set; }
        /// <summary>
        /// 外汇帐号/银行卡号	C(32)
        /// </summary>
        public string FRGCRD { get; set; }
        /// <summary>
        /// 其它金额	M
        /// </summary>
        public decimal OTHAMT { get; set; }
        /// <summary>
        /// 其它帐号/银行卡号  	C(32)
        /// </summary>
        public string OTHCRD { get; set; }
        /// <summary>
        /// 结算方式	C(1)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 付款人常驻国家/地区代码	C(3)
        /// </summary>
        public string CLTCNR { get; set; }
        /// <summary>
        /// 收款性质	C(1)
        /// </summary>
        public string RCVTYP { get; set; }
        /// <summary>
        /// 交易编码1	C(6)
        /// </summary>
        public string TRSCD1 { get; set; }
        /// <summary>
        /// 相应金额1	M
        /// </summary>
        public decimal TRSAM1 { get; set; }
        /// <summary>
        /// 交易附言1	Z(50)
        /// </summary>
        public string ORTIN1 { get; set; }
        /// <summary>
        /// 交易编码2	C(6)
        /// </summary>
        public string TRSCD2 { get; set; }
        /// <summary>
        /// 相应金额2	M
        /// </summary>
        public decimal TRSAM2 { get; set; }
        /// <summary>
        /// 交易附言2	Z(50)
        /// </summary>
        public string ORTIN2 { get; set; }
        /// <summary>
        /// 是否保税货物项下收汇	C(1)
        /// </summary>
        public string TAXFLG { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	Z(50)
        /// </summary>
        public string IMPNBR { get; set; }
        /// <summary>
        /// 收入类型	C(1)
        /// </summary>
        public string INCTYP { get; set; }
        /// <summary>
        /// 填报人	Z(20)
        /// </summary>
        public string FILNAM { get; set; }
        /// <summary>
        /// 填报人电话	Z(20)
        /// </summary>
        public string FILTEL { get; set; }
        /// <summary>
        /// 填报日期	D   在汇入汇款（母业务）入账后再申报，填写申报当天
        /// </summary>
        [XmlIgnore]
        public DateTime FILDAT { get; set; }
        /// <summary>
        /// 填报日期	D, 对应<see cref="FILDAT"/>
        /// </summary>
        [XmlElement("FILDAT")]
        public string FILDATStr
        {
            get
            {
                return this.FILDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FILDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 原业务参考号	C(30)
        /// </summary>
        public string LSTREF { get; set; }
        /// <summary>
        /// 原交易唯一序号	C(22)
        /// </summary>
        public string LSTEVT { get; set; }
        /// <summary>
        /// 已报关收款金额	M
        /// </summary>
        public decimal? RCPCAM { get; set; }
        /// <summary>
        /// 预收款金额	M
        /// </summary>
        public decimal? RCPPAM { get; set; }
        /// <summary>
        /// 无货物报关的货物其他金额
        /// </summary>
        public decimal? RCPNAM { get; set; }
        /// <summary>
        /// 无货物离岸转手买卖金额	M
        /// </summary>
        public decimal? RCPOAM { get; set; }
        /// <summary>
        /// 无货物物流货物金额	M
        /// </summary>
        public decimal? RCPGAM { get; set; }
        /// <summary>
        /// 已备案收款金额	M
        /// </summary>
        public decimal? RCPRAM { get; set; }
        /// <summary>
        /// 货物贸易收款金额	M
        /// </summary>
        public decimal? RCPHAM { get; set; }
        /// <summary>
        /// 预付款比率	F(3,2)
        /// </summary>
        public decimal? RCPPSC { get; set; }
        /// <summary>
        /// 结账期	N(8)    单位是天
        /// </summary>
        public int? RCPAPE { get; set; }
        /// <summary>
        /// 报关经营单位机构代码	C(9)
        /// </summary>
        public string RCPCOD { get; set; }
        /// <summary>
        /// 报关单经营单位名称	Z(128)
        /// </summary>
        public string RCPCNM { get; set; }
        /// <summary>
        /// 贸易类型	C(1)	1一般贸易； 2进料加工； 3来料加工； 4其他贸易； 5边境贸易
        /// </summary>
        public string RCPTCL { get; set; }
        /// <summary>
        /// 进出口日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RCPCDT { get; set; }
        /// <summary>
        /// 进出口日期	D, 对应<see cref="RCPCDT"/>
        /// </summary>
        [XmlElement("RCPCDT")]
        public string RCPCDTStr
        {
            get
            {
                return this.RCPCDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RCPCDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCPCDT = tmp;
                }
            }
        }
        /// <summary>
        /// 对应货值金额	M
        /// </summary>
        public decimal? RCPBCA { get; set; }
        /// <summary>
        /// 报关收付类型	C(1)	1人民币报关 - 人民币结算； 3外币报关 - 人民币结算 
        /// </summary>
        public string RCPBTP { get; set; }
        /// <summary>
        /// RCPMIS服务贸易交易编码	C(6)    满足参数：FMRCPDCD（支出） FMRCPTRS（收入）
        /// </summary>
        public string RCPBCD { get; set; }
        /// <summary>
        /// 服务贸易金额	M
        /// </summary>
        public decimal? RCPSAM { get; set; }
        /// <summary>
        /// 交易合同号	Z(32)
        /// </summary>
        public string RCPCNB { get; set; }
        /// <summary>
        /// 补录编号	C(22)
        /// </summary>
        public string ADDNBR { get; set; }
        /// <summary>
        /// RCPMIS还原编号	C(22)
        /// </summary>
        public string RCPNBR { get; set; }
        /// <summary>
        /// 国际收支还原情况	C(1)
        /// </summary>
        public string RPTFLG { get; set; }
        /// <summary>
        /// RCPMIS 还原情况	C(1)
        /// </summary>
        public string RCPFLG { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string MSGCOD { get; set; }
        /// <summary>
        /// 状态	C(1)    A：有效 E：自动补录异常 P: 已补录
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 最后维护日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime MNTTIM { get; set; }
        /// <summary>
        /// 最后维护日期	D, 对应<see cref="MNTTIM"/>
        /// </summary>
        [XmlElement("MNTTIM")]
        public string MNTTIMStr
        {
            get
            {
                return this.MNTTIM.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTTIM = tmp;
                }
            }
        }
    }
    /// <summary>
    /// 12.6.9.支付机构查询汇款类业务项下子业务明细响应内容
    /// </summary>
    public class NTPAYRCVZ
    {
        /// <summary>
        /// 批次号 流程实例号	C(10)
        /// </summary>
        public string REQNBR { get; set; }
        /// <summary>
        /// 轮次序号	N(6)    	查询，上传，不带续传，一次传输完成按照轮次上传，下传客户可指定查询第N轮的数据
        /// </summary>
        public int LODSEQ { get; set; }
        /// <summary>
        /// 交易唯一序号	C(22)
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 身份证件号码	Z(30)
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 组织机构代码	C(9)
        /// </summary>
        public string ORGCOD { get; set; }
        /// <summary>
        /// 收款人名称	Z(128)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 付款人名称	Z(128)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 收入款币种	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 收入款金额	M
        /// </summary>
        public string TRSAMT { get; set; }
        /// <summary>
        /// 结汇汇率	F(13,8)
        /// </summary>
        public decimal EXBINR { get; set; }
        /// <summary>
        /// 结汇金额	M
        /// </summary>
        public decimal EXBAMT { get; set; }
        /// <summary>
        /// 人民币帐号/银行卡号	C(32)
        /// </summary>
        public string CCYCRD { get; set; }
        /// <summary>
        /// 现汇金额  	F(15,2)
        /// </summary>
        public decimal CFCAMT { get; set; }
        /// <summary>
        /// 外汇帐号/银行卡号	C(32)
        /// </summary>
        public string FRGCRD { get; set; }
        /// <summary>
        /// 其它金额	M
        /// </summary>
        public decimal OTHAMT { get; set; }
        /// <summary>
        /// 其它帐号/银行卡号  	C(32)
        /// </summary>
        public string OTHCRD { get; set; }
        /// <summary>
        /// 结算方式	C(1)
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 付款人常驻国家/地区代码	C(3)
        /// </summary>
        public string CLTCNR { get; set; }
        /// <summary>
        /// 收款性质	C(1)
        /// </summary>
        public string RCVTYP { get; set; }
        /// <summary>
        /// 交易编码1	C(6)
        /// </summary>
        public string TRSCD1 { get; set; }
        /// <summary>
        /// 相应金额1	M
        /// </summary>
        public decimal TRSAM1 { get; set; }
        /// <summary>
        /// 交易附言1	Z(50)
        /// </summary>
        public string ORTIN1 { get; set; }
        /// <summary>
        /// 交易编码2	C(6)
        /// </summary>
        public string TRSCD2 { get; set; }
        /// <summary>
        /// 相应金额2	M
        /// </summary>
        public decimal TRSAM2 { get; set; }
        /// <summary>
        /// 交易附言2	Z(50)
        /// </summary>
        public string ORTIN2 { get; set; }
        /// <summary>
        /// 是否保税货物项下收汇	C(1)
        /// </summary>
        public string TAXFLG { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	Z(50)
        /// </summary>
        public string IMPNBR { get; set; }
        /// <summary>
        /// 收入类型	C(1)
        /// </summary>
        public string INCTYP { get; set; }
        /// <summary>
        /// 填报人	Z(20)
        /// </summary>
        public string FILNAM { get; set; }
        /// <summary>
        /// 填报人电话	Z(20)
        /// </summary>
        public string FILTEL { get; set; }
        /// <summary>
        /// 填报日期	D   在汇入汇款（母业务）入账后再申报，填写申报当天
        /// </summary>
        [XmlIgnore]
        public DateTime FILDAT { get; set; }
        /// <summary>
        /// 填报日期	D, 对应<see cref="FILDAT"/>
        /// </summary>
        [XmlElement("FILDAT")]
        public string FILDATStr
        {
            get
            {
                return this.FILDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.FILDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 原业务参考号	C(30)
        /// </summary>
        public string LSTREF { get; set; }
        /// <summary>
        /// 原交易唯一序号	C(22)
        /// </summary>
        public string LSTEVT { get; set; }
        /// <summary>
        /// 已报关收款金额	M
        /// </summary>
        public decimal? RCPCAM { get; set; }
        /// <summary>
        /// 预收款金额	M
        /// </summary>
        public decimal? RCPPAM { get; set; }
        /// <summary>
        /// 无货物报关的货物其他金额
        /// </summary>
        public decimal? RCPNAM { get; set; }
        /// <summary>
        /// 无货物离岸转手买卖金额	M
        /// </summary>
        public decimal? RCPOAM { get; set; }
        /// <summary>
        /// 无货物物流货物金额	M
        /// </summary>
        public decimal? RCPGAM { get; set; }
        /// <summary>
        /// 已备案收款金额	M
        /// </summary>
        public decimal? RCPRAM { get; set; }
        /// <summary>
        /// 货物贸易收款金额	M
        /// </summary>
        public decimal? RCPHAM { get; set; }
        /// <summary>
        /// 预付款比率	F(3,2)
        /// </summary>
        public decimal? RCPPSC { get; set; }
        /// <summary>
        /// 结账期	N(8)    单位是天
        /// </summary>
        public int? RCPAPE { get; set; }
        /// <summary>
        /// 报关经营单位机构代码	C(9)
        /// </summary>
        public string RCPCOD { get; set; }
        /// <summary>
        /// 报关单经营单位名称	Z(128)
        /// </summary>
        public string RCPCNM { get; set; }
        /// <summary>
        /// 贸易类型	C(1)	1一般贸易； 2进料加工； 3来料加工； 4其他贸易； 5边境贸易
        /// </summary>
        public string RCPTCL { get; set; }
        /// <summary>
        /// 进出口日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? RCPCDT { get; set; }
        /// <summary>
        /// 进出口日期	D, 对应<see cref="RCPCDT"/>
        /// </summary>
        [XmlElement("RCPCDT")]
        public string RCPCDTStr
        {
            get
            {
                return this.RCPCDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.RCPCDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCPCDT = tmp;
                }
            }
        }
        /// <summary>
        /// 对应货值金额	M
        /// </summary>
        public decimal? RCPBCA { get; set; }
        /// <summary>
        /// 报关收付类型	C(1)	1人民币报关 - 人民币结算； 3外币报关 - 人民币结算 
        /// </summary>
        public string RCPBTP { get; set; }
        /// <summary>
        /// RCPMIS服务贸易交易编码	C(6)    满足参数：FMRCPDCD（支出） FMRCPTRS（收入）
        /// </summary>
        public string RCPBCD { get; set; }
        /// <summary>
        /// 服务贸易金额	M
        /// </summary>
        public decimal? RCPSAM { get; set; }
        /// <summary>
        /// 交易合同号	Z(32)
        /// </summary>
        public string RCPCNB { get; set; }
        /// <summary>
        /// 补录编号	C(22)
        /// </summary>
        public string ADDNBR { get; set; }
        /// <summary>
        /// RCPMIS还原编号	C(22)
        /// </summary>
        public string RCPNBR { get; set; }
        /// <summary>
        /// 国际收支还原情况	C(1)
        /// </summary>
        public string RPTFLG { get; set; }
        /// <summary>
        /// RCPMIS 还原情况	C(1)
        /// </summary>
        public string RCPFLG { get; set; }
        /// <summary>
        /// 最后维护日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime MNTTIM { get; set; }
        /// <summary>
        /// 最后维护日期	D, 对应<see cref="MNTTIM"/>
        /// </summary>
        [XmlElement("MNTTIM")]
        public string MNTTIMStr
        {
            get
            {
                return this.MNTTIM.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.MNTTIM = tmp;
                }
            }
        }
        /// <summary>
        /// 版本号	C(2)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 错误码	C(7)
        /// </summary>
        public string MSGCOD { get; set; }
        /// <summary>
        /// 状态	C(1)    A：有效 E：自动补录异常 P: 已补录
        /// </summary>
        public string STSCOD { get; set; }
    }
}
