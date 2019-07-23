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
    /// 可操作票据查询请求内容
    /// </summary>
    [XmlRoot("stream")]
    public class RQ_DLBCMQJB : RqBase<RS_DLBCMQJB>
    {
        /// <summary>
        /// 业务对应请求代码
        /// </summary>
        [XmlElement("action")]
        public override string Action { get => "DLBCMQJB"; set { } }
        /// <summary>
        /// 经办交易请求代码 char(8) 见附录：4.1.1、4.1.2、4.1.3
        /// </summary>
        [XmlElement("reqCode")]
        public string ReqCode { get; set; }
        /// <summary>
        /// 签约账号 char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 到期日下区间char(8) 格式：YYYYMMDD，可空。为空表示不设下区间
        /// </summary>
        [XmlIgnore]
        public DateTime? DueDateDown { get; set; }
        /// <summary>
        /// 到期日下区间char(8) 格式：YYYYMMDD, 对应<see cref="DueDateDown"/>
        /// </summary>
        [XmlElement("dueDateDown")]
        public string DueDateDownStr
        {
            get
            {
                return this.DueDateDown?.ToString("yyyyMMdd");
            }
            set
            {
                this.DueDateDown = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDateDown = tmp;
                }
            }
        }
        /// <summary>
        /// 到期日上区间 char(8) 格式：YYYYMMDD，可空。为空表示不设上区间
        /// </summary>
        [XmlIgnore]
        public DateTime? DueDateUp { get; set; }
        /// <summary>
        /// 到期日上区间 char(8) 格式：YYYYMMDD, 对应<see cref="DueDateUp"/>
        /// </summary>
        [XmlElement("dueDateUp")]
        public string DueDateUpStr
        {
            get
            {
                return this.DueDateUp?.ToString("yyyyMMdd");
            }
            set
            {
                this.DueDateUp = null;
                if (DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime tmp))
                {
                    this.DueDateUp = tmp;
                }
            }
        }
        /// <summary>
        /// 票据类型 char(4)，可空，AC01银承，AC02商承，为空表示查询所有类型
        /// </summary>
        [XmlElement("billType")]
        public string BillType { get; set; }
        /// <summary>
        /// 电子票据序列号 char(30)，可空，30位精确票号或末4位票号模糊查询
        /// </summary>
        [XmlElement("billNo")]
        public string BillNo { get; set; }
        /// <summary>
        /// 发起方名称 varchar(122)，可空
        /// </summary>
        [XmlElement("orgName")]
        public string OrgName { get; set; }
        /// <summary>
        /// 接收方名称 varchar(122)，可空
        /// </summary>
        [XmlElement("rcvName")]
        public string RcvName { get; set; }
        /// <summary>
        /// 票据金额下区间 decimal(15，2)，可空
        /// </summary>
        [XmlElement("billAmtDown")]
        public decimal? BillAmtDown { get; set; }
        /// <summary>
        /// 票据金额上区间 decimal(15，2)，可空
        /// </summary>
        [XmlElement("billAmtUp")]
        public decimal? BillAmtUp { get; set; }
        /// <summary>
        /// ECDS批次号 varchar(10) 可空 不为空时必须为数字
        /// </summary>
        [XmlElement("ecdsBatNo")]
        public string EcdsBatNo { get; set; }
        /// <summary>
        /// 逾期标志 char(2)，可空，提示付款操作时，必填，01正常，02逾期
        /// </summary>
        [XmlElement("odueFlg")]
        public string OdueFlg { get; set; }
        /// <summary>
        /// 追索类型 char(4)，可空，追索通知时，必填，RT00拒付追索，RT01非拒付追索
        /// </summary>
        [XmlElement("rcrsType")]
        public string RcrsType { get; set; }
    }
}
