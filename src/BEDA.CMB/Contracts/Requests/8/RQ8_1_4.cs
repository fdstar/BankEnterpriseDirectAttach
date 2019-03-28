using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 8.1.4.开立基金账户NTFNDOAC请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ8_1_4 : CMBBase<RQINFO>, IRequest<RS8_1_4>
    {
        /// <summary>
        /// NTFNDOAC
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTFNDOAC";
        /// <summary>
        /// 8.1.4.开立基金账户NTFNDOAC请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 8.1.4.开立基金账户NTFNDOAC请求内容
        /// </summary>
        public NTFNDOACX NTFNDOACX { get; set; }
    }
    /// <summary>
    /// 8.1.4.开立基金账户NTFNDOAC请求内容
    /// </summary>
    public class NTFNDOACX
    {
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 账号	C(35)
        /// </summary>
        public string EACNBR { get; set; }
        /// <summary>
        /// 基金协议	C(10)
        /// </summary>
        public string FNDCTR { get; set; }
        /// <summary>
        /// 登记机构	C(3)
        /// </summary>
        public string TAACOD { get; set; }
        /// <summary>
        /// 证件号	C(30)
        /// </summary>
        public string CTFIDC { get; set; }
        /// <summary>
        /// 证件类别	C(3)	
        /// C01：营业执照
        /// C09：组织机构代码
        /// P01：身份证
        /// P02：学生证
        /// P03：临时身份证
        /// P04：军人证
        /// P08：武警证
        /// P16：户口簿
        /// </summary>
        public string CTFTYP { get; set; }
        /// <summary>
        /// 基金账号	C(35)   增加基金账户时用，暂无用
        /// </summary>
        public string FNDACT { get; set; }
        /// <summary>
        /// 通讯地址	Z(60)
        /// </summary>
        public string CLTADR { get; set; }
        /// <summary>
        /// 邮政编码	C(6)
        /// </summary>
        public string PSTCOD { get; set; }
        /// <summary>
        /// 电话	C(20)
        /// </summary>
        public string TELNBR { get; set; }
        /// <summary>
        /// 传真	C(20)
        /// </summary>
        public string FAXNBR { get; set; }
        /// <summary>
        /// 移动电话	C(20)
        /// </summary>
        public string MOBPHN { get; set; }
        /// <summary>
        /// 电子邮箱	C(40)
        /// </summary>
        public string EMLNUM { get; set; }
        /// <summary>
        /// 经办人姓名	Z(20)
        /// </summary>
        public string OPRNAM { get; set; }
        /// <summary>
        /// 经办人证件	C(30)
        /// </summary>
        public string OPRIDC { get; set; }
        /// <summary>
        /// 经办人证件类别	C(3)
        /// </summary>
        public string OPRIDT { get; set; }
        /// <summary>
        /// 推荐人	Z(20)
        /// </summary>
        public string CMDNAM { get; set; }
    }
}
