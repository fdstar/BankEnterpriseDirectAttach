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
    /// 8.3.3.理财产品详细信息查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS8_3_3 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTQDIDEF
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTQDIDEF";
        /// <summary>
        /// 8.3.3.理财产品详细信息查询响应内容
        /// </summary>
        public NTQDIDEFZ NTQDIDEFZ { get; set; }
    }
    /// <summary>
    /// 8.3.3.理财产品详细信息查询响应内容
    /// </summary>
    public class NTQDIDEFZ
    {
        /// <summary>
        /// 产品代码	C(8)
        /// </summary>
        public string RIPCOD { get; set; }
        /// <summary>
        /// 产品简称	Z(22)
        /// </summary>
        public string NAMSNM { get; set; }
        /// <summary>
        /// 币种	C(2)
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 代理机构	C(3)
        /// </summary>
        public string MAACOD { get; set; }
        /// <summary>
        /// 挂牌日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime BEGDAT { get; set; }
        /// <summary>
        /// 挂牌日期	D, 对应<see cref="BEGDAT"/>
        /// </summary>
        [XmlElement("BEGDAT")]
        public string BEGDATStr
        {
            get
            {
                return this.BEGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.BEGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 截止日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime ENDDAT { get; set; }
        /// <summary>
        /// 截止日期	D, 对应<see cref="ENDDAT"/>
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
        /// 赎回控制	C(1)	Y=可以 N=不可以
        /// </summary>
        public string REDCTL { get; set; }
        /// <summary>
        /// 申购控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string PURCTL { get; set; }
        /// <summary>
        /// 认购控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string SBSCTL { get; set; }
        /// <summary>
        /// 分红控制	C(1)	Y=允许 N=不允许
        /// </summary>
        public string BNSCTL { get; set; }
        /// <summary>
        /// 申购金额上限	N(13)
        /// </summary>
        public long QTYHIG { get; set; }
        /// <summary>
        /// 申购金额下限	N(13)
        /// </summary>
        public long QTYLOW { get; set; }
        /// <summary>
        /// 认购开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SBSBDT { get; set; }
        /// <summary>
        /// 认购开始日期	D, 对应<see cref="SBSBDT"/>
        /// </summary>
        [XmlElement("SBSBDT")]
        public string SBSBDTStr
        {
            get
            {
                return this.SBSBDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SBSBDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SBSBDT = tmp;
                }
            }
        }
        /// <summary>
        /// 认购结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? SBSEDT { get; set; }
        /// <summary>
        /// 认购结束日期	D, 对应<see cref="SBSEDT"/>
        /// </summary>
        [XmlElement("SBSEDT")]
        public string SBSEDTStr
        {
            get
            {
                return this.SBSEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.SBSEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.SBSEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 认购费用比例	F(11,7)
        /// </summary>
        public decimal? SBSFEE { get; set; }
        /// <summary>
        /// 认购价格	F(11,7)
        /// </summary>
        public decimal? SBSPRC { get; set; }
        /// <summary>
        /// 价格	F(11,7)
        /// </summary>
        public decimal NAVNTV { get; set; }
        /// <summary>
        /// 价格日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime NAVDAT { get; set; }
        /// <summary>
        /// 价格日期	D, 对应<see cref="NAVDAT"/>
        /// </summary>
        [XmlElement("NAVDAT")]
        public string NAVDATStr
        {
            get
            {
                return this.NAVDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.NAVDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 申购开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PURBDT { get; set; }
        /// <summary>
        /// 申购开始日期	D, 对应<see cref="PURBDT"/>
        /// </summary>
        [XmlElement("PURBDT")]
        public string PURBDTStr
        {
            get
            {
                return this.PURBDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PURBDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PURBDT = tmp;
                }
            }
        }
        /// <summary>
        /// 申购结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? PUREDT { get; set; }
        /// <summary>
        /// 申购结束日期	D, 对应<see cref="PUREDT"/>
        /// </summary>
        [XmlElement("PUREDT")]
        public string PUREDTStr
        {
            get
            {
                return this.PUREDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.PUREDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.PUREDT = tmp;
                }
            }
        }
        /// <summary>
        /// 申购费用比例	F(11,7)
        /// </summary>
        public decimal? PURFEE { get; set; }
        /// <summary>
        /// 申购接受周期	C(4)
        /// </summary>
        public string PURCYL { get; set; }
        /// <summary>
        /// 申购到帐速度	C(4)
        /// </summary>
        public string PURRDT { get; set; }
        /// <summary>
        /// 赎回开始日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? REDBDT { get; set; }
        /// <summary>
        /// 赎回开始日期	D, 对应<see cref="REDBDT"/>
        /// </summary>
        [XmlElement("REDBDT")]
        public string REDBDTStr
        {
            get
            {
                return this.REDBDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.REDBDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REDBDT = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回结束日期	D
        /// </summary>
        [XmlIgnore]
        public DateTime? REDEDT { get; set; }
        /// <summary>
        /// 赎回结束日期	D, 对应<see cref="REDEDT"/>
        /// </summary>
        [XmlElement("REDEDT")]
        public string REDEDTStr
        {
            get
            {
                return this.REDEDT?.ToString("yyyyMMdd");
            }
            set
            {
                this.REDEDT = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.REDEDT = tmp;
                }
            }
        }
        /// <summary>
        /// 赎回费用比例	F(11,7)
        /// </summary>
        public decimal? REDFEE { get; set; }
        /// <summary>
        /// 赎回接受周期	C(4)
        /// </summary>
        public string REDCYL { get; set; }
        /// <summary>
        /// 赎回到帐速度	C(4)
        /// </summary>
        public string REDRDT { get; set; }
        /// <summary>
        /// 累计分红次数	C(3)
        /// </summary>
        public string BNSCNT { get; set; }
        /// <summary>
        /// 累计分红金额	M
        /// </summary>
        public decimal BNSAMT { get; set; }
        /// <summary>
        /// 累计分红份额	M
        /// </summary>
        public decimal BNSQTY { get; set; }
        /// <summary>
        /// 代理机构名称	C(30)
        /// </summary>
        public string MAANAM { get; set; }
        /// <summary>
        /// 赎回上限	N(13)
        /// </summary>
        public long REDHIG { get; set; }
        /// <summary>
        /// 赎回下限	N(13)
        /// </summary>
        public long REDLOW { get; set; }
    }
}
