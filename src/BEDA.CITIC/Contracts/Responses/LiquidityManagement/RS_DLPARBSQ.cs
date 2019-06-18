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
    /// 现金池自动规则响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLPARBSQ : RsBase
    {
        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<CashPoolAutoRule> List { get; set; }
    }
    /// <summary>
    /// 现金池自动规则
    /// </summary>
    public class CashPoolAutoRule
    {
        /// <summary>
        /// 现金池ID char(8)
        /// </summary>
        [XmlElement("poolID")]
        public string PoolID { get; set; }
        /// <summary>
        /// 成员单位账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 自动归集标志 char(1) 0：不自动；1：自动
        /// </summary>
        [XmlElement("autoCollFlag")]
        public int AutoCollFlag { get; set; }
        /// <summary>
        /// 自动归集方式char(1) 1：定余额归集；2：定额归集；3：定比例归集；4：每笔归集
        /// </summary>
        [XmlElement("autoCollType")]
        public int AutoCollType { get; set; }
        /// <summary>
        /// 归集频率类型 char(1) 1：每月；2：每周；3：每日；4：定时间间隔；5：月末
        /// </summary>
        [XmlElement("collFreqType")]
        public int CollFreqType { get; set; }
        /// <summary>
        /// 归集基准时间 char(6) 格式hhmmss
        /// </summary>
        [XmlElement("collStdTime")]
        public string CollStdTime { get; set; }
        /// <summary>
        /// 归集频率值 varchar(2) 当频率类型为1(每月)时，频率值为日期；当频率类型为2(每周)时，频率值为周几；当频率类型为4(定时间间隔)时，频率值为间隔数(单位为两个小时)
        /// </summary>
        [XmlElement("collFreq")]
        public string CollFreq { get; set; }
        /// <summary>
        /// 自动下拨标志 char(1) 0：不自动；1自动
        /// </summary>
        [XmlElement("autoPayFlag")]
        public int AutoPayFlag { get; set; }
        /// <summary>
        /// 自动下拨方式 char(1) 1：定余额下拨；2：定额下拨；3：自动回拨
        /// </summary>
        [XmlElement("autoPayType")]
        public int AutoPayType { get; set; }
        /// <summary>
        /// 下拨频率类型 char(1) 1：每月；2：每周；3：每日；4：定时间间隔；5：月末
        /// </summary>
        [XmlElement("payFreqType")]
        public int PayFreqType { get; set; }
        /// <summary>
        /// 下拨频率值 varchar(2) 当频率类型为1(每月)时，频率值为日期；当频率类型为2(每周)时，频率值为周几；当频率类型为4(定时间间隔)时，频率值为间隔数(单位为两个小时)
        /// </summary>
        [XmlElement("payFreq")]
        public string PayFreq { get; set; }
        /// <summary>
        /// 下拨基准时间 char(6)格式hhmmss
        /// </summary>
        [XmlElement("payStdTime")]
        public string PayStdTime { get; set; }
        /// <summary>
        /// 余额不足联动自动拨款标志 char(1) 0：暂停；1：启用
        /// </summary>
        [XmlElement("relatePayFlag")]
        public int RelatePayFlag { get; set; }
        /// <summary>
        /// 联动自动拨款启用标志char(1) 0：不可设置联动下拨；1：可设置差额联动下拨；2：可设置全额联动下拨
        /// </summary>
        [XmlElement("relatePayFlagInner")]
        public int RelatePayFlagInner { get; set; }
        /// <summary>
        /// 资金管理标志 char(1) 0：自身平衡；1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        [XmlElement("fundMgrFlg")]
        public int FundMgrFlg { get; set; }
    }
}
