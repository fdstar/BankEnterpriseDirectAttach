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
    /// 10.17.查询协议信息响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS10_17 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// SDKNTCRSPSL
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "SDKNTCRSPSL";
        /// <summary>
        /// 10.17.查询协议信息响应集合
        /// </summary>
        [XmlElement("NTCRSPSLZ0")]
        public List<NTCRSPSLZ0> NTCRSPSLZ0List { get; set; }
        /// <summary>
        /// 10.17.查询协议信息响应集合
        /// </summary>
        [XmlElement("NTCRSPSLZ1")]
        public List<NTCRSPSLZ1> NTCRSPSLZ1List { get; set; }
    }
    /// <summary>
    /// 10.17.查询协议信息响应内容
    /// </summary>
    public class NTCRSPSLZ0
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
        /// 开户机构	C(6)	A.1 招行分行
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 货币	C(2)	A.3 货币代码表
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
        /// 冻结转账标志 	C(1)	A.22 冻结状态
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
        /// 任务实例号 	C(13)
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
        /// 协议状态	C(1)
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 冻结状态	C(1)	A.21 协议状态
        /// </summary>
        public string HLDSTS { get; set; }
        /// <summary>
        /// 协议执行状态	C(1)	A.23协议执行状态
        /// </summary>
        public string CRSSTS { get; set; }
        /// <summary>
        /// 额度发布标志	C(1)
        /// </summary>
        public string LMATAG { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 授信额度编号 	C(10)
        /// </summary>
        public string LONCRL { get; set; }
        /// <summary>
        /// 基准利率	I
        /// </summary>
        public decimal BASINR { get; set; }
        /// <summary>
        /// 回收时间 	T
        /// </summary>
        public string COLTIM { get; set; }
        /// <summary>
        /// 记录版本号	C(4)
        /// </summary>
        public string RCDVER { get; set; }
        /// <summary>
        /// 保留字段	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
    /// <summary>
    /// 10.17.查询协议信息响应内容
    /// </summary>
    public class NTCRSPSLZ1
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
        /// 系统标志	C(1)
        /// </summary>
        public string SYSTAG { get; set; }
        /// <summary>
        /// 维护机构	C(6)
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 开户机构	C(6)	A.1 招行分行
        /// </summary>
        public string EACBRN { get; set; }
        /// <summary>
        /// 户口号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 户口名称	Z(62)
        /// </summary>
        public string EACNAM { get; set; }
        /// <summary>
        /// 资金地区	C(3)
        /// </summary>
        public string ACTRGN { get; set; }
        /// <summary>
        /// 币种	C(2)	A.3 货币代码表
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 钞汇标志	C(1)
        /// </summary>
        public string CCYTYP { get; set; }
        /// <summary>
        /// 账户代码	C(5)
        /// </summary>
        public string ACTCOD { get; set; }
        /// <summary>
        /// 留底金额	M
        /// </summary>
        public decimal RSVAMT { get; set; }
        /// <summary>
        /// 透支额度	M
        /// </summary>
        public decimal LMTAMT { get; set; }
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
        /// 备注信息	Z(192)
        /// </summary>
        public string RMKTXT { get; set; }
        /// <summary>
        /// 事件实例号	C(11)
        /// </summary>
        public string EVTNBR { get; set; }
        /// <summary>
        /// 任务实例号 	C(13)
        /// </summary>
        public string TSKNBR { get; set; }
        /// <summary>
        /// 柜员	C(6)
        /// </summary>
        public string TLRNBR { get; set; }
        /// <summary>
        /// 协议状态   	C(1)	A.22 冻结状态
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 冻结状态	C(1)	A.21 协议状态
        /// </summary>
        public string HLDSTS { get; set; }
        /// <summary>
        /// 协议执行状态	C(1)	A.23协议执行状态
        /// </summary>
        public string CRSSTS { get; set; }
        /// <summary>
        /// 客户号	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 上存授信额度编号  	C(10)
        /// </summary>
        public string CRDCRL { get; set; }
        /// <summary>
        /// 上存贷款年限	N(4)
        /// </summary>
        public string CRDDUR { get; set; }
        /// <summary>
        /// 上存结息方式    	C(3)	A.33上存(下借)结息方式
        /// </summary>
        public string CRDINT { get; set; }
        /// <summary>
        /// 上存利率点差	I
        /// </summary>
        public decimal CRDINR { get; set; }
        /// <summary>
        /// 下借授信额度编号 	C(10)
        /// </summary>
        public string DBTCRL { get; set; }
        /// <summary>
        /// 下借贷款年限	N(4)
        /// </summary>
        public string DBTDUR { get; set; }
        /// <summary>
        /// 下借结息方式    	C(3)
        /// </summary>
        public string DBTINT { get; set; }
        /// <summary>
        /// 下借利率点差	I
        /// </summary>
        public decimal DBTINR { get; set; }
        /// <summary>
        /// 记录更新日期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime RCDDAT { get; set; }
        /// <summary>
        /// 记录更新日期     	D, 对应<see cref="RCDDAT"/>
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
        /// 保留字段     	C(100)
        /// </summary>
        public string SPL100 { get; set; }
    }
}
