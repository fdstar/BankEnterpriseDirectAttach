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
    /// 10.7.查询指定母公司和子公司协议产品信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_7 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCRSPSR
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCRSPSR";
        /// <summary>
        /// 10.7.查询指定母公司和子公司协议产品信息响应集合 基本信息
        /// </summary>
        [XmlElement("NTCRSPSRZ0")]
        public List<NTCRSPSRZ0> NTCRSPSRZ0List { get; set; }
        /// <summary>
        /// 10.7.查询指定母公司和子公司协议产品信息响应集合 详细信息
        /// </summary>
        [XmlElement("NTCRSPSRZ1")]
        public List<NTCRSPSRZ1> NTCRSPSRZ1List { get; set; }
    }
    /// <summary>
    /// 10.7.查询指定母公司和子公司协议产品信息响应内容  基本信息
    /// </summary>
    public class NTCRSPSRZ0
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 产品编码	C(8)
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 产品号	C(10)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 货币	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 资金地区	C(3)
        /// </summary>
        public string ACTRGN { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5)
        /// </summary>
        public string ACTCOD { get; set; }
        /// <summary>
        /// 维护机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 冻结转账标志	C(1)
        /// </summary>
        public string HLDTAG { get; set; }
        /// <summary>
        /// 系统标志	C(1)
        /// </summary>
        public string SYSTAG { get; set; }
        /// <summary>
        /// 建立日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime CRTDAT { get; set; }
        /// <summary>
        /// 建立日期	D, 对应<see cref="CRTDAT"/>
        /// </summary>
        [XmlElement("CRTDAT")]
        public string CRTDATStr
        {
            get
            {
                return this.CRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 事件实例号	C(11)
        /// </summary>
        public string EVTNBR { get; set; }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 备注信息	Z(192)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 协议状态	C(1)	A.21 协议状态
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 冻结状态	C(1)	A.22 冻结状态
        /// </summary>
        public string HLDSTS { get; set; }
        /// <summary>
        /// 协议执行状态	C(1)	A.23 协议执行状态
        /// </summary>
        public string CRSSTS { get; set; }
        /// <summary>
        /// 记录版本号	N(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 	100位预留	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 10.7.查询指定母公司和子公司协议产品信息响应内容  详细信息
    /// </summary>
    public class NTCRSPSRZ1
    {
        /// <summary>
        /// 协议编号	C(10)
        /// </summary>
        public string CRSCOD { get; set; }
        /// <summary>
        /// 子公司协议序号	N(5)
        /// </summary>
        public string CRPSEQ { get; set; }
        /// <summary>
        /// 子公司展示序号	C(5) 
        /// </summary>
        public string DSPSEQ { get; set; }
        /// <summary>
        /// 产品编码	C(8) 
        /// </summary>
        public string PRDCOD { get; set; }
        /// <summary>
        /// 产品号	C(10)
        /// </summary>
        public string PRDNBR { get; set; }
        /// <summary>
        /// 支付户口开户行	C(6)   取前两位作为分行号
        /// </summary>
        public string DBTBRN { get; set; }
        /// <summary>
        /// 支付户口号	C(35)
        /// </summary>
        public string DBTEAC { get; set; }
        /// <summary>
        /// 子公司户口名称	Z(62)
        /// </summary>
        public string DBTNAM { get; set; }
        /// <summary>
        /// 子公司客户号	C(10)
        /// </summary>
        public string DBTCLT { get; set; }
        /// <summary>
        /// 支付户口币种	C(2) 	A.3 货币代码表
        /// </summary>
        public string DBTCCY { get; set; }
        /// <summary>
        /// 支付户口资金地区	C(3)  
        /// </summary>
        public string DBTRGN { get; set; }
        /// <summary>
        /// 支付户口钞汇标志	C(1)  
        /// </summary>
        public string DBTTYP { get; set; }
        /// <summary>
        /// 支付户口账户代码	C(5)  
        /// </summary>
        public string DBTACT { get; set; }
        /// <summary>
        /// 支付管理类型	C(1)  	A.24 支付管理类型
        /// </summary>
        public string DBTMOD { get; set; }
        /// <summary>
        /// 支付额度使用类型	C(1)  	A.25 支付额度使用类型
        /// </summary>
        public string DBTLTY { get; set; }
        /// <summary>
        /// 单笔额度	M
        /// </summary>
        public decimal SLMAMT { get; set; }
        /// <summary>
        /// 支付转帐间隔	C(1)  
        /// </summary>
        public string DBTDUR { get; set; }
        /// <summary>
        /// 支付转帐时点	C(30) 
        /// </summary>
        public string DBTDAY { get; set; }
        /// <summary>
        /// 支付转帐时间	T
        /// </summary>
        public string DBTTIM { get; set; }
        /// <summary>
        /// 支付户口对账单周期	C(1)  
        /// </summary>
        public string DBTSTC { get; set; }
        /// <summary>
        /// 支付户口对账单日期	C(2)
        /// </summary>
        public string DBTSTD { get; set; }
        /// <summary>
        /// 支付户口对账单类型	C(1)
        /// </summary>
        public string DBTSTT { get; set; }
        /// <summary>
        /// 支付户口转账协议号	C(10)
        /// </summary>
        public string DBTCRS { get; set; }
        /// <summary>
        /// 收入户口开户行	C(6)    取前两位作为分行号
        /// </summary>
        public string CRDBRN { get; set; }
        /// <summary>
        /// 收入户口号	C(35)
        /// </summary>
        public string CRDEAC { get; set; }
        /// <summary>
        /// 子公司户口名称	O(62)	
        /// </summary>
        public string CRDNAM { get; set; }
        /// <summary>
        /// 子公司客户号	C(10)
        /// </summary>
        public string CRDCLT { get; set; }
        /// <summary>
        /// 收入户口币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CRDCCY { get; set; }
        /// <summary>
        /// 收入户口资金地区	C(3)
        /// </summary>
        public string CRDRGN { get; set; }
        /// <summary>
        /// 收入户口钞汇标志	C(1)
        /// </summary>
        public string CRDTYP { get; set; }
        /// <summary>
        /// 收入户口账户代码	C(5)  
        /// </summary>
        public string CRDACT { get; set; }
        /// <summary>
        /// 现金回流方式	C(1)  	A．27现金回流方式
        /// </summary>
        public string CRDMOD { get; set; }
        /// <summary>
        /// 留底金额	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 收入转帐间隔	C(1)  	A.26 收入转账间隔
        /// </summary>
        public string CRDDUR { get; set; }
        /// <summary>
        /// 收入转帐时点	C(30) 
        /// </summary>
        public string CRDDAY { get; set; }
        /// <summary>
        /// 收入转帐时间	T
        /// </summary>
        public string CRDTIM { get; set; }
        /// <summary>
        /// 收入户口对账单周期	C(1)  
        /// </summary>
        public string CRDSTC { get; set; }
        /// <summary>
        /// 收入户口对账单日期	C(2)  
        /// </summary>
        public string CRDSTD { get; set; }
        /// <summary>
        /// 收入户口对账单类型	C(1)  
        /// </summary>
        public string CRDSTT { get; set; }
        /// <summary>
        /// 收入户口转账协议号	C(10) 
        /// </summary>
        public string CRDCRS { get; set; }
        /// <summary>
        /// 日额度类型	C(1)
        /// </summary>
        public string DLMTYP { get; set; }
        /// <summary>
        /// 日额度	M
        /// </summary>
        public decimal DLMAMT { get; set; }
        /// <summary>
        /// 周额度类型	C(1)
        /// </summary>
        public string WLMTYP { get; set; }
        /// <summary>
        /// 周额度	M
        /// </summary>
        public decimal WLMAMT { get; set; }
        /// <summary>
        /// 月额度类型	C(1)
        /// </summary>
        public string MLMTYP { get; set; }
        /// <summary>
        /// 月额度	M
        /// </summary>
        public decimal MLMAMT { get; set; }
        /// <summary>
        /// 建立日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime CRTDAT { get; set; }
        /// <summary>
        /// 建立日期	D, 对应<see cref="CRTDAT"/>
        /// </summary>
        [XmlElement("CRTDAT")]
        public string CRTDATStr
        {
            get
            {
                return this.CRTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CRTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 生效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期	D, 对应<see cref="EFTDAT"/>
        /// </summary>
        [XmlElement("EFTDAT")]
        public string EFTDATStr
        {
            get
            {
                return this.EFTDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EFTDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 失效日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期	D, 对应<see cref="EXPDAT"/>
        /// </summary>
        [XmlElement("EXPDAT")]
        public string EXPDATStr
        {
            get
            {
                return this.EXPDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.EXPDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 终止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 终止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 事件实例号	C(11)
        /// </summary>
        public string EVTNBR { get; set; }
        /// <summary>
        /// 任务实例号	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 协议状态	C(1)	A.21 协议状态
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 冻结状态	C(1)	A.22 冻结状态
        /// </summary>
        public string HLDSTS { get; set; }
        /// <summary>
        /// 备注信息	Z(192)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 协议执行状态	C(1)	A.23 协议执行状态
        /// </summary>
        public string CRSSTS { get; set; }
        /// <summary>
        /// 记录更新日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime RCDDAT { get; set; }
        /// <summary>
        /// 记录更新日期	D, 对应<see cref="RCDDAT"/>
        /// </summary>
        [XmlElement("RCDDAT")]
        public string RCDDATStr
        {
            get
            {
                return this.RCDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.RCDDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 记录版本号	N(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 交易查询限制	C(1)	Y:只能查询外部交易 N:可以查询全部交易   用于客户端网银
        /// </summary>
        public string QRYLMT { get; set; }
        /// <summary>
        /// 余额查询限制	C(1)	Y:不显示联机余额 N:可显示联机余额 用于客户端网银
        /// </summary>
        public string BALLMT { get; set; }
        /// <summary>
        /// 保留字段	C(98)
        /// </summary>
        public string SPLC98 { get; set; }
    }
}
