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
    /// 26.6.支票管理查询响应主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RS26_6 : CMBBase<RSINFO>, IResponse
    {
        /// <summary>
        /// NTECKLST
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTECKLST";
        /// <summary>
        /// 26.6.支票管理查询响应集合
        /// </summary>
        [XmlElement("NTECKLSTZ")]
        public List<NTECKLSTZ> List { get; set; }
    }
    /// <summary>
    /// 26.6.支票管理查询响应内容
    /// </summary>
    public class NTECKLSTZ
    {
        /// <summary>
        /// 账号 	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 支票编号     	C(10)
        /// </summary>
        public string ECKNBR { get; set; }
        /// <summary>
        /// 金额上限     	M
        /// </summary>
        public decimal MAXAMT { get; set; }
        /// <summary>
        /// 币种 	C(2) 
        /// </summary>
        public string CCYNBR { get; set; }
        /// <summary>
        /// 生效日期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime EFTDAT { get; set; }
        /// <summary>
        /// 生效日期     	D, 对应<see cref="EFTDAT"/>
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
        /// 失效日期     	D
        /// </summary>
        [XmlIgnore]
        public DateTime EXPDAT { get; set; }
        /// <summary>
        /// 失效日期     	D, 对应<see cref="EXPDAT"/>
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
        /// 授权使用人   	Z(30)
        /// </summary>
        public string AUTNAM { get; set; }
        /// <summary>
        /// 支票状态     	C(1) 
        /// </summary>
        public string STSCOD { get; set; }
        /// <summary>
        /// 支票权限     	C(1) 
        /// </summary>
        public string ECKAUT { get; set; }
        /// <summary>
        /// 是否已转让    	C(1)    Y-已转让 其他值为空
        /// </summary>
        public string CHGFLG { get; set; }
        /// <summary>
        /// 转让对象中文  	Z(100)
        /// </summary>
        public string CHGOBJ { get; set; }
        /// <summary>
        /// 转让日期      	D
        /// </summary>
        [XmlIgnore]
        public DateTime CHGDAT { get; set; }
        /// <summary>
        /// 转让日期      	D, 对应<see cref="CHGDAT"/>
        /// </summary>
        [XmlElement("CHGDAT")]
        public string CHGDATStr
        {
            get
            {
                return this.CHGDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.CHGDAT = tmp;
                }
            }
        }
        /// <summary>
        /// 维护日期      	D
        /// </summary>
        public string MNTDAT { get; set; }
        /// <summary>
        /// 维护时间      	T
        /// </summary>
        public string MNTTIM { get; set; }
        /// <summary>
        /// 维护时间 由<see cref="MNTDAT"/>和<see cref="MNTTIM"/>组成
        /// </summary>
        [XmlIgnore]
        public DateTime MaintenanceTime
        {
            get
            {
                if (DateTime.TryParseExact(string.Format("{0}{1}", this.MNTDAT, this.MNTTIM),
                   new string[] { "yyyyMMdd", "yyyyMMddHHmmss" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    return tmp;
                }
                return DateTime.MinValue;
            }
        }
        /// <summary>
        /// 是否退票      	C(1)	Y-是 其他值为否
        /// </summary>
        public string BCKFLG { get; set; }
        /// <summary>
        /// 延期托收日期  	D
        /// </summary>
        [XmlIgnore]
        public DateTime ADDDAT { get; set; }
        /// <summary>
        /// 延期托收日期  	D, 对应<see cref="ADDDAT"/>
        /// </summary>
        [XmlElement("ADDDAT")]
        public string ADDDATStr
        {
            get
            {
                return this.ADDDAT.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.ADDDAT = tmp;
                }
            }
        }
    }
}
