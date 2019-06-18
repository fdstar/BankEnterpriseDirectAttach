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
    /// 代发工资导入请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLSALIMP : RqBase<RS_DLSALIMP>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLSALIMP"; set { } }
        /// <summary>
        /// 客户流水号 char(20)
        /// </summary>
        [XmlElement("clientID")]
        public string ClientID { get; set; }
        /// <summary>
        /// 总笔数  必须为数字char(4)
        /// </summary>
        [XmlElement("totalNumber")]
        public int TotalNumber { get { return this.Collection?.List?.Count ?? 0; } set { } }
        /// <summary>
        /// 总金额 deciam(15,2)
        /// </summary>
        [XmlElement("totalAmount")]
        public decimal TotalAmount { get { return this.Collection?.List?.Sum(x => x.TranAmount) ?? 0; } set { } }
        /// <summary>
        /// 付款账号 char(19)
        /// </summary>
        [XmlElement("payAccountNo")]
        public string PayAccountNo { get; set; }
        /// <summary>
        /// 摘要，可空 varchar(102)
        /// </summary>
        [XmlElement("abstract")]
        public string Abstract { get; set; }
        /// <summary>
        /// 短信摘要 char(1)，1：代发工资；2：代发奖金；3：代发津贴；4：代发劳保福利；5：代发财务报销；6：代发拆迁款；7：代发其他；(默认为1：代发工资)
        /// </summary>
        [XmlElement("msgAbstract")]
        public int MsgAbstract { get; set; } = 1;
        /// <summary>
        /// 预约支付标志 0：非预约交易；1：预约交易 char(1)
        /// </summary>
        [XmlElement("preFlg")]
        public int PreFlg { get; set; }
        /// <summary>
        /// 延期支付时间，预约时非空，时间点可选范围 100000，120000，140000，160000
        /// </summary>
        [XmlIgnore]
        public DateTime? AppointmentTime { get; set; }
        /// <summary>
        /// 延期支付日期char(8)　格式YYYYMMDD ，预约时非空
        /// </summary>
        [XmlElement("preDate")]
        public string PreDateStr
        {
            get
            {
                return this.AppointmentTime?.ToString("yyyyMMdd");
            }
            set { }
        }
        /// <summary>
        /// 延期支付时间char(6)  格式hhmmss，只限100000，120000，140000，160000 四个时间点，预约时非空
        /// </summary>
        [XmlElement("preTime")]
        public string PreTimeStr
        {
            get
            {
                return this.AppointmentTime?.ToString("HHmmss");
            }
            set { }
        }
        /// <summary>
        /// 代发年月char(6) 格式YYYYMM
        /// </summary>
        [XmlElement("yearMonth")]
        public string YearMonth { get; set; }

        /// <summary>
        /// 中信银行集合列表
        /// </summary>
        [XmlElement("list")]
        public CITICCollection<AgencyInfo> Collection { get; set; }
    }
    /// <summary>
    /// 代发信息
    /// </summary>
    public class AgencyInfo
    {
        /// <summary>
        /// 员工编号 char(5)
        /// </summary>
        [XmlElement("employeeNo")]
        public string EmployeeNo { get; set; }
        /// <summary>
        /// 员工姓名 varchar(42)
        /// </summary>
        [XmlElement("employeeName")]
        public string EmployeeName { get; set; }
        /// <summary>
        /// 收款账号 char(19)
        /// </summary>
        [XmlElement("recAccountNo")]
        public string RecAccountNo { get; set; }
        /// <summary>
        /// 金额 decimal(15,2)
        /// </summary>
        [XmlElement("tranAmount")]
        public decimal TranAmount { get; set; }
        /// <summary>
        /// 工资条明细varchar(1500)，可空，工资条明细字段中包含的应发项目和应扣项目总和最多50项
        /// </summary>
        [XmlElement("wagDetl")]
        public WageDetails WagDetl { get; set; }
    }
    /// <summary>
    /// 工资明细集合
    /// </summary>
    public class WageDetails
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlText]
        public string Value { get; set; }
        /// <summary>
        /// 将银行格式的字符串转化成集合
        /// </summary>
        /// <returns></returns>
        public IList<WageDetail> GetList()
        {
            IList<WageDetail> list = null;
            if (!string.IsNullOrWhiteSpace(this.Value))
            {
                list = this.Value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x =>
                    {
                        var tmp = x.Split('|');
                        var amount = decimal.Parse(tmp[1]);
                        var project = tmp[0];
                        if (project[0] == '#')
                        {
                            amount = -amount;
                            project = project.Substring(1);
                        }
                        return new WageDetail
                        {
                            Project = project,
                            Amount = amount
                        };
                    }).ToList();
            }
            return list;
        }
        /// <summary>
        /// 将工资集合组织成银行要求的格式
        /// </summary>
        /// <param name="source"></param>
        public void SetList(IEnumerable<WageDetail> source)
        {
            this.Value = null;
            if (source != null && source.Any())
            {
                var tmp = new StringBuilder();
                foreach (var wage in source)
                {
                    tmp.Append(',');
                    if (wage.Amount < 0)
                    {
                        tmp.Append('#');
                    }
                    tmp.Append(wage.Project.Replace(',', '\0').Replace('|', '\0').Replace('#', '\0'));
                    tmp.Append('|');
                    tmp.Append(Math.Abs(wage.Amount));
                }
                tmp.Remove(0, 1);
                this.Value = tmp.ToString();
            }
        }
    }
    /// <summary>
    /// 工资明细
    /// </summary>
    public class WageDetail
    {
        /// <summary>
        /// 项目
        /// </summary>
        public string Project { get; set; }
        /// <summary>
        /// 金额，正值代表应发，负值代表应扣
        /// </summary>
        public decimal Amount { get; set; }
    }
}
