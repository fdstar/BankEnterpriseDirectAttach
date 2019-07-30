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
    /// 电子合同确认查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLBCMQSH : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<ContractBillConfirmed> List { get; set; }
    }
    /// <summary>
    /// 电子合同确认信息
    /// </summary>
    public class ContractBillConfirmed
    {
        /// <summary>
        /// 批次号 varchar(8)
        /// </summary>
        [XmlElement("batNo")]
        public string BatNo { get; set; }
        /// <summary>
        /// 合同编号 char(32)
        /// </summary>
        [XmlElement("contractNo")]
        public string ContractNo { get; set; }
        /// <summary>
        /// 入账机构 varchar(80)
        /// </summary>
        [XmlElement("PUTORGZ")]
        public string PUTORGZ { get; set; }
        /// <summary>
        /// 结算账号  varchar(19)
        /// </summary>
        [XmlElement("ACCOUNTNO")]
        public string ACCOUNTNO { get; set; }
        /// <summary>
        /// 合同金额	decimal(15，2)
        /// </summary>
        [XmlElement("BUSSUM")]
        public decimal BUSSUM { get; set; }
        /// <summary>
        /// 合同状态 char(2) 00待确认 01 已确认 02已否决
        /// </summary>
        [XmlElement("CONTRST")]
        public string CONTRST { get; set; }
        /// <summary>
        /// 交易状态 0 成功 1 失败 2未知 3审核拒绝 4 用户撤销 char(1)
        /// </summary>
        [XmlElement("STT")]
        public int STT { get; set; }
        /// <summary>
        /// 操作类型 01确认 02退回 03否决 04撤销 char(2)
        /// </summary>
        [XmlElement("OPTTYPE")]
        public string OPTTYPE { get; set; }
        /// <summary>
        /// 备注 varchar(1000)
        /// </summary>
        [XmlElement("MEMO")]
        public string MEMO { get; set; }
    }
}