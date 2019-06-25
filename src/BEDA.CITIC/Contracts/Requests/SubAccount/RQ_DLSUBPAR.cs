using BEDA.CITIC.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CITIC.Contracts.Requests
{
    /// <summary>
    /// 附属账户参数设置经办请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLSUBPAR : RqBase<RS_DLSUBPAR>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLSUBPAR"; set { } }
        /// <summary>
        /// 客户流水号 varchar(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 附属账号 char(19)
        /// </summary>
        [XmlElement("subAccNo")]
        public string SubAccNo { get; set; }
        /// <summary>
        /// 附属账户名称 varchar(122)
        /// </summary>
        [XmlElement("subAccNm")]
        public string SubAccNm { get; set; }
        /// <summary>
        /// 利率 decimal(9,7)
        /// </summary>
        [XmlElement("rate")]
        public decimal Rate { get; set; }
        /// <summary>
        /// 透支类型 char(1) 0：不允许透支；1：限额透支；2：全额透支
        /// </summary>
        [XmlElement("overType")]
        public int OverType { get; set; }
        /// <summary>
        /// 透支利率 decimal(9,7) 透支类型为1（限额透支）或2(全额透支)时，透支利率非空；透支类型为0(不允许透支)时默认为0.0000000
        /// </summary>
        [XmlElement("overRate")]
        public decimal OverRate { get; set; }
        /// <summary>
        /// 透支金额 decimal(15,2) 透支类型为1（限额透支）时，透支利率非空；透支类型为其他时默认为0.00
        /// </summary>
        [XmlElement("overAmt")]
        public decimal OverAmt { get; set; }
        /// <summary>
        /// 计息方式 char(1) 0：不计息；1：不分段计息；2：分段计息
        /// </summary>
        [XmlElement("rateCalType")]
        public int RateCalType { get; set; }
        /// <summary>
        /// 利息分配方式 char(1) 0：不自动分配；1：自动分配
        /// </summary>
        [XmlElement("rateAsnType")]
        public int RateAsnType { get; set; }
        /// <summary>
        /// 手续费率分配方式 char(1) 0：不自动分配；1：自动分配
        /// </summary>
        [XmlElement("feeAsnType")]
        public int FeeAsnType { get; set; }
    }
}
