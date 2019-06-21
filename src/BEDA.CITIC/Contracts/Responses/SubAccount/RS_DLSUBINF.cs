using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Responses
{
    /// <summary>
    /// 附属账户信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLSUBINF : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<SubAccountInfo> List { get; set; }
    }
    /// <summary>
    /// 附属账户信息
    /// </summary>
    public class SubAccountInfo
    {
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 主体客户类型 0：不计息；1：不分段计息；2：分段计息 char(1)
        /// </summary>
        public int MAINCSTTYP { get; set; }
        /// <summary>
        /// 主体账号 char(19)
        /// </summary>
        public string MAINACCNO { get; set; }
        /// <summary>
        /// 附属账号类型 00：公共计息收费附属账户；01：本附属账户；02：其他实体账户 char(2)
        /// </summary>
        public string SUBACCTYP { get; set; }
        /// <summary>
        /// 附属账户名称 varchar(122)
        /// </summary>
        public string SUBACCNM { get; set; }
        /// <summary>
        /// 附属账户余额 decimal(15,2)
        /// </summary>
        public decimal ACCBAL { get; set; }
        /// <summary>
        /// 正常利率 decimal(9,7)
        /// </summary>
        public decimal RATE { get; set; }
        /// <summary>
        /// 透支利率 decimal(9,7)
        /// </summary>
        public decimal OVERRATE { get; set; }
        /// <summary>
        /// 是否计算利息 0：不计息；1：不分段计息；2：分段计息 char(1)
        /// </summary>
        public int CNTRATETYP { get; set; }
        /// <summary>
        /// 自动分配利息 0：否；1：是 char(1)
        /// </summary>
        public int RATEASSIGNTYPE { get; set; }
        /// <summary>
        /// 是否允许透支 0：不允许；1: 限额透支，2：全额透支 char(1)
        /// </summary>
        public int OVERFLAG { get; set; }
        /// <summary>
        /// 透支限额 decimal(15,2)
        /// </summary>
        public decimal OVERAMT { get; set; }
        /// <summary>
        /// 自动分配转账手续费标示 0：否；1：是 char(1)
        /// </summary>
        public int FEETYPE { get; set; }
        /// <summary>
        /// 手续费收取方式 0：不收取；1：实时收取；2：月末累计 char(1)
        /// </summary>
        public int TRANFEEFTYPE { get; set; }
        /// <summary>
        /// 附属账户上日余额 decimal(15，2)
        /// </summary>
        public decimal YESTERDAYBAL { get; set; }
    }
}
