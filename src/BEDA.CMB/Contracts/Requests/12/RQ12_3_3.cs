﻿using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.3.3.支付机构上传汇款类业务项下收入明细数据请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_3_3 : CMBBase<RQINFO>, IRequest<RS12_3_3>
    {
        /// <summary>
        /// NTPAYRCV
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTPAYRCV";
        /// <summary>
        /// 12.3.3.支付机构上传汇款类业务项下收入明细数据请求内容
        /// </summary>
        public NTPAYLODX NTPAYLODX { get; set; }
        /// <summary>
        /// 12.3.3.支付机构上传汇款类业务项下收入明细数据请求集合
        /// </summary>
        [XmlElement("NTPAYRCVX")]
        public List<NTPAYRCVX> List { get; set; }
    }
    /// <summary>
    /// 12.3.3.支付机构上传汇款类业务项下收入明细数据请求内容
    /// </summary>
    public class NTPAYRCVX
    {
        /// <summary>
        /// 交易唯一序号	C(22)   用于标识支付机构交易数据的唯一键值，保证所提供的交易明细不重复
        /// </summary>
        public string EVTSEQ { get; set; }
        /// <summary>
        /// 收款人类型	C(1)	C－对公用户 D－对私中国居民 F－对私中国非居民	
        /// </summary>
        public string BNFTYP { get; set; }
        /// <summary>
        /// 个人身份证件号码	C(32)   CLTTYP不为C时必输，CLTTYP=D时长度必须为15或18位
        /// </summary>
        public string CIDCOD { get; set; }
        /// <summary>
        /// 组织机构代码	C(9)	A.9 组织机构代码  CLTTYP=C时必输，代码必须符合技监局的机构代码编制规则的校验
        /// </summary>
        public string ORGCOD { get; set; }
        /// <summary>
        /// 收款人名称	Z(128)
        /// </summary>
        public string BNFNAM { get; set; }
        /// <summary>
        /// 汇款人名称	Z(128)
        /// </summary>
        public string CLTNAM { get; set; }
        /// <summary>
        /// 收入款币种	C(3)
        /// </summary>
        public string TRSCCY { get; set; }
        /// <summary>
        /// 收入款金额	M
        /// </summary>
        public decimal TRSAMT { get; set; }
        /// <summary>
        /// 结汇汇率	F(13,8)
        /// </summary>
        public decimal? EXSINR { get; set; }
        /// <summary>
        /// 结汇金额	M
        /// </summary>
        public decimal? EXSAMT { get; set; }
        /// <summary>
        /// 人民币帐号/银行卡号	C(32)   结汇金额、结汇汇率、结汇帐号三个同时空或同时有值
        /// </summary>
        public string CCYCRD { get; set; }
        /// <summary>
        /// 现汇金额	M
        /// </summary>
        public decimal? CFCAMT { get; set; }
        /// <summary>
        /// 外汇帐号/银行卡号	C(32)   现汇金额、外汇帐号/银行卡号同时为空，或同时有值
        /// </summary>
        public string FRGCRD { get; set; }
        /// <summary>
        /// 其它金额	M   不能小于0。 结汇金额, 现汇金额, 其它金额至少输入一项。 结汇金额、现汇金额、其它金额之和应等于收入款金额
        /// </summary>
        public decimal? OTHAMT { get; set; }
        /// <summary>
        /// 其它帐号/银行卡号	C(32)   其它金额、其它帐号同时为空，或同时有值
        /// </summary>
        public string OTHCRD { get; set; }
        /// <summary>
        /// 结算方式	C(1)	L－信用证 G－保函 C－托收 T－电汇 D－票汇 M－信汇 O－其他
        /// </summary>
        public string TRSTYP { get; set; }
        /// <summary>
        /// 付款人常驻国家/地区代码	C(3)	A.8 国家和地区代码表
        /// </summary>
        public string CLTCNR { get; set; }
        /// <summary>
        /// 收款性质	C(1)	A－预收货款 R－退款 O-其它
        /// </summary>
        public string RCVTYP { get; set; }
        /// <summary>
        /// 交易编码1	C(6)	跨境人民币：A.10 人民币跨境国际收支交易编码（支出∕收入） 境外：A.11国际收支交易编码（支出∕收入） 境内：A.12涉外收支交易代码（境内）
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
        /// 交易编码2	C(6)	跨境人民币：A.10 人民币跨境国际收支交易编码（支出∕收入） 境外：A.11国际收支交易编码（支出∕收入） 境内：A.12涉外收支交易代码（境内）
        /// </summary>
        public string TRSCD2 { get; set; }
        /// <summary>
        /// 相应金额2	M   	两个交易编码对应的金额之和必须等于汇款金额
        /// </summary>
        public decimal? TRSAM2 { get; set; }
        /// <summary>
        /// 交易附言2	Z(50)
        /// </summary>
        public string ORTIN2 { get; set; }
        /// <summary>
        /// 是否保税货物项下付款	C(1)	Y－是 N－否
        /// </summary>
        public string TAXFLG { get; set; }
        /// <summary>
        /// 外汇局批件号/备案表号/业务编号	Z(20)
        /// 当交易编码1或2为资本项目项下编码时 “外汇局批件号/备案表号/业务编号”为必输项。 对于资本项目项下交易，如果确实没有对应的“外汇局批件号/备案表号/业务编号”，应填写“N/A”（大写英文字符）
        /// </summary>
        public string IMPNBR { get; set; }
        /// <summary>
        /// 收入类型	C(1)	F-福费廷 T-出口保理 N-出口押汇 D-出口贴现 O-其它
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
        /// 已报关收款金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填
        /// </summary>
        public decimal? RCPCAM { get; set; }
        /// <summary>
        /// 预收款金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填
        /// </summary>
        public decimal? RCPPAM { get; set; }
        /// <summary>
        /// 无货物报关的货物其他金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填
        /// </summary>
        public decimal? RCPNAM { get; set; }
        /// <summary>
        /// 无货物离岸转手买卖金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，一般暂默认为0
        /// </summary>
        public decimal? RCPOAM { get; set; }
        /// <summary>
        /// 无货物物流货物金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，一般默认为0
        /// </summary>
        public decimal? RCPGAM { get; set; }
        /// <summary>
        /// 已备案收款金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，一般默认为0
        /// </summary>
        public decimal? RCPRAM { get; set; }
        /// <summary>
        /// 货物贸易收款金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，为字段 已报关收款金额+预收款金额+ 无货物报关的货物其他金额+ 无货物离岸转手买卖金额之和，应等于字段TRSCD1或TRSCD2为1开头的货物贸易对应的TRSAM1或TRSAM2或此两个字段金额之和
        /// </summary>
        public decimal? RCPHAM { get; set; }
        /// <summary>
        /// 预付款比率	F(3,2)  字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，字段”预付款金额”不为0时必填，应为0.01-1之间
        /// </summary>
        public decimal? RCPPSC { get; set; }
        /// <summary>
        /// 结账期	N(8)    字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易时必填，字段”预付款金额”不为0时必填；单位是天
        /// </summary>
        public int? RCPAPE { get; set; }
        /// <summary>
        /// 报关经营单位机构代码	C(9)    字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易，且CLTTYP=C时必填，实际报关公司的组织机构代码
        /// </summary>
        public string RCPCOD { get; set; }
        /// <summary>
        /// 报关单经营单位名称	Z(128)  字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易，且CLTTYP=C时必填，实际报关公司的单位中文全称
        /// </summary>
        public string RCPCNM { get; set; }
        /// <summary>
        /// 贸易类型	C(1)	1一般贸易； 2进料加工； 3来料加工； 4其他贸易； 5边境贸易  
        /// 字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易，且CLTTYP=C时必填
        /// </summary>
        public string RCPTCL { get; set; }
        /// <summary>
        /// 进出口日期	D   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易，且CLTTYP=C时可填
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
        /// 对应货值金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为1开头的货物贸易，且CLTTYP=C时必填，实际报关的金额，应与字段“已报关收款金额”相同
        /// </summary>
        public decimal? RCPBCA { get; set; }
        /// <summary>
        /// 报关收付类型	C(1)	1人民币报关 - 人民币结算； 3外币报关 - 人民币结算 
        /// </summary>
        public string RCPBTP { get; set; }
        /// <summary>
        /// RCPMIS服务贸易交易编码	C(6)    字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为2开头的服务贸易时必填 满足参数：FMRCPDCD（支出） FMRCPTRS（收入）
        /// </summary>
        public string RCPBCD { get; set; }
        /// <summary>
        /// 服务贸易金额	M   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为2开头的服务贸易时必填，应等于字段TRSCD1或TRSCD2为2开头的服务贸易对应的TRSAM1或TRSAM2或此两个字段金额之和
        /// </summary>
        public decimal? RCPSAM { get; set; }
        /// <summary>
        /// 交易合同号	Z(32)   字段TRSCCY:汇款币种为CNY时，且交易编码TRSCD1和TRSCD2任一或都为2开头的服务贸易时必填
        /// </summary>
        public string RCPCNB { get; set; }
    }
}
