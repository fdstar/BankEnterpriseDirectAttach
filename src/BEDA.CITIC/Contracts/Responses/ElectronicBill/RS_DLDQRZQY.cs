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
    /// 票据记账信息查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_DLDQRZQY : RsBase
    {
        /// <summary>
        /// 总记录条数 int(3)
        /// </summary>
        [XmlElement("totalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("row")]
        public List<BillBookkeeping> List { get; set; }
    }
    /// <summary>
    /// 票据记账信息
    /// </summary>
    public class BillBookkeeping
    {
        /// <summary>
        /// 记账账号 char(19)
        /// </summary>
        [XmlElement("accNo")]
        public string AccNo { get; set; }
        /// <summary>
        /// 业务类别 char(2)，值域参见附录4.1.13 
        /// </summary>
        [XmlElement("bizType")]
        public string BizType { get; set; }
        /// <summary>
        /// 交易金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 票据类型 char(4) ，AC01：纸票； AC02 电票
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 对方开户行行号 varchar(20)
        /// </summary>
        [XmlElement("counterBnkNo")]
        public string CounterBnkNo { get; set; }
        /// <summary>
        /// 对方开户行名称 varchar(122)
        /// </summary>
        [XmlElement("counterBnkName")]
        public string CounterBnkName { get; set; }
        /// <summary>
        /// 对方账号 varchar(32)
        /// </summary>
        [XmlElement("counterAccNo")]
        public string CounterAccNo { get; set; }
        /// <summary>
        /// 对方账户名称 varchar(122)
        /// </summary>
        [XmlElement("counterAccName")]
        public string CounterAccName { get; set; }
        /// <summary>
        /// 交易请求日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime TranReqDate { get; set; }
        /// <summary>
        /// 交易请求日期 char(8)，格式YYYYMMDD, 对应<see cref="TranReqDate"/>
        /// </summary>
        [XmlElement("tranReqDate")]
        public string TranReqDateStr
        {
            get
            {
                return this.TranReqDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranReqDate = tmp;
                }
            }
        }
        /// <summary>
        /// 交易记账日期 char(8)，格式YYYYMMDD
        /// </summary>
        [XmlIgnore]
        public DateTime TranDate { get; set; }
        /// <summary>
        /// 交易记账日期 char(8)，格式YYYYMMDD, 对应<see cref="TranDate"/>
        /// </summary>
        [XmlElement("tranDate")]
        public string TranDateStr
        {
            get
            {
                return this.TranDate.ToString("yyyyMMdd");
            }
            set
            {
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.TranDate = tmp;
                }
            }
        }
        /// <summary>
        /// 柜员交易号 char(14)
        /// </summary>
        [XmlElement("chztrno")]
        public string Chztrno { get; set; }
        /// <summary>
        /// 备注 varchar(60)
        /// </summary>
        [XmlElement("tranMemo")]
        public string TranMemo { get; set; }
        /// <summary>
        /// 借贷标志char(1) ,C：贷；D：借
        /// </summary>
        [XmlElement("tranDirection")]
        public string TranDirection { get; set; }
    }
}