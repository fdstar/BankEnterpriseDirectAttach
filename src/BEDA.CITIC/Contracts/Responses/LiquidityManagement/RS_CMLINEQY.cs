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
    /// 现金管理额度查询响应内容
    /// </summary>
    [XmlRoot("stream")]
    public class RS_CMLINEQY : RsBase
    {
        /// <summary>
        /// 成员单位账号char(19)
        /// </summary>
        [XmlElement("accountNo")]
        public string AccountNo { get; set; }
        /// <summary>
        /// 资金标识 char(1)  0：自身平衡；1：限额透支；2：全额透支；3：超归集下拨；4：看管；5：委存委贷
        /// </summary>
        public int FUNDMGRFLAG { get; set; }
        /// <summary>
        /// 集团分配透支额度 decimal(15,2)
        /// </summary>
        public decimal OVERAMT { get; set; }
        /// <summary>
        /// 超归集下拨额度 decimal(15,2)
        /// </summary>
        public decimal BEYONDAMT { get; set; }
        /// <summary>
        /// 集团看管金额 decimal(15,2)
        /// </summary>
        public decimal GUARDAMT { get; set; }
    }
}
