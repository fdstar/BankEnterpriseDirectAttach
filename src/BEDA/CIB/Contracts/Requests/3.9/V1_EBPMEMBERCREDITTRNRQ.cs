using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CIB.Contracts.Requests
{
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请请求主体
    /// </summary>
    public class V1_EBPMEMBERCREDITTRNRQ : IRequest<V1_EBPMEMBERCREDITTRNRS>
    {
        /// <summary>
        /// 3.9.3.22电子商业汇票成员单位用信申请请求主体
        /// </summary>
        public EBPMEMBERCREDITTRNRQ EBPMEMBERCREDITTRNRQ { get; set; }
    }
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请请求主体
    /// </summary>
    public class EBPMEMBERCREDITTRNRQ : BIZRQBASE
    {
        /// <summary>
        /// 3.9.3.22电子商业汇票成员单位用信申请请求内容
        /// </summary>
        [XmlElement(Order = 2)]
        public EBPMEMBERCREDITTRN_RQBODY RQBODY { get; set; }
    }
    /// <summary>
    /// 3.9.3.22电子商业汇票成员单位用信申请请求内容
    /// </summary>
    public class EBPMEMBERCREDITTRN_RQBODY
    {
        /// <summary>
        /// 集团票据池编号, 使用“客户签约关系查询”接口获取	必输
        /// </summary>
        [XmlElement(Order = 2)]
        public string GROUPBILLPOOLNO { get; set; }
        /// <summary>
        /// 业务类型 必输
        /// 04-质押出池
        /// 05-质押转托管
        /// 08-承兑开票
        /// 11-保证金提取
        /// 12-资产业务
        /// </summary>
        [XmlElement(Order = 3)]
        public string BIZTYPE { get; set; }
        /// <summary>
        /// 额度种类 必输
        /// 1-票据池低风险额度
        /// 2-票据池非低风险额度
        /// </summary>
        [XmlElement(Order = 4)]
        public int LIMITTYPE { get; set; }
        /// <summary>
        /// 保证金账号，如果业务类型为11-保证金提取，那么必须提供该字段	非必输
        /// </summary>
        [XmlElement(Order = 5)]
        public string BAILACCTNO { get; set; }
        /// <summary>
        /// 资产业务类型，如果业务类型为12-资产业务，那么必须提供该字段  非必输
        /// 01-流动资金贷款
        /// 02-国内信用证
        /// 03-法人账户透支
        /// 04-融资性保函
        /// 05-非融资性保函
        /// </summary>
        [XmlElement(Order = 6)]
        public string CAPITALBIZTYPE { get; set; }
        /// <summary>
        /// 资产业务到期日，格式：YYYY-MM-DD，如果业务类型为12-资产业务，那么必须提供该字段；	非必输
        /// </summary>
        [XmlIgnore]
        public DateTime? CAPITALDUEDATE { get; set; }
        /// <summary>
        /// 资产业务到期日，格式：YYYY-MM-DD，如果业务类型为12-资产业务，那么必须提供该字段 ,对应<see cref="CAPITALDUEDATE"/> 非必输
        /// </summary>
        [XmlElement("CAPITALDUEDATE", Order = 7)]
        public string CAPITALDUEDATEStr
        {
            get
            {
                return this.CAPITALDUEDATE?.ToString("yyyy-MM-dd");
            }
            set
            {
                this.CAPITALDUEDATE = value.TryConvert<DateTime>();
            }
        }
        /// <summary>
        /// 申请金额（18,2）	必输
        /// </summary>
        [XmlElement(Order = 8)]
        public decimal APPLYAMT { get; set; }
    }
}
