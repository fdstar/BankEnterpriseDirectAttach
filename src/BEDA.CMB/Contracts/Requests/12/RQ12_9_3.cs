using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BEDA.CMB.Contracts.Requests
{
    /// <summary>
    /// 12.9.3.支付机构申请建立商户单位基本情况表请求主体
    /// </summary>
    [XmlRoot("CMBSDKPGK")]
    public class RQ12_9_3 : CMBBase<RQINFO>, IRequest<RS12_9_3>
    {
        /// <summary>
        /// NTBIFADD
        /// </summary>
        /// <returns></returns>
        public override string GetFUNNAM() => "NTBIFADD";
        /// <summary>
        /// 12.9.3.支付机构申请建立商户单位基本情况表请求内容
        /// </summary>
        public NTOPRMODX NTOPRMODX { get; set; }
        /// <summary>
        /// 12.9.3.支付机构申请建立商户单位基本情况表请求内容
        /// </summary>
        public NTBIFADDX NTBIFADDX { get; set; }
    }
    /// <summary>
    /// 12.9.3.支付机构申请建立商户单位基本情况表请求内容
    /// </summary>
    public class NTBIFADDX
    {
        /// <summary>
        /// 来源	C(3) 	PAY:支付机构
        /// </summary>
        public string SRCCOD { get; set; }
        /// <summary>
        /// 业务参考号	C(30)
        /// </summary>
        public string YURREF { get; set; }
        /// <summary>
        /// 分行号       	C(2)	附录A.1
        /// </summary>
        public string BBKNBR { get; set; }
        /// <summary>
        /// 客户号       	C(10)
        /// </summary>
        public string CLTNBR { get; set; }
        /// <summary>
        /// 网点号       	C(6)    支付机构办理业务的经办网点
        /// </summary>
        public string BRNNBR { get; set; }
        /// <summary>
        /// 组织机构代码	C(9) 
        /// </summary>
        public string CUSCOD { get; set; }
        /// <summary>
        /// 单位中文名称	Z(128)
        /// </summary>
        public string CUSNAM { get; set; }
        /// <summary>
        /// 住所营业场所名称及代码	C(6)	附录A.15
        /// </summary>
        public string ARECOD { get; set; }
        /// <summary>
        /// 常驻国家（地区）名称及代码	C(3)	附录A.8
        /// 如果经济类型为100、200、300 项下的任何一项，则常驻国家地区应为中国CHN。 如果经济类型选择400，则常驻国家地区为外国或者港澳台
        /// </summary>
        public string CTRCOD { get; set; }
        /// <summary>
        /// 投资国别代码1	C(3)	附录A.8
        /// </summary>
        public string INVCC1 { get; set; }
        /// <summary>
        /// 投资国别代码2	C(3)	附录A.8
        /// </summary>
        public string INVCC2 { get; set; }
        /// <summary>
        /// 投资国别代码3	C(3)	附录A.8
        /// </summary>
        public string INVCC3 { get; set; }
        /// <summary>
        /// 投资国别代码4	C(3)	附录A.8
        /// </summary>
        public string INVCC4 { get; set; }
        /// <summary>
        /// 投资国别代码5	C(3)	附录A.8
        /// </summary>
        public string INVCC5 { get; set; }
        /// <summary>
        /// 经济类型代码	C(3)	附录A.16
        /// </summary>
        public string ATRCOD { get; set; }
        /// <summary>
        /// 所属行业属性代码	C(4)	附录A.17
        /// </summary>
        public string INDCOD { get; set; }
        /// <summary>
        /// 是否特殊经济区内企业	C(1)	Y：是 N：否
        /// </summary>
        public string TAXFRE { get; set; }
        /// <summary>
        /// 特殊经济区内企业类型	C(2)	附录A.18
        /// 当“是否特殊经济区内企业”=Y 时必须是特殊经济区类型代码表中存在的记录（不能为00，60）；当“是否特殊经济区内企业”=N 时输入00或60
        /// </summary>
        public string TRFCOD { get; set; }
        /// <summary>
        /// 申报方式	C(1)	1：纸质申报；2：网上申报；
        /// </summary>
        public string RPTMTH { get; set; }
        /// <summary>
        /// 单位地址	Z(256)
        /// </summary>
        public string CUSADR { get; set; }
        /// <summary>
        /// 邮政编码	C(6)
        /// </summary>
        public string PSTCOD { get; set; }
        /// <summary>
        /// 外汇局联系用eMail	C(128)
        /// </summary>
        public string MAIADR { get; set; }
        /// <summary>
        /// 交易用eMail	C(128)
        /// </summary>
        public string EXTMAI { get; set; }
        /// <summary>
        /// 单位联系人	Z(40)
        /// </summary>
        public string CONCAT { get; set; }
        /// <summary>
        /// 单位联系电话	C(20)
        /// </summary>
        public string TELNBR { get; set; }
        /// <summary>
        /// 单位传真	C(20)
        /// </summary>
        public string FAXNBR { get; set; }
        /// <summary>
        /// 备注	Z(128)
        /// </summary>
        public string REMARK { get; set; }
        /// <summary>
        /// 保留字50	C(50)
        /// </summary>
        public string RSV50Z { get; set; }
    }
}
