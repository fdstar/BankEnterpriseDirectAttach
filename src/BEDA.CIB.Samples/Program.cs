using BEDA.CIB.Contracts;
using BEDA.CIB.Contracts.Requests;
using BEDA.CIB.Contracts.Responses;
using BEDA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BEDA.CIB.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            //为了方便调试，所有具体的业务请求方法故意不提取公共部分
            #region 3.2	登录消息
            //LoginSample();
            #endregion

            #region 3.3	账户查询
            //CURRACCTQUERYTRNRQSample();
            //TIMEQUERYTRNRQSimple();
            //TIMEDEPOSITQUERYTRNRQSample();
            //DEMANDDEPOSITQUERYTRNRQSample();
            //ACCOUNTQUERYTRNRQSample();
            //SCUSTSTMTTRNRQSample();
            //BALNTRADEINQUIRYTRNRQSample();
            //FIRMTIMEQUERYTRNRQSample();
            //FSTMTTRNRQSample();
            //TRADEOVERVIEWTRNRQSample();
            #endregion

            #region 3.4	企业财务室
            //XFERTRNRQSample();
            //XFERINQTRNRQSample();
            //RPAYOFFTRNRQSample();
            //RPAYOFFINQTRNRQSample();
            //GATHERTRNRQSample();
            //FBBATCHGATHERTRNRQSample();
            //FBBATCHSTMTTRNRQSample();
            //RBATCHTRSFRTRNRQSample();
            //RECEIPTTRNRQSample();
            //ICTRANSFERTRNRQSample();
            //ICTRANSFERINQTRNRQSample();
            //ASYNBATCHTRSFRTRNRQSample();
            #endregion

            #region 3.5	证券交易
            //STOCKTRSFRTRNRQSample();
            //STOCKQUERYTRNRQSample();
            //TPCONTRTRNRQSample();
            //TPFUNDEXCHANGETRNRQSample();
            //TPTRSFRQUERYTRNRQSample();
            //TPFUNDQUERYTRNRQSample();
            //BFEEXCHANGETRNRQSample();
            //QFUNDACCTINFOTRNRQSample();
            //QBFDETAILTRNRQSample();
            //CREATEOPTIONSPOTTRNRQSample();
            //QUERYOPTIONSPOTTRNRQSample();
            //OPTIONSPOTDETAILTRNRQSample();
            //QUERYTRADECOMMANDTRNRQSample();
            #endregion

            #region 3.6	虚拟子账户
            //VSASIGNTRNRQSample();
            //VSABATCHOPENTRNRQSample();
            //VSASUBACCTINFOTRNRQSample();
            //VSAALLOTTRNRQSample();
            //VATTRNRQSample();
            //VATSTMTTRNRQSample();
            //VSAINTRSFTRNRQSample();
            //VSACANCELTRNRQSample();
            #endregion

            #region 3.7	集团服务
            //XPMTTRNRQSimple();
            //CMSTMTQUERYTRNRQSimple();
            //CMMBRQUERYTRNRQSimple();
            //CMHISBLNCTRNRQSimple();
            //CMINNERQUERYTRNRQSimple();
            //CMTRANSDETAILTRNRQSimple();
            //CMMEMSTMTQUERYTRNRQSimple();
            //CMAVBLQUOTATRNRQSimple();
            #endregion

            #region 3.8	理财产品投资
            //FPPURCHTRNRQSample();
            //FPREDMTRNRQSample();
            //FPPRODTRNRQSample();
            //FPAGMTTRNRQSample();
            //FPASSETSTRNRQSample();
            //FPCUSTTRNRQSample();
            //FPAGMTSIGNTRNRQSample();
            //FPAGMTSTATUSTRNRQSample();
            #endregion

            #region 3.9	电子商业汇票系统
            //EBSTMTQUERYTRNRQSample();
            //EBOPRNQUERYTRNRQSample();
            //EBSIGNQUERYTRNRQSample();
            //EBFACEQUERYTRNRQSample();
            //EBBASEQUERYTRNRQSample();
            //EBBACKQUERYTRNRQSample();
            //EBCRDQUERYTRNRQSample();
            //EBRECRQUERYTRNRQSample();
            //EBBATCHSTATUSTRNRQSample();
            //EBREALPAYTRNRQSample();
            //EBPAYQUERYTRNRQSample();
            //EBPAPERQUERYTRNRQSample();
            //EBAUTOCLUEPAYQUERYTRNRQSample();

            //EBDRAWTRNRQSample();
            //EBGUARNTTRNRQSample();
            //EBACPTTRNRQSample();
            //EBCOLLTRNRQSample();
            //EBCANCLTRNRQSample();
            //EBENDRSTRNRQSample();
            //EBDISCNTTRNRQSample();
            //EBREDMTRNRQSample();
            //EBIMPAWNTRNRQSample();
            //EBIMPAWNCANCLTRNRQSample();
            //EBCUEPAYTRNRQSample();
            //EBRECRSTRNRQSample();
            //EBDISCHGTRNRQSample();
            //EBRECEDETRNRQSample();
            //EBSIGNTRNRQSample();

            //EBPINPOOLTRNRQSample();
            //EBPOUTPOOLTRNRQSample();
            //EBPCONVERTTRNRQSample();
            //EBPOUTBILLTRNRQSample();
            //EBPFINANCINGTRNRQSample();
            //EBPCASHTRNRQSample();
            //EBPBAILTRNRQSample();
            //EBPBILLPOOLRESULTQUERYTRNRQSample();
            //EBPOPERATEBILLQUERYTRNRQSample();
            //EBPCUSTSIGNINFOQUERYTRNRQSample();
            //EBPGROUPCUSTQUERYTRNRQSample();
            //EBPSINGLELIMITQUERYTRNRQSample();
            //EBPGROUPLIMITQUERYTRNRQSample();
            //EBPMEMBERLIMITQUERYTRNRQSample();
            //EBPOUTINPOOLREGISTERTRNRQSample();
            //EBPCONVERTREGISTERTRNRQSample();
            //EBPOPENBILLREGISTERTRNRQSample();
            //EBPCAPITALREGISTERTRNRQSample();
            //EBPBAILREGISTERTRNRQSample();
            //EBPINPOOLBILLREGISTERTRNRQSample();
            //EBPCOLLECTIONREGISTERTRNRQSample();
            //EBPMEMBERCREDITTRNRQSample();
            //EBPMEMBERCREDITQUERYTRNRQSample();
            //EBPCREDITRESULTQUERYTRNRQSample();
            //EBPMEMBERCREDITAUDITTRNRQSample();
            #endregion

            #region 3.10	跨行账户管理
            //CRSACCTREGTRNRQSample();
            //CRSAGRMQTRNRQSample();
            //CRSBLNCQUERYTRNRQSample();
            //CRSSTMTTRNRQSample();
            //CRSGATHERTRNRQSample();
            #endregion

            #region 3.11	贵金属交易
            //PMCONTRQUERYTRNRQSample();
            //PMINVNQUERYTRNRQSample();
            //PMFUNDQUERYTRNRQSample();
            //PMMBRQUERYTRNRQSample();
            //PMDLVRYQUERYTRNRQSample();
            //PMSTMTQUERYTRNRQSample();
            //PMINVESTTRNRQSample();
            //PMREFUNDTRNRQSample();
            //PMDLVRYAPPLYTRNRQSample();
            #endregion

            #region 3.12	定活互转
            //DEMAND2TIMETRNRQSample();
            //TIME2DEMANDTRNRQSample();
            //CCCURR2CALLTRNRQSample();
            //CCCALL2CURRTRNRQSample();
            //ICCONTRTRNRQSample();
            //ICAGMTTRNRQSample();
            //ICREGTRNRQSample();
            //ICCANCELTRNRQSample();
            //ICWITHDRAWALTRNRQSample();
            //STRUCTPRODUCTTRNRQSample();
            //DEMANDTOSTRUCTTRNRQSample();
            //DEMANDTOSTRUCTQUERYTRNRQSample();
            //STRUCTACCOUNTTRNRQSample();
            //STRUCTTODEMANDTRNRQSample();
            //STRUCTTODEMANDQUERYTRNRQSample();
            //INTGNTTIMEINTCONSIGNTRNRQSample();
            //INTGNTTIMEINTCONQUERYTRNRQSample();
            //INTGNTTIMEINTCONMODIFYTRNRQSample();
            //INTGNTTIMEINTCONUNCONTRNRQSample();
            //CREATEINTELLIGENTTIMETRNRQSample();
            //QUERYINTELLIGENTTIMETRNRQSample();
            //QUERYINTELLIGENTTIMEDETAILTRNRQSample();
            //DRAWINTELLIGENTTIMETRNRQSample();
            //TRADEAPASSDETAILTRNRQSample();
            //TRADEAPASSTRNRQSample();
            #endregion

            #region 3.13	扩展功能
            //BATCHTRNRQSample();
            //BPAYOFFTRNRQSample();
            //HISBALQUERYTRNRQSample();
            //ELECAPPLYTRNRQSample();
            //HWKSUMUPTRNRQSample();
            //INQSTATETRNRQSample();
            //CHINAMOBILETAXQUERYTRNRQSample();
            #endregion

            #region 3.14	财务公司代理支付
            //VAPMTTRNRQSample();
            #endregion

            #region 3.15	电子商务
            //MRCHREFUNDTRNRQSample();
            //MRCHORDERTRNRQSample();
            #endregion

            #region 3.16	收付直通车商户资金代付
            //MAGENTPAYTRNRQSample();
            //ASYNBATCHMRCHAGENTTRNRQSample();
            #endregion

            #region 3.17	虚拟资金池
            //DCPMGTTRNRQSample();
            //DCPINTERESTADJUSTTRNRQSample();
            //DCPINTRSTQUERYTRNRQSample();
            //QUERYSIGNRELATIONTRNRQSample();
            //MAINACCTPAYLIMITTRNRQSample();
            //MEMACCTPROPCFGTRNRQSample();
            //MAINACCTPROPQUERYTRNRQSample();
            //MEMACCTPROPQUERYTRNRQSample();
            #endregion

            #region 3.18	跨境电商
            //QUERYBULLETINTRNRQSample();
            //CBECEXCHANGETRNRQSample();
            //CBECSETTLEMENTDECLARETRNRQSample();
            //CBECPURCHASEDECLARETRNRQSample();
            //CBECSETTLEMENTDECLAREREINTRNRQSample();
            //CBECPURCHASEDECLAREREINTRNRQSample();
            //CBECPURCHASEDECLAREREINTRNRQSample();
            //CBECEXCHANGEDECLAREQUERYTRNRQSample();
            //CBECTRANSFERTRNRQSample();
            //CBECPAYNOTICEQUERYTRNRQSample();
            //CBECINNOTICEQUERYTRNRQSample();
            //CBECTRANSFERDECLARETRNRQSample();
            #endregion

            #region 3.19	跨境资金池
            //CBCPALLOCATETRNRQSample();
            //CBCPINTERESTADJUSTTRNRQSample();
            //CBCPINTRSTQUERYTRNRQSample();
            //CBCPEXCHNGTRNRQSample();
            //CBCPEXCHNGTRADEQUERYTRNRQSample();
            //CBCPTRANSFERTRNRQSample();
            //CBCPMEMACCTQUERYTRNRQSample();
            //CBCPMAINACCTQUERYTRNRQSample();
            //CBCPTRADEDETAILQUERYTRNRQSample();
            //CBCPMEMTRADEQUERYTRNRQSample();
            //CBCPACCTCFGQUERYTRNRQSample();
            //CBCPMEMALLOCATETRNRQSample();
            //CBCPMAINTRSFRTRNRQSample();
            //CBCPMAINTRADEQUERYTRNRQSample();
            #endregion

            #region 3.20	信用证
            //LCOPENAPPLYTRNRQSample();
            //LCAMENDAPPLYTRNRQSample();
            //LCPAYAPPLYTRNRQSample();
            //LCOPENNOTICEQUERYTRNRQSample();
            //LCAMENDNOTICEQUERYTRNRQSample();
            //LCLITDCKNOTICEQUERYTRNRQSample();
            //LCREJECTNOTICEQUERYTRNRQSample();
            //LCACCEPTNOTICEQUERYTRNRQSample();
            //LCPAYNOTICEQUERYTRNRQSample();
            //LCCOMENOTICEQUERYTRNRQSample();
            #endregion

            #region  3.21	电子回单
            //ELECTRONICRECEIPTTRNRQSample();
            //ASYNRECEIPTINFOTRNRQSample();
            #endregion

            #region 3.23	批量余额对账
            //BATCHCHECKTRNRQSample();
            //BATCHCHECKQUERYTRNRQSample();
            #endregion

            Console.ReadLine();
        }

        #region 基础数据
        const long cid = 1100343164;
        const string uid = "qw1";
        const string pwd = "a1111111";//密码错误6次账号会被永久锁定无法解锁
        const string ip = "127.0.0.1";
        const int port = 8007;
        static ICIBClient client = new CIBClient(ip, port);

        const string mainAccountId = "117010100100000177";
        const string mainAccountName = "中国民族证券有限责任公司12";
        const string financeInnerAccountId = "111333";

        public static T GetRequest<T>()
            where T : FOXRQ, new()
        {
            return new T
            {
                SIGNONMSGSRQV1 = new SIGNONMSGSRQV1
                {
                    SONRQ = new SONRQ
                    {
                        CID = cid,
                        USERID = uid,
                        USERPASS = pwd,
                    }
                }
            };
        }
        #endregion

        #region 3.2	登录消息
        /// <summary>
        /// 3.2	登录消息
        /// </summary>
        public static void LoginSample()
        {
            var rq = GetRequest<FOXRQ>();
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.3	账户查询
        /// <summary>
        /// 3.3.1	活期账户信息查询
        /// </summary>
        public static void CURRACCTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CURRACCTQUERYTRNRQ, V1_CURRACCTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CURRACCTQUERYTRNRQ
            {
                CURRACCTQUERYTRNRQ = new CURRACCTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.2	定期账户查询
        /// </summary>
        public static void TIMEQUERYTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TIMEQUERYTRNRQ, V1_TIMEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TIMEQUERYTRNRQ
            {
                TIMEQUERYTRNRQ = new TIMEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId,
                        PAGE = 1
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.3	定期存款信息查询
        /// </summary>
        public static void TIMEDEPOSITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TIMEDEPOSITQUERYTRNRQ, V1_TIMEDEPOSITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TIMEDEPOSITQUERYTRNRQ
            {
                TIMEDEPOSITQUERYTRNRQ = new TIMEDEPOSITQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.4	非定期存款信息查询
        /// </summary>
        public static void DEMANDDEPOSITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DEMANDDEPOSITQUERYTRNRQ, V1_DEMANDDEPOSITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DEMANDDEPOSITQUERYTRNRQ
            {
                DEMANDDEPOSITQUERYTRNRQ = new DEMANDDEPOSITQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.5	账户信息查询
        /// </summary>
        public static void ACCOUNTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ACCOUNTQUERYTRNRQ, V1_ACCOUNTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ACCOUNTQUERYTRNRQ
            {
                ACCOUNTQUERYTRNRQ = new ACCOUNTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.6	账户余额和交易流水分页查询
        /// </summary>
        public static void SCUSTSTMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_SCUSTSTMTTRNRQ, V1_SCUSTSTMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_SCUSTSTMTTRNRQ
            {
                SCUSTSTMTTRNRQ = new SCUSTSTMTTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    SCUSTSTMTRQ = new SCUSTSTMTTRN_SCUSTSTMTRQ
                    {
                        VERSION = "2.0",
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        INCTRAN = new INCTRAN
                        {
                            DTEND = DateTime.Now,
                            DTSTART = DateTime.Now,
                            TRNTYPE = 2,
                        },
                        SELTYPE = 1
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.7	账号余额和交易流水分页查询（返回增加虚拟子账户交易信息）
        /// </summary>
        public static void BALNTRADEINQUIRYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BALNTRADEINQUIRYTRNRQ, V1_BALNTRADEINQUIRYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BALNTRADEINQUIRYTRNRQ
            {
                BALNTRADEINQUIRYTRNRQ = new BALNTRADEINQUIRYTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    RQBODY = new BALNTRADEINQUIRYTRN_RQBODY
                    {
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        INCTRAN = new INCTRAN
                        {
                            DTEND = DateTime.Now.AddDays(-1),
                            DTSTART = DateTime.Now.AddDays(-1),
                            TRNTYPE = 2,
                        },
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.8	单位定期一本通账户查询
        /// </summary>
        public static void FIRMTIMEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FIRMTIMEQUERYTRNRQ, V1_FIRMTIMEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FIRMTIMEQUERYTRNRQ
            {
                FIRMTIMEQUERYTRNRQ = new FIRMTIMEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.3.9	账户交易流水文件查询
        /// </summary>
        public static void FSTMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FSTMTTRNRQ, V1_FSTMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FSTMTTRNRQ
            {
                FSTMTTRNRQ = new FSTMTTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    SCUSTSTMTRQ = new FSTMTTRN_SCUSTSTMTRQ
                    {
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        INCTRAN = new FSTMTTRN_INCTRAN
                        {
                            DTEND = DateTime.Now.AddDays(-1),
                            DTSTART = DateTime.Now.AddDays(-1),
                            TRNTYPE = 2,
                            NUM = 100
                        },
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
            var list = rs.SECURITIES_MSGSRSV1.FSTMTTRNRS.SCUSTSTMTRS.TRANLIST.GetDetails();
        }
        /// <summary>
        /// 3.3.10	交易概览
        /// </summary>
        public static void TRADEOVERVIEWTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.3.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TRADEOVERVIEWTRNRQ, V1_TRADEOVERVIEWTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TRADEOVERVIEWTRNRQ
            {
                TRADEOVERVIEWTRNRQ = new TRADEOVERVIEWTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new TRADEOVERVIEWTRN_RQBODY
                    {
                        QUERYDATE = DateTime.Now.AddDays(-2)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.4	企业财务室
        /// <summary>
        /// 3.4.1	转账汇款指令提交
        /// </summary>
        public static void XFERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_XFERTRNRQ, V1_XFERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_XFERTRNRQ
            {
                XFERTRNRQ = new XFERTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    XFERRQ = new XFERRQ
                    {
                        XFERINFO = new XFERINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId,
                                NAME = mainAccountName
                            },
                            ACCTTO = GetACCTTO(3),
                            PURPOSE = "转账目的",
                            TRNAMT = 7.77m,
                            //DTDUE = DateTime.Now,//如果需要网银审核，在该日期之后如果还未审核，则支付请求过期
                            MEMO = "转账测试审核过期",
                        }
                    }
                }
            };
            //rq.SECURITIES_MSGSRQV1.XFERTRNRQ.TRNUID =  "20190130102306_3.4.1"; //过期 20190129151451_3.4.1
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 获取转账账号 
        /// 0 普通转账、对公收款账号(行内)
        /// 1 兴业银行对私收款账号（行内）
        /// 2 普通转账、对公收款账号(跨行)
        /// 3 普通转账、对私收款账号(跨行)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static ACCTTO GetACCTTO(byte type)
        {
            switch (type)
            {
                case 0://普通转账、对公收款账号(行内)
                    return new ACCTTO
                    {
                        ACCTID = "117010100100107091",
                        INTERBANK = "Y",
                        LOCAL = "Y",
                        NAME = "test",
                    };
                case 1://兴业银行对私收款账号（行内）
                    return new ACCTTO
                    {
                        ACCTID = "622909117529613510",
                        INTERBANK = "Y",
                        LOCAL = "Y",
                        NAME = "小金人",
                    };
                case 2://普通转账、对公收款账号(跨行)
                    return new ACCTTO
                    {
                        ACCTID = "123455555",
                        INTERBANK = "N",
                        LOCAL = "Y",
                        NAME = "平安银行测试2222",
                        BANKDESC = "平安银行股份有限公司上海九江路支行",
                        CITY = "上海市"
                    };
                default://普通转账、对私收款账号(跨行)
                    return new ACCTTO
                    {
                        ACCTID = "6225885123771966",
                        INTERBANK = "N",
                        LOCAL = "Y",
                        NAME = "陈晨",
                        BANKDESC = "中国工商银行股份有限公司北京通州支行新华分理处",
                        CITY = "北京市"
                    };
            }
        }
        /// <summary>
        /// 3.4.2	查询转账交易状态
        /// </summary>
        public static void XFERINQTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_XFERINQTRNRQ, V1_XFERINQTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_XFERINQTRNRQ
            {
                XFERINQTRNRQ = new XFERINQTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    XFERINQRQ = new XFERINQRQ
                    {
                        CLIENTREF = "20190125145132_3.4.1"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.3	工资发放指令提交
        /// </summary>
        public static void RPAYOFFTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_RPAYOFFTRNRQ, V1_RPAYOFFTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_RPAYOFFTRNRQ
            {
                RPAYOFFTRNRQ = new RPAYOFFTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    RPAYOFFRQ = new RPAYOFFRQ
                    {
                        RPAYOFFINFO = new RPAYOFFINFO<RPAYOFF>
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId
                            },
                            TITLE = "工资发放",
                            DESCRIPTION = "006",
                            RPAYOFFLIST = new RPAYOFFLIST<RPAYOFF>
                            {
                                List = new List<RPAYOFF>()
                            },
                        }
                    }
                }
            };
            var acct = GetACCTTO(1);
            rq.SECURITIES_MSGSRQV1.RPAYOFFTRNRQ.RPAYOFFRQ.RPAYOFFINFO.RPAYOFFLIST.List.Add(
                new RPAYOFF
                {
                    INDX = 1,
                    ACCTID = acct.ACCTID,
                    ACCTNAME = acct.NAME,
                    TRNAMT = 2.2m
                });
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.4	工资发放指令查询
        /// </summary>
        public static void RPAYOFFINQTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_RPAYOFFINQTRNRQ, V1_RPAYOFFINQTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_RPAYOFFINQTRNRQ
            {
                RPAYOFFINQTRNRQ = new RPAYOFFINQTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "123",
                    XFERINQRQ = new XFERINQRQ
                    {
                        CLIENTREF = "20190117135721_3.4.3"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.5	单笔托收、子账户托收、回款查询
        /// </summary>
        public static void GATHERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_GATHERTRNRQ, V1_GATHERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_GATHERTRNRQ
            {
                GATHERTRNRQ = new GATHERTRNRQ
                {
                    TRNUID = tid,
                    GATHERRQ = new GATHERRQ
                    {
                        GATHERINFO = new GATHERRQINFO
                        {
                            ACCTTO = new GATHERRQ_ACCTTO
                            {
                                ACCTID = mainAccountId,
                            },
                            FIRMCODE = "8778",
                            BIZCODE = "00100",
                            LIMITDAYS = 1,
                            TITLE = "单笔托收",
                            MEMO = "备注测试",
                            TRNTYPE = 1,
                            PAYINFO = new RQPAYINFO
                            {
                                INDX = 1,
                                CONTRACTID = "2016",
                                ACCTFROM = new CORRELATEACCT
                                {
                                    ACCTID = "117010100100107091",
                                    NAME = "test"
                                },
                                PAYMODE = 0,
                                APPLYAMT = 12.7m,
                                PURPOSE = "电费",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.6	批量托收、批量子账户托收
        /// </summary>
        public static void FBBATCHGATHERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FBBATCHGATHERTRNRQ, V1_FBBATCHGATHERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FBBATCHGATHERTRNRQ
            {
                FBBATCHGATHERTRNRQ = new FBBATCHGATHERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FBBATCHGATHERTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        FIRMCODE = "8778",
                        BIZCODE = "00100",
                        LIMITDAYS = 1,
                        TITLE = "批量托收",
                        MEMO = "批量备注",
                        TRNTYPE = 1,
                        USE = "收电费",
                        GATHERINFO = new List<FBBATCHGATHER_PAYINFO>
                        {
                            new FBBATCHGATHER_PAYINFO{
                                INDX =1,
                                CONTRACTID="2016",
                                ACCTFROM =new CORRELATEACCT{
                                    ACCTID = "117010100100107091",
                                    NAME = "test"
                                },
                                PAYMODE=0,
                                APPLYAMT=3.3m,
                                PURPOSE="电费1",
                                BIZCODE0="00100",
                                BIZCODE1="00100",
                                //BIZCODE2="00100", 切记此处不能输入BIZCODE2
                                MEMO ="电费1"
                            },
                            new FBBATCHGATHER_PAYINFO{
                                INDX =2,
                                CONTRACTID="20170510",
                                ACCTFROM =new CORRELATEACCT{
                                    ACCTID = "622908121000127611",
                                    NAME = "汪汪"
                                },
                                PAYMODE=0,
                                APPLYAMT=5.7m,
                                PURPOSE="电费2",
                                BIZCODE0="00100",
                                BIZCODE1="00100",
                                //BIZCODE2="00100", 切记此处不能输入BIZCODE2
                                MEMO ="电费2"
                            },
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.7	批量托收或子账户托收明细查询
        /// </summary>
        public static void FBBATCHSTMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FBBATCHSTMTTRNRQ, V1_FBBATCHSTMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FBBATCHSTMTTRNRQ
            {
                FBBATCHSTMTTRNRQ = new FBBATCHSTMTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FBBATCHSTMTTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        CLIENTREF = "20190117160138_3.4.6",
                        PAGE = 1,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.8	实时批量支付与批量费用(最多100笔)
        /// </summary>
        public static void RBATCHTRSFRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_RBATCHTRSFRTRNRQ, V1_RBATCHTRSFRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_RBATCHTRSFRTRNRQ
            {
                RBATCHTRSFRTRNRQ = new RBATCHTRSFRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RBATCHTRSFRTRN_RQBODY<RBATCHTRSFRTRNRQ_XFERINFO>
                    {
                        //TITLE= "实时批量支付与批量费用",
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        BIZTYPE = 0,
                        PURPOSE = "实时批量支付与批量费用",
                        List = new List<RBATCHTRSFRTRNRQ_XFERINFO>
                        {
                            new RBATCHTRSFRTRNRQ_XFERINFO{
                                INDX =1,
                                ACCTTO =GetACCTTO(0),
                                TRNAMT=1.1m,
                                USE="对公行内"
                            },
                            new RBATCHTRSFRTRNRQ_XFERINFO
                            {
                                INDX =2,
                                ACCTTO =GetACCTTO(1),
                                TRNAMT=2.2m,
                                USE="对私行内"
                            },
                            new RBATCHTRSFRTRNRQ_XFERINFO
                            {
                                INDX =3,
                                ACCTTO =GetACCTTO(2),
                                TRNAMT=3.2m,
                                USE="对公跨行"
                            },
                            new RBATCHTRSFRTRNRQ_XFERINFO
                            {
                                INDX =4,
                                ACCTTO =GetACCTTO(4),
                                TRNAMT=4.1m,
                                USE="对私跨行"
                            },
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.9	指令回单查询
        /// </summary>
        public static void RECEIPTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_RECEIPTTRNRQ, V1_RECEIPTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_RECEIPTTRNRQ
            {
                RECEIPTTRNRQ = new RECEIPTTRNRQ
                {
                    TRNUID = "20190117114159_3.4.1",
                    BIZTYPE = 1,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.10	快速转账支付及其指令查询（不采用工作流）  3.4.10.3 快速转账支付ICTRANSFERTRNRQ
        /// </summary>
        public static void ICTRANSFERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.10.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICTRANSFERTRNRQ, V1_ICTRANSFERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICTRANSFERTRNRQ
            {
                ICTRANSFERTRNRQ = new ICTRANSFERTRNRQ
                {
                    TRNUID = tid,
                    XMPTRQ = new XMPTRQ<RQACCT>
                    {
                        XFERINFO = new XFERINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId
                            },
                            ACCTTO = GetACCTTO(3),
                            TRNAMT = 3.1m,
                            PURPOSE = "快速转账支付ICTRANSFERTRNRQ",
                            DTDUE = DateTime.Now,
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.10	快速转账支付及其指令查询（不采用工作流）3.4.10.5 支付指令查询ICTRANSFERINQTRNRQ请求
        /// </summary>
        public static void ICTRANSFERINQTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.10.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICTRANSFERINQTRNRQ, V1_ICTRANSFERINQTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICTRANSFERINQTRNRQ
            {
                ICTRANSFERINQTRNRQ = new ICTRANSFERINQTRNRQ
                {
                    TRNUID = tid,
                    XFERINQRQ = new XFERINQRQ
                    {
                        CLIENTREF = "20190117193801_3.4.10.3"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.4.12	异步批量支付 (最多100笔，不采用工作流)
        /// </summary>
        public static void ASYNBATCHTRSFRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.4.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ASYNBATCHTRSFRTRNRQ, V1_ASYNBATCHTRSFRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ASYNBATCHTRSFRTRNRQ
            {
                ASYNBATCHTRSFRTRNRQ = new ASYNBATCHTRSFRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new ASYNBATCHTRSFRTRN_RQBODY
                    {
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        BIZTYPE = 1,
                        PURPOSE = "异步批量支付",
                    }
                }
            };
            var txt = new ASYNBATCHTRSFRTRNRQ_XFERINFOTEXT();
            var list = new List<PayeeInfo_3_4_12>();
            for (byte i = 0; i < 4; i++)
            {
                var acct = GetACCTTO(i);
                var info = new PayeeInfo_3_4_12
                {
                    Account = acct.ACCTID,
                    Name = acct.NAME,
                    IsCIB = acct.INTERBANK[0],
                    IsSameCity = acct.LOCAL[0],
                    BankCode = acct.BANKNUM,
                    BankName = acct.BANKDESC,
                    Address = acct.CITY,
                    Amount = i + 2.3m,
                    Purpose = "异步>批量" + i,
                };
                list.Add(info);
            }
            txt.SetList(list);
            rq.SECURITIES_MSGSRQV1.ASYNBATCHTRSFRTRNRQ.RQBODY.XFERINFOTEXT = txt;
            //rq.SECURITIES_MSGSRQV1.ASYNBATCHTRSFRTRNRQ.TRNUID = "20190117200215_3.4.12";//直接测试历史记录
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
            if (rs.SECURITIES_MSGSRSV1.ASYNBATCHTRSFRTRNRS.RSBODY.XFERINFOTEXT != null)
            {
                var rList = rs.SECURITIES_MSGSRSV1.ASYNBATCHTRSFRTRNRS.RSBODY.XFERINFOTEXT.GetList();
            }
        }
        #endregion

        #region 3.5	证券交易
        /// <summary>
        /// 3.5.1	证券资金清算汇划
        /// </summary>
        public static void STOCKTRSFRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STOCKTRSFRTRNRQ, V1_STOCKTRSFRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STOCKTRSFRTRNRQ
            {
                STOCKTRSFRTRNRQ = new STOCKTRSFRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STOCKTRSFRTRN_RQBODY
                    {
                        ACCTFROM = new ACCT
                        {
                            ACCTID = mainAccountId,
                        },
                        ACCTTO = new RQACCT
                        {
                            ACCTID = "337010100100219872",
                        },
                        TRNAMT = 1000,
                        SUMM = "B001999906WXFXCDABCD",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.2	证券资金清算汇划查询
        /// </summary>
        public static void STOCKQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STOCKQUERYTRNRQ, V1_STOCKQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STOCKQUERYTRNRQ
            {
                STOCKQUERYTRNRQ = new STOCKQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STOCKQUERYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        CLIENTREF = "20190307191314_3.5.1",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.3	第三方存管签约查询
        /// </summary>
        public static void TPCONTRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TPCONTRTRNRQ, V1_TPCONTRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TPCONTRTRNRQ
            {
                TPCONTRTRNRQ = new TPCONTRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new TPCONTRTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        TRUSTEETYPE= "BANK_TRUSTEE",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.4	第三方存管银证资金互转
        /// </summary>
        public static void TPFUNDEXCHANGETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TPFUNDEXCHANGETRNRQ, V1_TPFUNDEXCHANGETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TPFUNDEXCHANGETRNRQ
            {
                TPFUNDEXCHANGETRNRQ = new TPFUNDEXCHANGETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new TPFUNDEXCHANGETRN_RQBODY
                    {
                        //VERSION = "2.0",
                        //TRUSTEETYPE = "2",
                        //STCOKBRANCHCODE = "10050000",
                        ACCTID = mainAccountId,
                        PWD = "111111",
                        TRNTYPE = 0,
                        TRNAMT = 1300,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.5	第三方存管交易查询
        /// </summary>
        public static void TPTRSFRQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TPTRSFRQUERYTRNRQ, V1_TPTRSFRQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TPTRSFRQUERYTRNRQ
            {
                TPTRSFRQUERYTRNRQ = new TPTRSFRQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new TPTRSFRQUERYTRN_RQBODY
                    {
                        TRUSTEETYPE = "2",
                        ACCTID = mainAccountId,
                        OPERTYPE = 1,
                        DTSTART = DateTime.Now.AddMonths(-6),
                        DTEND = DateTime.Now.AddMonths(-3),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.6	第三方存管资金查询
        /// </summary>
        public static void TPFUNDQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TPFUNDQUERYTRNRQ, V1_TPFUNDQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TPFUNDQUERYTRNRQ
            {
                TPFUNDQUERYTRNRQ = new TPFUNDQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new TPFUNDQUERYTRN_RQBODY
                    {
                        //VERSION = "2.0",
                        //TRUSTEETYPE = "2",
                        //STCOKBRANCHCODE = "10050000",
                        ACCTID = mainAccountId,
                        PWD = "111111",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.7	银期互转
        /// </summary>
        public static void BFEEXCHANGETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BFEEXCHANGETRNRQ, V1_BFEEXCHANGETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BFEEXCHANGETRNRQ
            {
                BFEEXCHANGETRNRQ = new BFEEXCHANGETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new BFEEXCHANGETRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        ACCTPWD = "111111",
                        TRANSFERTYPE = 1,
                        FUNDACCTNO = "2016011902",
                        TRANSFERAMT = 110.5m,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.8	银期资金查询
        /// </summary>
        public static void QFUNDACCTINFOTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QFUNDACCTINFOTRNRQ, V1_QFUNDACCTINFOTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QFUNDACCTINFOTRNRQ
            {
                QFUNDACCTINFOTRNRQ = new QFUNDACCTINFOTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QFUNDACCTINFOTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        FUNDACCTNO = "2016011902",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.9	银期交易明细查询
        /// </summary>
        public static void QBFDETAILTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QBFDETAILTRNRQ, V1_QBFDETAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QBFDETAILTRNRQ
            {
                QBFDETAILTRNRQ = new QBFDETAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QBFDETAILTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        FUNDACCTNO = "2016011902",
                        STARTDATE = DateTime.Now.AddDays(-360),
                        ENDDATE = DateTime.Now.AddDays(-3),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.10	期权现货互转
        /// </summary>
        public static void CREATEOPTIONSPOTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CREATEOPTIONSPOTTRNRQ, V1_CREATEOPTIONSPOTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CREATEOPTIONSPOTTRNRQ
            {
                CREATEOPTIONSPOTTRNRQ = new CREATEOPTIONSPOTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CREATEOPTIONSPOTTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        TRANSFERTYPE = 0,
                        FUNDACCTNO = "2016011902",
                        TRANSFERAMT = 100,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.11	期权现货资金查询
        /// </summary>
        public static void QUERYOPTIONSPOTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYOPTIONSPOTTRNRQ, V1_QUERYOPTIONSPOTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYOPTIONSPOTTRNRQ
            {
                QUERYOPTIONSPOTTRNRQ = new QUERYOPTIONSPOTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYOPTIONSPOTTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        FUNDACCTNO = "2016011902",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.12	期权现货交易明细查询
        /// </summary>
        public static void OPTIONSPOTDETAILTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_OPTIONSPOTDETAILTRNRQ, V1_OPTIONSPOTDETAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_OPTIONSPOTDETAILTRNRQ
            {
                OPTIONSPOTDETAILTRNRQ = new OPTIONSPOTDETAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new OPTIONSPOTDETAILTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        FUNDACCTNO = "2016011902",
                        STARTDATE = DateTime.Now.AddDays(-360),
                        ENDDATE = DateTime.Now.AddDays(-3),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.5.13	证券交易类指令查询
        /// </summary>
        public static void QUERYTRADECOMMANDTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.5.13", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYTRADECOMMANDTRNRQ, V1_QUERYTRADECOMMANDTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYTRADECOMMANDTRNRQ
            {
                QUERYTRADECOMMANDTRNRQ = new QUERYTRADECOMMANDTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYTRADECOMMANDTRN_RQBODY
                    {
                        CLIENTREF = "20190307193528_3.5.4",
                        BUSINESSTYPE = 0
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.6	虚拟子账户
        /// <summary>
        /// 3.6.1	虚拟主账户签约解约
        /// </summary>
        public static void VSASIGNTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSASIGNTRNRQ, V1_VSASIGNTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSASIGNTRNRQ
            {
                VSASIGNTRNRQ = new VSASIGNTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new VSASIGNTRN_RQBODY
                    {
                        MAINACCT = mainAccountId,
                        SIGNFLG = "Y"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.2	虚拟子账户批量开户（最多20笔）
        /// </summary>
        public static void VSABATCHOPENTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSABATCHOPENTRNRQ, V1_VSABATCHOPENTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSABATCHOPENTRNRQ
            {
                VSABATCHOPENTRNRQ = new VSABATCHOPENTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new VSABATCHOPENTRN_RQBODY
                    {
                        MAINACCT = mainAccountId,
                        List = new List<VSAOPENINFORQ>
                        {
                             new VSAOPENINFORQ{
                                 SUBACCT ="980000",
                                 SUBNAME ="虚拟子账户1",
                                 BUDGETQUOTA =1000.0m,
                                 BUDGETCYCLE =6,
                                 BUDGETIDENT =1,
                                 RATEPOINTFLTVAL =0.0m,
                                 RATESCALEFLTVAL =0.0m,
                             },
                             new VSAOPENINFORQ{
                                 SUBACCT ="980001",
                                 SUBNAME ="虚拟子账户2",
                                 BUDGETQUOTA =20.0m,
                                 BUDGETCYCLE =3,
                                 BUDGETIDENT =0,
                                 RATEPOINTFLTVAL =0.0m,
                                 RATESCALEFLTVAL =0.0m,
                                 FIRADJINTSDATE = DateTime.Now,
                             }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.3	虚拟子账户信息查询
        /// </summary>
        public static void VSASUBACCTINFOTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSASUBACCTINFOTRNRQ, V1_VSASUBACCTINFOTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSASUBACCTINFOTRNRQ
            {
                VSASUBACCTINFOTRNRQ = new VSASUBACCTINFOTRNRQ
                {
                    TRNUID = tid,
                    INQUIRYINFO = new VSASUBACCTINFOTRN_INQUIRYINFO
                    {
                        MAINACCT = mainAccountId,
                        PATTERN = "1",
                        SUBACCT = "010003"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.4	虚拟子账户利息分配
        /// </summary>
        public static void VSAALLOTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSAALLOTTRNRQ, V1_VSAALLOTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSAALLOTTRNRQ
            {
                VSAALLOTTRNRQ = new VSAALLOTTRNRQ
                {
                    TRNUID = tid,
                    INQUIRYINFO = new VSAALLOTTRN_INQUIRYINFO
                    {
                        MAINACCT = mainAccountId,
                        PATTERN = "1",
                        SUBACCT = "0003"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.5	虚拟子帐户对外支付
        /// </summary>
        public static void VATTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VATTRNRQ, V1_VATTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VATTRNRQ
            {
                VATTRNRQ = new VATTRNRQ
                {
                    TRNUID = tid,
                    VATRQ = new VATRQ
                    {
                        MAINACCT = mainAccountId,
                        SUBACCT = "010003",
                        XFERINFO = new XFERINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId,
                                NAME = mainAccountName
                            },
                            ACCTTO = GetACCTTO(3),
                            PURPOSE = "虚拟子帐户对外支付",
                            TRNAMT = 0.77m,
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.6	虚拟子账户余额及交易明细查询
        /// 3.14.4	代理支付余额及交易明细查询
        /// </summary>
        public static void VATSTMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VATSTMTTRNRQ, V1_VATSTMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VATSTMTTRNRQ
            {
                VATSTMTTRNRQ = new VATSTMTTRNRQ
                {
                    TRNUID = tid,
                    VATSTMTRQ = new VATSTMTRQ
                    {
                        MAINACCT = mainAccountId,
                        SUBACCT = "010003",
                        VATTYPE = 0,
                        ACCTFROM = new ACCTFROM
                        {
                            //ACCTID = mainAccountId
                            ACCTID = "00-10-0001-1",
                        },
                        INCTRAN = new VATSTMTRQ_INCTRAN
                        {
                            DTEND = DateTime.Now,
                            DTSTART = DateTime.Now,
                            PAGE = 1,
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.7	虚拟子账户内部转账
        /// </summary>
        public static void VSAINTRSFTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSAINTRSFTRNRQ, V1_VSAINTRSFTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSAINTRSFTRNRQ
            {
                VSAINTRSFTRNRQ = new VSAINTRSFTRNRQ
                {
                    TRNUID = tid,
                    VSAINTRSFRQ = new VSAINTRSFRQ
                    {
                        MAINACCT = mainAccountId,
                        SUBACCT = "010003",
                        TOSUBACCT = "010004",
                        PURPOSE = "虚拟子账户内部转账",
                        TRNAMT = 3.97m,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.6.8	虚拟子账户删除
        /// </summary>
        public static void VSACANCELTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.6.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VSACANCELTRNRQ, V1_VSACANCELTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VSACANCELTRNRQ
            {
                VSACANCELTRNRQ = new VSACANCELTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new VSACANCELTRN_RQBODY
                    {
                        MAINACCT = mainAccountId,
                        SUBACCT = "010003",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.7	集团服务
        /// <summary>
        /// 3.7.1	集团支付
        /// </summary>
        public static void XPMTTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_XPMTTRNRQ, V1_XPMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_XPMTTRNRQ
            {
                XPMTTRNRQ = new XPMTTRNRQ
                {
                    TRNUID = tid,
                    XMPTRQ = new XMPTRQ<XPMTTRN_FUNDACCT>
                    {
                        FUNDACCT = new XPMTTRN_FUNDACCT
                        {
                            ACCTID = mainAccountId,
                            XPMTTYPE = 0,
                        },
                        XFERINFO = new XFERINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId,
                            },
                            ACCTTO = GetACCTTO(3),
                            TRNAMT = 7.7m,
                            PURPOSE = "集团支付",
                            DTDUE = DateTime.Now,
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.2	成员交易明细查询
        /// </summary>
        public static void CMSTMTQUERYTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMSTMTQUERYTRNRQ, V1_CMSTMTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMSTMTQUERYTRNRQ
            {
                CMSTMTQUERYTRNRQ = new CMSTMTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMSTMTQUERYTRN_RQBODY
                    {
                        FUNDACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                        MBRACCT = new RQACCT
                        {
                            ACCTID = "117010100100050880"
                        },
                        DTEND = DateTime.Now.AddDays(-1),
                        DTSTART = DateTime.Now.AddDays(-2)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.3	成员账户查询
        /// </summary>
        public static void CMMBRQUERYTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMMBRQUERYTRNRQ, V1_CMMBRQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMMBRQUERYTRNRQ
            {
                CMMBRQUERYTRNRQ = new CMMBRQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMMBRQUERYTRN_RQBODY
                    {
                        FUNDACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.4	历史留存金额查询
        /// </summary>
        public static void CMHISBLNCTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMHISBLNCTRNRQ, V1_CMHISBLNCTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMHISBLNCTRNRQ
            {
                CMHISBLNCTRNRQ = new CMHISBLNCTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMHISBLNCTRN_RQBODY
                    {
                        FUNDACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                        MBRACCT = new RQACCT
                        {
                            ACCTID = "117010100100050880"
                        },
                        DTEND = DateTime.Now.AddDays(-1),
                        DTSTART = DateTime.Now.AddMonths(-11),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.5	内部往来查询
        /// </summary>
        public static void CMINNERQUERYTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMINNERQUERYTRNRQ, V1_CMINNERQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMINNERQUERYTRNRQ
            {
                CMINNERQUERYTRNRQ = new CMINNERQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMINNERQUERYTRN_RQBODY
                    {
                        FUNDACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                        MBRACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.6	归集调拨查询
        /// </summary>
        public static void CMTRANSDETAILTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMTRANSDETAILTRNRQ, V1_CMTRANSDETAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMTRANSDETAILTRNRQ
            {
                CMTRANSDETAILTRNRQ = new CMTRANSDETAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMTRANSDETAILTRN_RQBODY
                    {
                        ACCTID = "117010100100050880",
                        DTEND = DateTime.Now.AddDays(-1),
                        DTSTART = DateTime.Now.AddDays(-5)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.7	查询成员外部收支明细
        /// </summary>
        public static void CMMEMSTMTQUERYTRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMMEMSTMTQUERYTRNRQ, V1_CMMEMSTMTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMMEMSTMTQUERYTRNRQ
            {
                CMMEMSTMTQUERYTRNRQ = new CMMEMSTMTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMMEMSTMTQUERYTRN_RQBODY
                    {
                        MBRACCT = new RQACCT
                        {
                            ACCTID = "117010100100050880"
                        },
                        DTEND = DateTime.Now.AddDays(-1),
                        DTSTART = DateTime.Now.AddDays(-5)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.7.8	账户可用额度查询
        /// </summary>
        public static void CMAVBLQUOTATRNRQSimple()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.7.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CMAVBLQUOTATRNRQ, V1_CMAVBLQUOTATRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CMAVBLQUOTATRNRQ
            {
                CMAVBLQUOTATRNRQ = new CMAVBLQUOTATRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CMAVBLQUOTATRN_RQBODY
                    {
                        FUNDACCT = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                        ACCTID = "117010100100050880"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.8	理财产品投资
        /// <summary>
        /// 3.8.1	认购/申购/撤销购买
        /// </summary>
        public static void FPPURCHTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPPURCHTRNRQ, V1_FPPURCHTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPPURCHTRNRQ
            {
                FPPURCHTRNRQ = new FPPURCHTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPPURCHTRN_RQBODY
                    {
                        PRODNO = "F01SJYH1",
                        ACCTID = mainAccountId,
                        MOBILE = "15100006666",
                        ADDR = "福建",
                        TRNAMT = 1000.0m,
                        TRNTYPE = 0,
                        ZIP = "353000"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.2	赎回/撤销赎回功能
        /// </summary>
        public static void FPREDMTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPREDMTRNRQ, V1_FPREDMTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPREDMTRNRQ
            {
                FPREDMTRNRQ = new FPREDMTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPREDMTRN_RQBODY
                    {
                        PRODNO = "F01SJYH1",
                        ACCTID = mainAccountId,
                        TRNTYPE = 0,
                        REDMAMT = 30.0m,
                        ACCEPTNO = "1170120000000395"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.3	理财产品信息查询
        /// </summary>
        public static void FPPRODTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPPRODTRNRQ, V1_FPPRODTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPPRODTRNRQ
            {
                FPPRODTRNRQ = new FPPRODTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPPRODTRN_RQBODY
                    {
                         PAGE=2
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.4	理财产品说明书及协议查询
        /// </summary>
        public static void FPAGMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPAGMTTRNRQ, V1_FPAGMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPAGMTTRNRQ
            {
                FPAGMTTRNRQ = new FPAGMTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPAGMTTRN_RQBODY
                    {
                        PRODNO = "F01SJYH1",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.5	客户理财资产信息查询
        /// </summary>
        public static void FPASSETSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPASSETSTRNRQ, V1_FPASSETSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPASSETSTRNRQ
            {
                FPASSETSTRNRQ = new FPASSETSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPASSETSTRN_RQBODY
                    {
                        TRNTYPE = 2,
                        ACCTID = mainAccountId,
                        DTSTART = new DateTime(2018,5,10),
                        DTEND = new DateTime(2018, 6, 5)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.6	客户信息查询
        /// </summary>
        public static void FPCUSTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPCUSTTRNRQ, V1_FPCUSTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPCUSTTRNRQ
            {
                FPCUSTTRNRQ = new FPCUSTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.7	理财产品签约-解约请求
        /// </summary>
        public static void FPAGMTSIGNTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPAGMTSIGNTRNRQ, V1_FPAGMTSIGNTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPAGMTSIGNTRNRQ
            {
                FPAGMTSIGNTRNRQ = new FPAGMTSIGNTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPAGMTSIGNTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        PRODNO = "F01SJYH1",
                        AGRM = "CIBLCCP184",
                        SIGNFLG = "Y"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.8.8	理财产品签约状态查询请求
        /// </summary>
        public static void FPAGMTSTATUSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.8.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_FPAGMTSTATUSTRNRQ, V1_FPAGMTSTATUSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_FPAGMTSTATUSTRNRQ
            {
                FPAGMTSTATUSTRNRQ = new FPAGMTSTATUSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new FPAGMTSTATUSTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        PRODNO = "F01SJYH1",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.9	电子商业汇票系统
        /// <summary>
        /// 3.9.1.1 票据交易明细查询
        /// </summary>
        public static void EBSTMTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBSTMTQUERYTRNRQ, V1_EBSTMTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBSTMTQUERYTRNRQ
            {
                EBSTMTQUERYTRNRQ = new EBSTMTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBSTMTQUERYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        BUSINESSTYPE = "99",
                        OPERTYPE = "04",
                        DTSTART = DateTime.Now.AddMonths(-3),
                        DTEND = DateTime.Now.AddDays(-4)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.2 可操作票据查询
        /// </summary>
        public static void EBOPRNQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBOPRNQUERYTRNRQ, V1_EBOPRNQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBOPRNQUERYTRNRQ
            {
                EBOPRNQUERYTRNRQ = new EBOPRNQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBOPRNQUERYTRN_RQBODY
                    {
                        BUSINESSTYPE = "99",
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.3 待签收票据查询
        /// </summary>
        public static void EBSIGNQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBSIGNQUERYTRNRQ, V1_EBSIGNQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBSIGNQUERYTRNRQ
            {
                EBSIGNQUERYTRNRQ = new EBSIGNQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBSIGNQUERYTRN_RQBODY
                    {
                        BUSINESSTYPE = "99",
                        ACCTID = mainAccountId,
                        BILLTYPE = "AC01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.4 票据正面信息查询
        /// </summary>
        public static void EBFACEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBFACEQUERYTRNRQ, V1_EBFACEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBFACEQUERYTRNRQ
            {
                EBFACEQUERYTRNRQ = new EBFACEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBFACEQUERYTRN_RQBODY
                    {
                        BILLCODE= "100293847500000020120507154253",
                        ACCTID = "117010101400120757",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.5 票据基本信息查询
        /// </summary>
        public static void EBBASEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBBASEQUERYTRNRQ, V1_EBBASEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBBASEQUERYTRNRQ
            {
                EBBASEQUERYTRNRQ = new EBBASEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBBASEQUERYTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        BIZ = "99",
                        BILLTYPE = "AC01",
                        QUERYERTYPE = "01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.6 票据流转信息查询
        /// </summary>
        public static void EBBACKQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBBACKQUERYTRNRQ, V1_EBBACKQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBBACKQUERYTRNRQ
            {
                EBBACKQUERYTRNRQ = new EBBACKQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBBACKQUERYTRN_RQBODY
                    {
                        BILLCODE= "100293847500000020120507154253",
                        ACCTID = "117010101400120757",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.7 支付信用信息查询
        /// </summary>
        public static void EBCRDQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBCRDQUERYTRNRQ, V1_EBCRDQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBCRDQUERYTRNRQ
            {
                EBCRDQUERYTRNRQ = new EBCRDQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBCRDQUERYTRN_RQBODY
                    {
                        BILLCODE = "100293847500000020120507154253",
                        BILLAMT = 2222,
                        ACCTID = "117010101400120757",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.8 可追索人查询
        /// </summary>
        public static void EBRECRQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBRECRQUERYTRNRQ, V1_EBRECRQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBRECRQUERYTRNRQ
            {
                EBRECRQUERYTRNRQ = new EBRECRQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBRECRQUERYTRN_RQBODY
                    {
                        BILLCODE = "100293847500000020120507154253",
                        ACCTID = "117010101400120757",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.9 票据批量状态查询
        /// </summary>
        public static void EBBATCHSTATUSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBBATCHSTATUSTRNRQ, V1_EBBATCHSTATUSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBBATCHSTATUSTRNRQ
            {
                EBBATCHSTATUSTRNRQ = new EBBATCHSTATUSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBBATCHSTATUSTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        CLIENTREF= "20120412cx12",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.10 实付金额查询
        /// </summary>
        public static void EBREALPAYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBREALPAYTRNRQ, V1_EBREALPAYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBREALPAYTRNRQ
            {
                EBREALPAYTRNRQ = new EBREALPAYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBREALPAYTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        List = new List<EBREALPAYTRNRQ_CONTENT>
                        {
                            new EBREALPAYTRNRQ_CONTENT
                            {
                                INDX=1,
                                BILLTYPE="AC01",
                                DISCNTTYPE="RM00",
                                BILLAMT=1000,
                                DTSTART=DateTime.Now,
                                DTEND=DateTime.Now,
                                INTRST=3.2m,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.11 待付款银票查询请求
        /// </summary>
        public static void EBPAYQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPAYQUERYTRNRQ, V1_EBPAYQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPAYQUERYTRNRQ
            {
                EBPAYQUERYTRNRQ = new EBPAYQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPAYQUERYTRN_RQBODY
                    {
                        KIND = 2,
                        ACCTID = "117010101400120757",
                        STATUS = "00",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.12 代保管纸质票据查询请求
        /// </summary>
        public static void EBPAPERQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPAPERQUERYTRNRQ, V1_EBPAPERQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPAPERQUERYTRNRQ
            {
                EBPAPERQUERYTRNRQ = new EBPAPERQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPAPERQUERYTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        BIZ = 1,
                        BILLTYPE = "AC01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.1.13 自动提示付款结果查询
        /// </summary>
        public static void EBAUTOCLUEPAYQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.1.13", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBAUTOCLUEPAYQUERYTRNRQ, V1_EBAUTOCLUEPAYQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBAUTOCLUEPAYQUERYTRNRQ
            {
                EBAUTOCLUEPAYQUERYTRNRQ = new EBAUTOCLUEPAYQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBAUTOCLUEPAYQUERYTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }


        /// <summary>
        /// 3.9.2.1 出票申请/出票信息登记
        /// </summary>
        public static void EBDRAWTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBDRAWTRNRQ, V1_EBDRAWTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBDRAWTRNRQ
            {
                EBDRAWTRNRQ = new EBDRAWTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBDRAWTRN_RQBODY
                    {
                        TYPE = "01",
                        BILLTYPE = "AC01",
                        DRAWACCTID = "117010101400120757",
                        List = new List<EBDRAWTRN_CONTENT>
                        {
                            new EBDRAWTRN_CONTENT{
                                INDX=1,
                                BILLAMT=1000,
                                DRAWDATE=DateTime.Now,
                                DUEDATE=DateTime.Now.AddMonths(1),
                                NEGTBL="EM00",
                                ISCIB="Y",
                                PAYEEACCT=new CORRELATEACCT{
                                    ACCTID="117010101400120757",
                                    NAME="test",
                                    BANKNUM="309391000095",
                                },
                                ACACCT=new CORRELATEACCT{
                                    ACCTID ="117010101400120757",
                                    NAME ="test",
                                    BANKNUM="309391000095",
                                },
                                ENTRSPAY="CC00",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.2 通用保证申请
        /// </summary>
        public static void EBGUARNTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBGUARNTTRNRQ, V1_EBGUARNTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBGUARNTTRNRQ
            {
                EBGUARNTTRNRQ = new EBGUARNTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBGUARNTTRN_RQBODY
                    {
                        GUARNTTYPE = "02",
                        APPDATE = DateTime.Now,
                        APPACCTID = "117010101400120757",
                        ISCIB = "Y",
                        GUARNTRACCT = new CORRELATEACCT
                        {
                            ACCTID = "117010101400120757",
                            NAME = "test",
                            BANKNUM = "309391000095",
                        },
                        List = new List<EBGUARNTTRN_CONTENT>
                        {
                            new EBGUARNTTRN_CONTENT
                            {
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=1000,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.3 提示承兑申请
        /// </summary>
        public static void EBACPTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBACPTTRNRQ, V1_EBACPTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBACPTTRNRQ
            {
                EBACPTTRNRQ = new EBACPTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBACPTTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        BILLTYPE = "AC01",
                        List = new List<EBACPTTRN_CONTENT> {
                            new EBACPTTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                ENTRSPAY="CC00",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.4 提示收票申请
        /// </summary>
        public static void EBCOLLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBCOLLTRNRQ, V1_EBCOLLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBCOLLTRNRQ
            {
                EBCOLLTRNRQ = new EBCOLLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBCOLLTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        BILLTYPE = "AC01",
                        List = new List<EBCOLLTRN_CONTENT> {
                            new EBCOLLTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.5 撤票申请
        /// </summary>
        public static void EBCANCLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBCANCLTRNRQ, V1_EBCANCLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBCANCLTRNRQ
            {
                EBCANCLTRNRQ = new EBCANCLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBCANCLTRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        BILLTYPE = "AC01",
                        List = new List<EBCANCLTRN_CONTENT> {
                            new EBCANCLTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.6 背书转让申请
        /// </summary>
        public static void EBENDRSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBENDRSTRNRQ, V1_EBENDRSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBENDRSTRNRQ
            {
                EBENDRSTRNRQ = new EBENDRSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBENDRSTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        BILLTYPE = "AC01",
                        ENDRSRACCTID = "117010101400120757",
                        ENDRSEISCIB = "Y",
                        ENDRSEACCT = new CORRELATEACCT
                        {
                            ACCTID = "117010101400120757",
                            NAME = "test",
                            BANKNUM = "309391000095",
                        },
                        NEGTBL = "EM00",
                        List = new List<EBENDRSTRN_CONTENT> {
                            new EBENDRSTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.7 贴现申请/转贴现申请/再贴现申请
        /// </summary>
        public static void EBDISCNTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBDISCNTTRNRQ, V1_EBDISCNTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBDISCNTTRNRQ
            {
                EBDISCNTTRNRQ = new EBDISCNTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBDISCNTTRN_RQBODY
                    {
                        TRADETYPE="TT00",
                        APPDATE = DateTime.Now,
                        BILLTYPE = "AC01",
                        ACCTFROM=new ACCT {
                            ACCTID = "117010101400120757",
                            NAME = "test",
                        },
                        ISCIB="Y",
                        ACCTTO = new CORRELATEACCT
                        {
                            ACCTID = "117010101400120757",
                            NAME = "test",
                            BANKNUM = "309391000095",
                        },
                        DISCNTTYPE= "RM00",
                        INTRSTRATE=11.2m,
                        NEGTBL = "EM00",
                        LQMODE= "SM00",
                        List = new List<EBDISCNTTRN_CONTENT> {
                            new EBDISCNTTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                REALPAY=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.8 贴现赎回/转贴现赎回
        /// </summary>
        public static void EBREDMTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBREDMTRNRQ, V1_EBREDMTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBREDMTRNRQ
            {
                EBREDMTRNRQ = new EBREDMTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBREDMTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        APPACCTID= "117010101400120757",
                        REDMTYPE= "DT00",
                        INTRSTRATE=1.1m,
                        BILLTYPE = "AC01",
                        NEGTBL = "EM00",
                        LQMODE = "SM00",
                        List = new List<EBREDMTRN_CONTENT> {
                            new EBREDMTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                REALPAY=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.9 质押申请
        /// </summary>
        public static void EBIMPAWNTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBIMPAWNTRNRQ, V1_EBIMPAWNTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBIMPAWNTRNRQ
            {
                EBIMPAWNTRNRQ = new EBIMPAWNTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBIMPAWNTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        ACCTFROM=new RQACCT {
                            ACCTID= "117010101400120757",
                        },
                        BILLTYPE = "AC01",
                        ISCIB = "Y",
                        ACCTTO = new CORRELATEACCT {
                            ACCTID = "117010101400120757",
                            NAME = "test",
                            BANKNUM = "309391000095",
                        },
                        List = new List<EBIMPAWNTRN_CONTENT> {
                            new EBIMPAWNTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.10 质押解除申请
        /// </summary>
        public static void EBIMPAWNCANCLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBIMPAWNCANCLTRNRQ, V1_EBIMPAWNCANCLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBIMPAWNCANCLTRNRQ
            {
                EBIMPAWNCANCLTRNRQ = new EBIMPAWNCANCLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBIMPAWNCANCLTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        ACCTID = "117010101400120757",
                        BILLTYPE = "AC01",
                        List = new List<EBIMPAWNCANCLTRN_CONTENT> {
                            new EBIMPAWNCANCLTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.11 提示付款申请
        /// </summary>
        public static void EBCUEPAYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBCUEPAYTRNRQ, V1_EBCUEPAYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBCUEPAYTRNRQ
            {
                EBCUEPAYTRNRQ = new EBCUEPAYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBCUEPAYTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        ACCTID = "117010101400120757",
                        CUETYPE = "01",
                        BILLTYPE = "AC01",
                        LQMODE = "SM00",
                        List = new List<EBCUEPAYTRN_CONTENT> {
                            new EBCUEPAYTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                CUEAMT=100,
                                AGENTFLAG="PP01",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.12 追索通知申请
        /// </summary>
        public static void EBRECRSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBRECRSTRNRQ, V1_EBRECRSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBRECRSTRNRQ
            {
                EBRECRSTRNRQ = new EBRECRSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBRECRSTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        ACCTFROM = new RQACCT
                        {
                            ACCTID = "117010101400120757",
                        },
                        RECRSTYPE = "RT00",
                        RECRSAMT = 1000,
                        ACCTTO = new ORGACCT
                        {
                            ACCTID = "0333",
                            NAME = "上海中石化公司",
                            BANKNUM = "999999999999",
                            ORGID = "99999999-9"
                        },
                        INDX = 1,
                        BILLCODE = "100293847500000020120507154253",
                        BILLAMT = 100,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.13 同意清偿通知申请
        /// </summary>
        public static void EBDISCHGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.13", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBDISCHGTRNRQ, V1_EBDISCHGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBDISCHGTRNRQ
            {
                EBDISCHGTRNRQ = new EBDISCHGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBDISCHGTRN_RQBODY
                    {
                        APPDATE = DateTime.Now,
                        ACCTID = "117010101400120757",
                        List = new List<EBDISCHGTRN_CONTENT> {
                            new EBDISCHGTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                DISCHGAMT=100,
                                BIZFLAG="9668",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.14 通用撤回请求
        /// </summary>
        public static void EBRECEDETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.14", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBRECEDETRNRQ, V1_EBRECEDETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBRECEDETRNRQ
            {
                EBRECEDETRNRQ = new EBRECEDETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBRECEDETRN_RQBODY
                    {
                        ACCTID = "117010101400120757",
                        List = new List<EBRECEDETRN_CONTENT> {
                            new EBRECEDETRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                BUSINESSTYPE="17",
                                BIZFLAG="9668",
                                SEQ="00000000000000037932",
                                APPDATE= DateTime.Now
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.2.15 通用签收/拒签请求
        /// </summary>
        public static void EBSIGNTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.2.15", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBSIGNTRNRQ, V1_EBSIGNTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBSIGNTRNRQ
            {
                EBSIGNTRNRQ = new EBSIGNTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBSIGNTRN_RQBODY
                    {
                        SIGNDATE=DateTime.Now,
                        ACCTID = "117010101400120757",
                        SIGNRSLT= "SU00",
                        List = new List<EBSIGNTRN_CONTENT> {
                            new EBSIGNTRN_CONTENT{
                                INDX=1,
                                BILLCODE="100293847500000020120507154253",
                                BILLAMT=100,
                                BUSINESSTYPE="17",
                                ENTRSPAY="CC00",
                                BIZFLAG="9668",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }


        /// <summary>
        /// 3.9.3.1 票据入池
        /// </summary>
        public static void EBPINPOOLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPINPOOLTRNRQ, V1_EBPINPOOLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPINPOOLTRNRQ
            {
                EBPINPOOLTRNRQ = new EBPINPOOLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPINPOOLTRN_RQBODY
                    {
                        INPOOLTYPE = "01",
                        List = new List<EBPINPOOLTRN_CONTENT> {
                            new EBPINPOOLTRN_CONTENT{
                                INDX=1,
                                BILLCODE="201607220000000000000000000000",
                                BILLAMT=100,
                                BILLTYPE="AC01",
                                OUTDATE= DateTime.Now,
                                DUEDATE= DateTime.Now.AddDays(3),
                                DRAWERNAME="zhengxh",
                                DRAWERACCTNO="622908363000570115",
                                DRAWERBANKNAME="bank01",
                                DRAWERBANKCODE="bank01",
                                PAYEENAME="zhengxh",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.2 票据出池
        /// </summary>
        public static void EBPOUTPOOLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPOUTPOOLTRNRQ, V1_EBPOUTPOOLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPOUTPOOLTRNRQ
            {
                EBPOUTPOOLTRNRQ = new EBPOUTPOOLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPOUTPOOLTRN_RQBODY
                    {
                        OUTPOOLTYPE = "01",
                        List = new List<EBPOUTPOOLTRN_CONTENT> {
                            new EBPOUTPOOLTRN_CONTENT{
                                INDX=1,
                                BIZNO="1223210000",
                                BELONGORGNO="122321",
                                BILLCODE="201607220000000000000000000000",
                                BILLAMT=100,
                                BILLTYPE="AC01",
                                OUTDATE= DateTime.Now,
                                DUEDATE= DateTime.Now.AddDays(3),
                                DRAWERNAME="zhengxh",
                                DRAWERACCTNO="622908363000570115",
                                DRAWERBANKNAME="bank01",
                                DRAWERBANKCODE="bank01",
                                PAYEENAME="zhengxh",
                                PAYEEACCTNO="622908363000570115",
                                PAYEEBANKNAME="bank01",
                                PAYEEBANKCODE="bank01",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.3 质押托管转换
        /// </summary>
        public static void EBPCONVERTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCONVERTTRNRQ, V1_EBPCONVERTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCONVERTTRNRQ
            {
                EBPCONVERTTRNRQ = new EBPCONVERTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCONVERTTRN_RQBODY
                    {
                        CONVERTTYPE = 1,
                        List = new List<EBPCONVERTTRN_CONTENT> {
                            new EBPCONVERTTRN_CONTENT{
                                INDX=1,
                                BIZNO="1223210000",
                                BELONGORGNO="122321",
                                BILLCODE="201607220000000000000000000000",
                                BILLAMT=100,
                                BILLTYPE="AC01",
                                OUTDATE= DateTime.Now,
                                DUEDATE= DateTime.Now.AddDays(3),
                                DRAWERNAME="zhengxh",
                                DRAWERACCTNO="622908363000570115",
                                DRAWERBANKNAME="bank01",
                                DRAWERBANKCODE="bank01",
                                PAYEENAME="zhengxh",
                                PAYEEACCTNO="622908363000570115",
                                PAYEEBANKNAME="bank01",
                                PAYEEBANKCODE="bank01",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.4 出票申请
        /// </summary>
        public static void EBPOUTBILLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPOUTBILLTRNRQ, V1_EBPOUTBILLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPOUTBILLTRNRQ
            {
                EBPOUTBILLTRNRQ = new EBPOUTBILLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPOUTBILLTRN_RQBODY
                    {
                        List = new List<EBPOUTBILLTRN_CONTENT> {
                            new EBPOUTBILLTRN_CONTENT{
                                INDX=1,
                                BILLAMT=100,
                                BILLTYPE="AC01",
                                OUTDATE= DateTime.Now,
                                DUEDATE= DateTime.Now.AddDays(3),
                                PAYEENAME="zhengxh",
                                PAYEEACCTNO="622908363000570115",
                                PAYEEBANKNAME="bank01",
                                PAYEEBANKCODE="bank01",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.5 融资申请
        /// </summary>
        public static void EBPFINANCINGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPFINANCINGTRNRQ, V1_EBPFINANCINGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPFINANCINGTRNRQ
            {
                EBPFINANCINGTRNRQ = new EBPFINANCINGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPFINANCINGTRN_RQBODY
                    {
                        DUEDATE = DateTime.Now.AddMonths(3),
                        FINANCINGTYPE = "01",
                        LIMITUSETYPE = 1,
                        FINANCINGAMT = 1000000,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.6 贴现申请
        /// </summary>
        public static void EBPCASHTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCASHTRNRQ, V1_EBPCASHTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCASHTRNRQ
            {
                EBPCASHTRNRQ = new EBPCASHTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCASHTRN_RQBODY
                    {
                        List = new List<EBPCASHTRN_CONTENT> {
                            new EBPCASHTRN_CONTENT{
                                INDX =1,
                                BIZNO="1223210000",
                                BELONGORGNO="122321",
                                BILLCODE="201607220000000000000000000000",
                                BILLAMT=100,
                                BILLTYPE="AC01",
                                OUTDATE= DateTime.Now,
                                DUEDATE= DateTime.Now.AddDays(3),
                                DRAWERNAME="zhengxh",
                                DRAWERACCTNO="622908363000570115",
                                DRAWERBANKNAME="bank01",
                                DRAWERBANKCODE="bank01",
                                PAYEENAME="zhengxh",
                                PAYEEACCTNO="622908363000570115",
                                PAYEEBANKNAME="bank01",
                                PAYEEBANKCODE="bank01",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.7 保证金提取
        /// </summary>
        public static void EBPBAILTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPBAILTRNRQ, V1_EBPBAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPBAILTRNRQ
            {
                EBPBAILTRNRQ = new EBPBAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPBAILTRN_RQBODY
                    {
                        DRAWAMT = 5000,
                        BAILACCTNO = "117010100100389713",
                        TOACCTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.8 票据池处理结果查询
        /// </summary>
        public static void EBPBILLPOOLRESULTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPBILLPOOLRESULTQUERYTRNRQ, V1_EBPBILLPOOLRESULTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPBILLPOOLRESULTQUERYTRNRQ
            {
                EBPBILLPOOLRESULTQUERYTRNRQ = new EBPBILLPOOLRESULTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPBILLPOOLRESULTQUERYTRN_RQBODY
                    {
                         RELATETRNUID= "20190306195953_3.9.3.7",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.9 票据池可操作票据查询
        /// </summary>
        public static void EBPOPERATEBILLQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPOPERATEBILLQUERYTRNRQ, V1_EBPOPERATEBILLQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPOPERATEBILLQUERYTRNRQ
            {
                EBPOPERATEBILLQUERYTRNRQ = new EBPOPERATEBILLQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPOPERATEBILLQUERYTRN_RQBODY
                    {
                        QUERYTYPE = "01",
                        BILLTYPE = "AC02",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.10 客户签约信息查询
        /// </summary>
        public static void EBPCUSTSIGNINFOQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCUSTSIGNINFOQUERYTRNRQ, V1_EBPCUSTSIGNINFOQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCUSTSIGNINFOQUERYTRNRQ
            {
                EBPCUSTSIGNINFOQUERYTRNRQ = new EBPCUSTSIGNINFOQUERYTRNRQ
                {
                    TRNUID = tid,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.11 集团关系查询
        /// </summary>
        public static void EBPGROUPCUSTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPGROUPCUSTQUERYTRNRQ, V1_EBPGROUPCUSTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPGROUPCUSTQUERYTRNRQ
            {
                EBPGROUPCUSTQUERYTRNRQ = new EBPGROUPCUSTQUERYTRNRQ
                {
                    TRNUID = tid,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.12 单一客户票据池额度信息查询
        /// </summary>
        public static void EBPSINGLELIMITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPSINGLELIMITQUERYTRNRQ, V1_EBPSINGLELIMITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPSINGLELIMITQUERYTRNRQ
            {
                EBPSINGLELIMITQUERYTRNRQ = new EBPSINGLELIMITQUERYTRNRQ
                {
                    TRNUID = tid,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.13 集团客户票据池额度查询
        /// </summary>
        public static void EBPGROUPLIMITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.13", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPGROUPLIMITQUERYTRNRQ, V1_EBPGROUPLIMITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPGROUPLIMITQUERYTRNRQ
            {
                EBPGROUPLIMITQUERYTRNRQ = new EBPGROUPLIMITQUERYTRNRQ
                {
                    TRNUID = tid,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.14 成员单位票据池额度信息查询
        /// </summary>
        public static void EBPMEMBERLIMITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.14", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPMEMBERLIMITQUERYTRNRQ, V1_EBPMEMBERLIMITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPMEMBERLIMITQUERYTRNRQ
            {
                EBPMEMBERLIMITQUERYTRNRQ = new EBPMEMBERLIMITQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPMEMBERLIMITQUERYTRN_RQBODY
                    {
                         GROUPBILLPOOLNO= "JT1100343164",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.15 出入池登记簿
        /// </summary>
        public static void EBPOUTINPOOLREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.15", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPOUTINPOOLREGISTERTRNRQ, V1_EBPOUTINPOOLREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPOUTINPOOLREGISTERTRNRQ
            {
                EBPOUTINPOOLREGISTERTRNRQ = new EBPOUTINPOOLREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPOUTINPOOLREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-2),
                        DUEDATE = DateTime.Now.AddYears(-1),
                        BIZTYPE = "01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.16 质押托管转换登记簿
        /// </summary>
        public static void EBPCONVERTREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.16", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCONVERTREGISTERTRNRQ, V1_EBPCONVERTREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCONVERTREGISTERTRNRQ
            {
                EBPCONVERTREGISTERTRNRQ = new EBPCONVERTREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCONVERTREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-2),
                        DUEDATE = DateTime.Now.AddYears(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.17 开票明细业务登记簿
        /// </summary>
        public static void EBPOPENBILLREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.17", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPOPENBILLREGISTERTRNRQ, V1_EBPOPENBILLREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPOPENBILLREGISTERTRNRQ
            {
                EBPOPENBILLREGISTERTRNRQ = new EBPOPENBILLREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPOPENBILLREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-1),
                        DUEDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.18 资产业务登记薄
        /// </summary>
        public static void EBPCAPITALREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.18", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCAPITALREGISTERTRNRQ, V1_EBPCAPITALREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCAPITALREGISTERTRNRQ
            {
                EBPCAPITALREGISTERTRNRQ = new EBPCAPITALREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCAPITALREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-1),
                        DUEDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.19 保证金交易登记薄
        /// </summary>
        public static void EBPBAILREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.19", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPBAILREGISTERTRNRQ, V1_EBPBAILREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPBAILREGISTERTRNRQ
            {
                EBPBAILREGISTERTRNRQ = new EBPBAILREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPBAILREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-1),
                        DUEDATE = DateTime.Now.AddDays(-1),
                        TRADEPERIOD = 1,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.20 在池票据登记簿
        /// </summary>
        public static void EBPINPOOLBILLREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.20", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPINPOOLBILLREGISTERTRNRQ, V1_EBPINPOOLBILLREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPINPOOLBILLREGISTERTRNRQ
            {
                EBPINPOOLBILLREGISTERTRNRQ = new EBPINPOOLBILLREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPINPOOLBILLREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-1),
                        DUEDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.21 票据池托收登记簿
        /// </summary>
        public static void EBPCOLLECTIONREGISTERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.21", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCOLLECTIONREGISTERTRNRQ, V1_EBPCOLLECTIONREGISTERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCOLLECTIONREGISTERTRNRQ
            {
                EBPCOLLECTIONREGISTERTRNRQ = new EBPCOLLECTIONREGISTERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCOLLECTIONREGISTERTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddYears(-3),
                        DUEDATE = DateTime.Now.AddYears(-2),
                        BILLMEDIUM = "1",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.22 成员单位用信申请
        /// </summary>
        public static void EBPMEMBERCREDITTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.22", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPMEMBERCREDITTRNRQ, V1_EBPMEMBERCREDITTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPMEMBERCREDITTRNRQ
            {
                EBPMEMBERCREDITTRNRQ = new EBPMEMBERCREDITTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPMEMBERCREDITTRN_RQBODY
                    {
                        GROUPBILLPOOLNO = "JT1100343164",
                        BIZTYPE = "04",
                        LIMITTYPE = 1,
                        APPLYAMT = 1200,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.23 成员用信审批查询（集团审批查询用）
        /// </summary>
        public static void EBPMEMBERCREDITQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.23", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPMEMBERCREDITQUERYTRNRQ, V1_EBPMEMBERCREDITQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPMEMBERCREDITQUERYTRNRQ
            {
                EBPMEMBERCREDITQUERYTRNRQ = new EBPMEMBERCREDITQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPMEMBERCREDITQUERYTRN_RQBODY
                    {
                        GROUPBILLPOOLNO = "JT1100343164",
                        BIZTYPE = "04",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.24 用信处理结果查询
        /// </summary>
        public static void EBPCREDITRESULTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.24", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPCREDITRESULTQUERYTRNRQ, V1_EBPCREDITRESULTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPCREDITRESULTQUERYTRNRQ
            {
                EBPCREDITRESULTQUERYTRNRQ = new EBPCREDITRESULTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPCREDITRESULTQUERYTRN_RQBODY
                    {
                        RELATETRNUID = "20190307104136_3.9.3.25"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.9.3.25 成员单位用信审批
        /// </summary>
        public static void EBPMEMBERCREDITAUDITTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.9.3.25", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_EBPMEMBERCREDITAUDITTRNRQ, V1_EBPMEMBERCREDITAUDITTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_EBPMEMBERCREDITAUDITTRNRQ
            {
                EBPMEMBERCREDITAUDITTRNRQ = new EBPMEMBERCREDITAUDITTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new EBPMEMBERCREDITAUDITTRN_RQBODY
                    {
                        GROUPBILLPOOLNO = "JT1100343164",
                        MEMBERCID = "1100343164",
                        MEMBERNAME = "中国民族证券有限责任公司",
                        BIZTYPE = "04",
                        APPLYNO = "900079439058",
                        APPLYDATE = new DateTime(2019, 3, 7),
                        APPLYAMT = 1200,
                        AUDITRESULT = 1,
                        AUDITMSG = "成员单位用信审批AUDITMSG",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.10	跨行账户管理
        /// <summary>
        /// 3.10.1	他行账户登记
        /// </summary>
        public static void CRSACCTREGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.10.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CRSACCTREGTRNRQ, V1_CRSACCTREGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CRSACCTREGTRNRQ
            {
                CRSACCTREGTRNRQ = new CRSACCTREGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CRSACCTREGTRN_RQBODY
                    {
                        OPERTYPE = "ADD",
                        AGRMTYPE = 1,
                        INTERACCTID = "201204231170102",
                        AGRM = "20120423002",
                        OPERACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.10.2	他行账户协议查询
        /// </summary>
        public static void CRSAGRMQTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.10.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CRSAGRMQTRNRQ, V1_CRSAGRMQTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CRSAGRMQTRNRQ
            {
                CRSAGRMQTRNRQ = new CRSAGRMQTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CRSAGRMQTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        AGRMTYPE = 1
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.10.3	他行账户余额查询
        /// </summary>
        public static void CRSBLNCQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.10.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CRSBLNCQUERYTRNRQ, V1_CRSBLNCQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CRSBLNCQUERYTRNRQ
            {
                CRSBLNCQUERYTRNRQ = new CRSBLNCQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CRSBLNCQUERYTRN_RQBODY
                    {
                        QUERYCOND = new CRSBLNCQUERYTRN_QUERYCOND
                        {
                            AGRM = "20120423002",
                            OPERACCTID = mainAccountId,
                        },
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.10.4	他行账户明细查询
        /// </summary>
        public static void CRSSTMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.10.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CRSSTMTTRNRQ, V1_CRSSTMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CRSSTMTTRNRQ
            {
                CRSSTMTTRNRQ = new CRSSTMTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CRSSTMTTRN_RQBODY
                    {
                        QUERYCOND = new CRSSTMTTRN_QUERYCOND
                        {
                            AGRM = "20120423002",
                            OPERACCTID = mainAccountId,
                            DTSTART = DateTime.Now.AddDays(-5),
                            DTEND = DateTime.Now.AddDays(-1)
                        },
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.10.5	他行账户收款
        /// </summary>
        public static void CRSGATHERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.10.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CRSGATHERTRNRQ, V1_CRSGATHERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CRSGATHERTRNRQ
            {
                CRSGATHERTRNRQ = new CRSGATHERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CRSGATHERTRN_RQBODY
                    {
                        ACCTFROM = new RQACCT
                        {
                            ACCTID = "201204231170101"
                        },
                        ACCTTO = new RQACCT
                        {
                            ACCTID = mainAccountId
                        },
                        AGRM = "20120423002",
                        BUSINESSTYPE = "00100",
                        PURPOSE = "他行账户收款",
                        TRNAMT = 5.7m,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.11	贵金属交易
        /// <summary>
        /// 3.11.1.1 贵金属账户签约查询
        /// </summary>
        public static void PMCONTRQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMCONTRQUERYTRNRQ, V1_PMCONTRQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMCONTRQUERYTRNRQ
            {
                PMCONTRQUERYTRNRQ = new PMCONTRQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.1.2 贵金属库存查询
        /// </summary>
        public static void PMINVNQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMINVNQUERYTRNRQ, V1_PMINVNQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMINVNQUERYTRNRQ
            {
                PMINVNQUERYTRNRQ = new PMINVNQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.1.3 贵金属交易资金查询
        /// </summary>
        public static void PMFUNDQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMFUNDQUERYTRNRQ, V1_PMFUNDQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMFUNDQUERYTRNRQ
            {
                PMFUNDQUERYTRNRQ = new PMFUNDQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.1.4 贵金属交易会员信息查询
        /// </summary>
        public static void PMMBRQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMMBRQUERYTRNRQ, V1_PMMBRQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMMBRQUERYTRNRQ
            {
                PMMBRQUERYTRNRQ = new PMMBRQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.1.5 提货申请查询
        /// </summary>
        public static void PMDLVRYQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMDLVRYQUERYTRNRQ, V1_PMDLVRYQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMDLVRYQUERYTRNRQ
            {
                PMDLVRYQUERYTRNRQ = new PMDLVRYQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PMDLVRYQUERYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        OPERDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.1.6 出入金明细查询
        /// </summary>
        public static void PMSTMTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.1.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMSTMTQUERYTRNRQ, V1_PMSTMTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMSTMTQUERYTRNRQ
            {
                PMSTMTQUERYTRNRQ = new PMSTMTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PMSTMTQUERYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        DTSTART = DateTime.Now.AddMonths(-1),
                        DTEND = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.2	入金申请
        /// </summary>
        public static void PMINVESTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMINVESTTRNRQ, V1_PMINVESTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMINVESTTRNRQ
            {
                PMINVESTTRNRQ = new PMINVESTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PMINVESTTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        TRNAMT = 5000.0m,
                        CUSTNO = "87654322",
                        MBRNO = "A01523501005411"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.3	保证金划回申请
        /// </summary>
        public static void PMREFUNDTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMREFUNDTRNRQ, V1_PMREFUNDTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMREFUNDTRNRQ
            {
                PMREFUNDTRNRQ = new PMREFUNDTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PMREFUNDTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        TRNAMT = 5000.0m,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.11.4	实物提货申请
        /// </summary>
        public static void PMDLVRYAPPLYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.11.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_PMDLVRYAPPLYTRNRQ, V1_PMDLVRYAPPLYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_PMDLVRYAPPLYTRNRQ
            {
                PMDLVRYAPPLYTRNRQ = new PMDLVRYAPPLYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PMDLVRYAPPLYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        PRODNO = "202",
                        PICKCNT = 3000,
                        PICKPWD = "111111"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.12	定活互转
        /// <summary>
        /// 3.12.1	活期转定期
        /// </summary>
        public static void DEMAND2TIMETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DEMAND2TIMETRNRQ, V1_FINANCINGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DEMAND2TIMETRNRQ
            {
                DEMAND2TIMETRNRQ = new DEMAND2TIMETRNRQ
                {
                    TRNUID = tid,
                    DEMAND2TIMEINFO = new DEMAND2TIMEINFO
                    {
                        AMOUNT = 10200.0m,
                        CONTFLAG = 2,
                        DEMANDACCT = mainAccountId,
                        TERM = "M06",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.2	定期转活期
        /// </summary>
        public static void TIME2DEMANDTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TIME2DEMANDTRNRQ, V1_FINANCINGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TIME2DEMANDTRNRQ
            {
                TIME2DEMANDTRNRQ = new TIME2DEMANDTRNRQ
                {
                    TRNUID = tid,
                    TIME2DEMANDINFO = new TIME2DEMANDINFO
                    {
                        TIMEACCT = mainAccountId
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.3	活期转通知
        /// </summary>
        public static void CCCURR2CALLTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CCCURR2CALLTRNRQ, V1_CCCURR2CALLTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CCCURR2CALLTRNRQ
            {
                CCCURR2CALLTRNRQ = new CCCURR2CALLTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CCCURR2CALLTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        TRNAMT = 500010.0m,
                        TERM = "D07",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.4	通知转活期
        /// </summary>
        public static void CCCALL2CURRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CCCALL2CURRTRNRQ, V1_CCCALL2CURRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CCCALL2CURRTRNRQ
            {
                CCCALL2CURRTRNRQ = new CCCALL2CURRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CCCALL2CURRTRN_RQBODY
                    {
                        ACCTID = "117010100200489949",
                        TRNAMT = 100.0m,
                        ACTIONTYPE = 6,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.5.1 智能通知存款签约关系查询
        /// </summary>
        public static void ICCONTRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.5.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICCONTRTRNRQ, V1_ICCONTRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICCONTRTRNRQ
            {
                ICCONTRTRNRQ = new ICCONTRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.5.2 智能通知存款协议查询
        /// </summary>
        public static void ICAGMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.5.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICAGMTTRNRQ, V1_ICAGMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICAGMTTRNRQ
            {
                ICAGMTTRNRQ = new ICAGMTTRNRQ
                {
                    TRNUID = tid,
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.5.3 智能通知存款登记
        /// </summary>
        public static void ICREGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.5.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICREGTRNRQ, V1_ICREGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICREGTRNRQ
            {
                ICREGTRNRQ = new ICREGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new ICREGTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        RETAINAMT = 100000
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.5.4 智能通知存款撤销
        /// </summary>
        public static void ICCANCELTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.5.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICCANCELTRNRQ, V1_ICCANCELTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICCANCELTRNRQ
            {
                ICCANCELTRNRQ = new ICCANCELTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new RQACCT
                    {
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.5.5 智能通知存款资金支取
        /// </summary>
        public static void ICWITHDRAWALTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.5.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ICWITHDRAWALTRNRQ, V1_ICWITHDRAWALTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ICWITHDRAWALTRNRQ
            {
                ICWITHDRAWALTRNRQ = new ICWITHDRAWALTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new ICWITHDRAWALTRN_RQBODY
                    {
                        ACCTID = "117010100200489949",
                        TRNAMT = 100000
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.1 结构性存款产品信息查询
        /// </summary>
        public static void STRUCTPRODUCTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STRUCTPRODUCTTRNRQ, V1_STRUCTPRODUCTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STRUCTPRODUCTTRNRQ
            {
                STRUCTPRODUCTTRNRQ = new STRUCTPRODUCTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STRUCTPRODUCTTRN_RQBODY
                    {
                        DEMANDACCT = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.2 结构性存款开户
        /// </summary>
        public static void DEMANDTOSTRUCTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DEMANDTOSTRUCTTRNRQ, V1_DEMANDTOSTRUCTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DEMANDTOSTRUCTTRNRQ
            {
                DEMANDTOSTRUCTTRNRQ = new DEMANDTOSTRUCTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DEMANDTOSTRUCTTRN_RQBODY
                    {
                        DEMANDACCT = mainAccountId,
                        PRODUCTNO = "90040415",
                        PRODUCTNAME = "ldm结构性存款测试",
                        AMOUNT = 5000000
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.3 结构性存款开户交易结果查询
        /// </summary>
        public static void DEMANDTOSTRUCTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DEMANDTOSTRUCTQUERYTRNRQ, V1_DEMANDTOSTRUCTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DEMANDTOSTRUCTQUERYTRNRQ
            {
                DEMANDTOSTRUCTQUERYTRNRQ = new DEMANDTOSTRUCTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DEMANDTOSTRUCTQUERYTRN_RQBODY
                    {
                         CLTREFNO= "20190227145923_3.12.6.2",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.4 结构性存款账户信息查询
        /// </summary>
        public static void STRUCTACCOUNTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STRUCTACCOUNTTRNRQ, V1_STRUCTACCOUNTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STRUCTACCOUNTTRNRQ
            {
                STRUCTACCOUNTTRNRQ = new STRUCTACCOUNTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STRUCTACCOUNTTRN_RQBODY
                    {
                        DEMANDACCT = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.5 结构性存款支取
        /// </summary>
        public static void STRUCTTODEMANDTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STRUCTTODEMANDTRNRQ, V1_STRUCTTODEMANDTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STRUCTTODEMANDTRNRQ
            {
                STRUCTTODEMANDTRNRQ = new STRUCTTODEMANDTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STRUCTTODEMANDTRN_RQBODY
                    {
                        DEMANDACCT = mainAccountId,
                        STRUCTACCT = "117010100200335593",
                        AMOUNT = 1000000,
                        PRODUCTNO = "80050013",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.6.6 结构性存款支取交易结果查询
        /// </summary>
        public static void STRUCTTODEMANDQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.6.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_STRUCTTODEMANDQUERYTRNRQ, V1_STRUCTTODEMANDQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_STRUCTTODEMANDQUERYTRNRQ
            {
                STRUCTTODEMANDQUERYTRNRQ = new STRUCTTODEMANDQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new STRUCTTODEMANDQUERYTRN_RQBODY
                    {
                        CLTREFNO = "20190228153008_3.12.6.5",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.1 智能定期存款互联互通—签约
        /// </summary>
        public static void INTGNTTIMEINTCONSIGNTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_INTGNTTIMEINTCONSIGNTRNRQ, V1_INTGNTTIMEINTCONSIGNTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_INTGNTTIMEINTCONSIGNTRNRQ
            {
                INTGNTTIMEINTCONSIGNTRNRQ = new INTGNTTIMEINTCONSIGNTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new INTGNTTIMEINTCONSIGNTRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                        OPENAMOUNT = 10000000000
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.2 智能定期存款互联互通—签约账户查询
        /// </summary>
        public static void INTGNTTIMEINTCONQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_INTGNTTIMEINTCONQUERYTRNRQ, V1_INTGNTTIMEINTCONQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_INTGNTTIMEINTCONQUERYTRNRQ
            {
                INTGNTTIMEINTCONQUERYTRNRQ = new INTGNTTIMEINTCONQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new INTGNTTIMEINTCONQUERYTRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.3 智能定期存款互联互通—修改/解约
        /// </summary>
        public static void INTGNTTIMEINTCONMODIFYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_INTGNTTIMEINTCONMODIFYTRNRQ, V1_INTGNTTIMEINTCONMODIFYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_INTGNTTIMEINTCONMODIFYTRNRQ
            {
                INTGNTTIMEINTCONMODIFYTRNRQ = new INTGNTTIMEINTCONMODIFYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new INTGNTTIMEINTCONMODIFYTRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                        ACTIONTYPE = 0,
                        OBLIGATEAMOUNT = 10000000000
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.4 智能定期存款互联互通—关联/解关联
        /// </summary>
        public static void INTGNTTIMEINTCONUNCONTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_INTGNTTIMEINTCONUNCONTRNRQ, V1_INTGNTTIMEINTCONUNCONTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_INTGNTTIMEINTCONUNCONTRNRQ
            {
                INTGNTTIMEINTCONUNCONTRNRQ = new INTGNTTIMEINTCONUNCONTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new INTGNTTIMEINTCONUNCONTRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                        ACTIONTYPE = 0,
                        OPENAMOUNT = 5000000,
                        FIXEDACCOUNTNO = "117010100200490349",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.5 智能定期存款—开户
        /// </summary>
        public static void CREATEINTELLIGENTTIMETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CREATEINTELLIGENTTIMETRNRQ, V1_CREATEINTELLIGENTTIMETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CREATEINTELLIGENTTIMETRNRQ
            {
                CREATEINTELLIGENTTIMETRNRQ = new CREATEINTELLIGENTTIMETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CREATEINTELLIGENTTIMETRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                        OPENAMOUNT = 5000000,
                    }
                }
            };
            var rs = client.Execute(rq);//117010100200490349
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.6 智能定期存款账户查询
        /// </summary>
        public static void QUERYINTELLIGENTTIMETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYINTELLIGENTTIMETRNRQ, V1_QUERYINTELLIGENTTIMETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYINTELLIGENTTIMETRNRQ
            {
                QUERYINTELLIGENTTIMETRNRQ = new QUERYINTELLIGENTTIMETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYINTELLIGENTTIMETRN_RQBODY
                    {
                        DEMANDACCOUNTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.7 智能定期存款—明细查询
        /// </summary>
        public static void QUERYINTELLIGENTTIMEDETAILTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYINTELLIGENTTIMEDETAILTRNRQ, V1_QUERYINTELLIGENTTIMEDETAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYINTELLIGENTTIMEDETAILTRNRQ
            {
                QUERYINTELLIGENTTIMEDETAILTRNRQ = new QUERYINTELLIGENTTIMEDETAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYINTELLIGENTTIMEDETAILTRN_RQBODY
                    {
                        FIXEDACCOUNTNO = "117010100200490349",
                        STARTDATE = DateTime.Now.AddMonths(-5),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.7.8 智能定期存款—资金支取
        /// </summary>
        public static void DRAWINTELLIGENTTIMETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.7.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DRAWINTELLIGENTTIMETRNRQ, V1_DRAWINTELLIGENTTIMETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DRAWINTELLIGENTTIMETRNRQ
            {
                DRAWINTELLIGENTTIMETRNRQ = new DRAWINTELLIGENTTIMETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DRAWINTELLIGENTTIMETRN_RQBODY
                    {
                        FIXEDACCOUNTNO = "117010100200490349",
                        DEMANDACCOUNTNO = mainAccountId,
                        AMOUNT = 11000,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.8.1 一本帐及互联互通
        /// </summary>
        public static void TRADEAPASSDETAILTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.8.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TRADEAPASSDETAILTRNRQ, V1_TRADEAPASSDETAILTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TRADEAPASSDETAILTRNRQ
            {
                TRADEAPASSDETAILTRNRQ = new TRADEAPASSDETAILTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.12.8.2 同业一本通及互联互通查询
        /// </summary>
        public static void TRADEAPASSTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.12.8.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_TRADEAPASSTRNRQ, V1_TRADEAPASSTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_TRADEAPASSTRNRQ
            {
                TRADEAPASSTRNRQ = new TRADEAPASSTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new PAGED_RQACCT
                    {
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.13	扩展功能
        /// <summary>
        /// 3.13.1	批量汇款指令提交（暂不推荐）
        /// </summary>
        public static void BATCHTRNRQSample()
        {
            //因为此处功能与3.4	企业财务室中的批量支付功能类似，且属于不推荐功能，所以txt文本组织方式此处不进行封装
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BATCHTRNRQ, V1_BATCHTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BATCHTRNRQ
            {
                BATCHTRNRQ = new BATCHTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "1234",
                    BATCHRQ = new BATCHRQ
                    {
                        BATCHINFO = new BATCHINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId,
                            },
                            BIZTYPE = 0,
                            TITLE = "批量汇款指令提交（暂不推荐）",
                            ATTACHMENT = new ATTACHMENT
                            {
                                DIGEST = new DIGEST
                                {
                                    VALUE = "123112313131321132",
                                },
                                FILENAME = "no.txt"
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.2	批量工资指令提交（暂不推荐）
        /// </summary>
        public static void BPAYOFFTRNRQSample()
        {
            //因为此处功能与3.4	企业财务室中的工资发放功能类似，且属于不推荐功能，所以txt文本组织方式此处不进行封装
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BPAYOFFTRNRQ, V1_BPAYOFFTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BPAYOFFTRNRQ
            {
                BPAYOFFTRNRQ = new BPAYOFFTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "1234",
                    BPAYOFFRQ = new BPAYOFFRQ
                    {
                        BPAYOFFINFO = new BPAYOFFINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = mainAccountId,
                            },
                            DESCRIPTION = "006",
                            TITLE = "批量工资指令提交（暂不推荐）",
                            ATTACHMENT = new ATTACHMENT
                            {
                                DIGEST = new DIGEST
                                {
                                    VALUE = "123112313131321132",
                                },
                                FILENAME = "no.txt"
                            },
                            REMARK = "工资发放",
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.3	历史余额查询
        /// </summary>
        public static void HISBALQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_HISBALQUERYTRNRQ, V1_HISBALQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_HISBALQUERYTRNRQ
            {
                HISBALQUERYTRNRQ = new HISBALQUERYTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "1234",
                    HISBALQUERYRQ = new HISBALQUERYRQ
                    {
                        HISBALQUERYINFO = new HISBALQUERYINFO
                        {
                            ACCTID = mainAccountId,
                            DTSTART = DateTime.Now.AddMonths(-5),
                            DTEND = DateTime.Now.AddDays(-2),
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.4	预约提现和电子渠道类客户申请
        /// </summary>
        public static void ELECAPPLYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ELECAPPLYTRNRQ, V1_ELECAPPLYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ELECAPPLYTRNRQ
            {
                ELECAPPLYTRNRQ = new ELECAPPLYTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "1234",
                    ELECAPPLYRQ = new ELECAPPLYRQ
                    {
                        ELECAPPLYINFO = new ELECAPPLYINFO
                        {
                            ACCTID = mainAccountId,
                            ACCTNAME = mainAccountName,
                            AMOUNT = 20.0m,
                            NOTYPEDESCRIPT = "预约提现",
                            PURPOSE = "预约提现和电子渠道类客户申请",
                            BUSINESSSTORY = "预约提现业务",

                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.5	手动归集
        /// </summary>
        public static void HWKSUMUPTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_HWKSUMUPTRNRQ, V1_HWKSUMUPTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_HWKSUMUPTRNRQ
            {
                HWKSUMUPTRNRQ = new HWKSUMUPTRNRQ
                {
                    TRNUID = tid,
                    CLTCOOKIE = "1234",
                    HWKSUMUPRQ = new HWKSUMUPRQ
                    {
                        HWKSUMUPINFO = new HWKSUMUPINFO
                        {
                            CENTERACCTID = mainAccountId,
                            List = new List<MEMBERACCT>
                            {
                                new MEMBERACCT{
                                     ACCTID="117010100100306538"
                                }
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.6	支付指令核心处理结果查询
        /// </summary>
        public static void INQSTATETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_INQSTATETRNRQ, V1_INQSTATETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_INQSTATETRNRQ
            {
                INQSTATETRNRQ = new INQSTATETRNRQ
                {
                    TRNUID = tid,
                    INQSTATECOND = new INQSTATECOND
                    {
                        CLIENTREF = "20190125145132_3.4.1"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.13.7	扣税流水查询
        /// </summary>
        public static void CHINAMOBILETAXQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.13.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CHINAMOBILETAXQUERYTRNRQ, V1_CHINAMOBILETAXQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CHINAMOBILETAXQUERYTRNRQ
            {
                CHINAMOBILETAXQUERYTRNRQ = new CHINAMOBILETAXQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CHINAMOBILETAXQUERYTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        DTSTART = DateTime.Now.AddDays(-5),
                        DTEND = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.14	财务公司代理支付
        /// <summary>
        /// 3.14.1	实体主账户绑定的代理支付
        /// 3.14.2	虚拟子账户绑定的代理支付
        /// 3.14.3	虚拟子账户绑定的代理支付（内部账号第8位跟第11位必须为“-”）
        /// </summary>
        public static void VAPMTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.14.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_VAPMTTRNRQ, V1_VAPMTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_VAPMTTRNRQ
            {
                VAPMTTRNRQ = new VAPMTTRNRQ
                {
                    TRNUID = tid,
                    VAXFERRQ = new VAXFERRQ
                    {
                        XFERINFO = new XFERINFO
                        {
                            ACCTFROM = new ACCTFROM
                            {
                                ACCTID = "00-10-0001-1",
                            },
                            ACCTTO = GetACCTTO(3),
                            PURPOSE = "财务公司代理支付",
                            TRNAMT = 3.14m,
                            DTDUE = DateTime.Now,
                            MEMO = "财务公司代理支付备注",
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }

        //3.14.4与3.6.6请求响应相同
        #endregion

        #region 3.15	电子商务
        /// <summary>
        /// 3.15.1	商户单笔退款
        /// </summary>
        public static void MRCHREFUNDTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.15.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MRCHREFUNDTRNRQ, V1_MRCHREFUNDTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MRCHREFUNDTRNRQ
            {
                MRCHREFUNDTRNRQ = new MRCHREFUNDTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new MRCHREFUNDTRN_RQBODY
                    {
                        MEMO = "商户单笔退款备注",
                        MRCHNO = "110012",
                        ORDERNO = "T20120719104505",
                        ORDERAMT = 60000.31m,
                        REFUNDAMT = 1.1m
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.15.2	商户单笔订单查询
        /// </summary>
        public static void MRCHORDERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.15.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MRCHORDERTRNRQ, V1_MRCHORDERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MRCHORDERTRNRQ
            {
                MRCHORDERTRNRQ = new MRCHORDERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new  MRCHORDERTRN_RQBODY
                    {
                        MRCHNO = "110001",
                        ORDERNO = "T20110823114328",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.16	收付直通车商户资金代付
        /// <summary>
        /// 3.16.1	收付直通车资金代付及指令查询（不采用工作流）
        /// </summary>
        public static void MAGENTPAYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.16.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MAGENTPAYTRNRQ, V1_MAGENTPAYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MAGENTPAYTRNRQ
            {
                MAGENTPAYTRNRQ = new MAGENTPAYTRNRQ
                {
                    TRNUID = tid,
                    MAGENTPAYRQ = new MAGENTPAYRQ
                    {
                        MAGENTPAYINFO = new MAGENTPAYINFO
                        {
                            MRCHNO = "P0000016",
                            ORDERNO = "fdg1ff3fdr1321321",
                            MRCHNAME = "银企直联测试",
                            ACCTFROM = new ACCT
                            {
                                ACCTID = mainAccountId,
                            },
                            ACCTTO = GetACCTTO(3),
                            TRNAMT = 5.5m,
                            PURPOSE = "收付直通车资金代付及指令查询（不采用工作流）",
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.16.2	收付直通车批量代付(最多100笔，不采用工作流)
        /// </summary>
        public static void ASYNBATCHMRCHAGENTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.16.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ASYNBATCHMRCHAGENTTRNRQ, V1_ASYNBATCHMRCHAGENTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ASYNBATCHMRCHAGENTTRNRQ
            {
                ASYNBATCHMRCHAGENTTRNRQ = new ASYNBATCHMRCHAGENTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new ASYNBATCHMRCHAGENTTRN_RQBODY
                    {
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        MRCHNO = "Q0000482",
                        PURPOSE = "收付直通车批量代付",
                    }
                }
            };
            var txt = new ASYNBATCHMRCHAGENTTRNRQ_XFERINFOTEXT();
            var list = new List<PayeeInfo_3_16_2>();
            for (byte i = 0; i < 4; i++)
            {
                var acct = GetACCTTO(i);
                var info = new PayeeInfo_3_16_2
                {
                    AccountType = 0,
                    //MerchantName="",
                    OrderNo = "201606021qwengqiang00" + i,
                    Account = acct.ACCTID,
                    Name = acct.NAME,
                    BankCode = "105100000017",
                    BankName = string.IsNullOrWhiteSpace(acct.BANKDESC) ? "兴业银行" : acct.BANKDESC,
                    Amount = i + 5.3m,
                    Purpose = "收付直通车批量代付" + i,
                };
                list.Add(info);
            }
            txt.SetList(list);
            rq.SECURITIES_MSGSRQV1.ASYNBATCHMRCHAGENTTRNRQ.RQBODY.XFERINFOTEXT = txt;
            rq.SECURITIES_MSGSRQV1.ASYNBATCHMRCHAGENTTRNRQ.TRNUID = "20190129101024_3.16.2";
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
            if (rs.SECURITIES_MSGSRSV1.ASYNBATCHMRCHAGENTTRNRS.RSBODY.XFERINFOTEXT != null)
            {
                var rList = rs.SECURITIES_MSGSRSV1.ASYNBATCHMRCHAGENTTRNRS.RSBODY.XFERINFOTEXT.GetList();
            }
        }
        #endregion

        #region 3.17	虚拟资金池
        /// <summary>
        /// 3.17.1	活期与保证金互转
        /// </summary>
        public static void DCPMGTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DCPMGTTRNRQ, V1_DCPMGTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DCPMGTTRNRQ
            {
                DCPMGTTRNRQ = new DCPMGTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DCPMGTTRN_RQBODY
                    {
                        MEMACCT = "117010100100306538",
                        MARGINACCT = mainAccountId,
                        AMOUNT = 100.0m,
                        BIZTYPE = 1,
                        PURPOSE = "活期转担保",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.2	内部计价利息分配
        /// </summary>
        public static void DCPINTERESTADJUSTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DCPINTERESTADJUSTTRNRQ, V1_DCPINTERESTADJUSTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DCPINTERESTADJUSTTRNRQ
            {
                DCPINTERESTADJUSTTRNRQ = new DCPINTERESTADJUSTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DCPINTERESTADJUSTTRN_RQBODY
                    {
                        MAINACCTNO = mainAccountId,
                        MEMACCTNO = "117010100100306538",
                        CURRFUND = 0.1m,
                        CURRINTRST = 0.2m,
                        CURRINTRSTRATE = 0.3m,
                        ADJUSTDEMANDINTRST = 0.2m,
                        TIMEFUND = 0.5m,
                        TIMEINTRST = 0.6m,
                        TIMEINTRSTRATE = 0.7m,
                        ADJUSTTIMEINTRST = 0.6m
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.3	利息查询
        /// </summary>
        public static void DCPINTRSTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_DCPINTRSTQUERYTRNRQ, V1_DCPINTRSTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_DCPINTRSTQUERYTRNRQ
            {
                DCPINTRSTQUERYTRNRQ = new DCPINTRSTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new DCPINTRSTQUERYTRN_RQBODY
                    {
                        MAINACCT = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.4	资金池签约关系及余额查询
        /// </summary>
        public static void QUERYSIGNRELATIONTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYSIGNRELATIONTRNRQ, V1_QUERYSIGNRELATIONTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYSIGNRELATIONTRNRQ
            {
                QUERYSIGNRELATIONTRNRQ = new QUERYSIGNRELATIONTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYSIGNRELATIONTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                        ACCTTYPE = 0,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.5	主账户支付额度查询
        /// </summary>
        public static void MAINACCTPAYLIMITTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MAINACCTPAYLIMITTRNRQ, V1_MAINACCTPAYLIMITTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MAINACCTPAYLIMITTRNRQ
            {
                MAINACCTPAYLIMITTRNRQ = new MAINACCTPAYLIMITTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new MAINACCTPAYLIMITTRN_RQBODY
                    {
                        ACCTID = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.6	成员账户属性设置
        /// </summary>
        public static void MEMACCTPROPCFGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MEMACCTPROPCFGTRNRQ, V1_MEMACCTPROPCFGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MEMACCTPROPCFGTRNRQ
            {
                MEMACCTPROPCFGTRNRQ = new MEMACCTPROPCFGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new MEMACCTPROPCFGTRN_RQBODY
                    {
                        ACCTNO = "117010100100306538",
                        CURRINTRSTRATE = 0.5m,
                        TIMEINTRSTRATE = 0.7m,
                        CTRBTFACTOR = 1.0m
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.7	主账户属性查询
        /// </summary>
        public static void MAINACCTPROPQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MAINACCTPROPQUERYTRNRQ, V1_MAINACCTPROPQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MAINACCTPROPQUERYTRNRQ
            {
                MAINACCTPROPQUERYTRNRQ = new MAINACCTPROPQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new MAINACCTPROPQUERYTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.17.8	成员账户属性查询
        /// </summary>
        public static void MEMACCTPROPQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.17.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_MEMACCTPROPQUERYTRNRQ, V1_MEMACCTPROPQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_MEMACCTPROPQUERYTRNRQ
            {
                MEMACCTPROPQUERYTRNRQ = new MEMACCTPROPQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new MEMACCTPROPQUERYTRN_RQBODY
                    {
                        ACCTNO = "117010100100306538",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.18	跨境电商
        /// <summary>
        /// 3.18.1	汇率查询
        /// </summary>
        public static void QUERYBULLETINTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_QUERYBULLETINTRNRQ, V1_QUERYBULLETINTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_QUERYBULLETINTRNRQ
            {
                QUERYBULLETINTRNRQ = new QUERYBULLETINTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new QUERYBULLETINTRN_RQBODY
                    {
                        DATE = DateTime.Now.AddDays(-4)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.2	结/售汇
        /// </summary>
        public static void CBECEXCHANGETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECEXCHANGETRNRQ, V1_CBECEXCHANGETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECEXCHANGETRNRQ
            {
                CBECEXCHANGETRNRQ = new CBECEXCHANGETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECEXCHANGETRN_RQBODY
                    {
                        BIZTYPE = 0,
                        FORCURRACCTNO = "117011174300000141",
                        RMBACCTNO = mainAccountId,
                        FORCURRAMT = 1000,
                        EXCHANGECATEGORY = 0,
                        TRANSCODE = "121010",
                        EXCHANGECODE = "11005",
                        MEMO = "结/售汇MEMO"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.3	结汇还原报送
        /// </summary>
        public static void CBECSETTLEMENTDECLARETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECSETTLEMENTDECLARETRNRQ, V1_CBECSETTLEMENTDECLARETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECSETTLEMENTDECLARETRNRQ
            {
                CBECSETTLEMENTDECLARETRNRQ = new CBECSETTLEMENTDECLARETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECSETTLEMENTDECLARETRN_RQBODY
                    {
                        EXCHANGEBANKLSH = "201602269999DBFN",
                        CURRENCY = "13",
                        List = new List<CBECSETTLEMENTDECLARETRNRQ_CONTENT>
                        {
                            new CBECSETTLEMENTDECLARETRNRQ_CONTENT{
                                SEQ=1,
                                BRANCH_NO="11702",
                                ID_TYPE=0,
                                ID_CODE="350121198806272712",
                                COUNTRY_CODE="156",
                                PERSON_NAME="AMI",
                                SETTLEMENT_AMT=500,
                                CAPITAL_PROP_CODE=110,
                                SALE_SETTLE_CODE="02",
                                PAY_ORG_CODE="570028451",
                                MEMO="结汇还原报送MEMO",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.4	购汇还原报送
        /// </summary>
        public static void CBECPURCHASEDECLARETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECPURCHASEDECLARETRNRQ, V1_CBECPURCHASEDECLARETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECPURCHASEDECLARETRNRQ
            {
                CBECPURCHASEDECLARETRNRQ = new CBECPURCHASEDECLARETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECPURCHASEDECLARETRN_RQBODY
                    {
                        EXCHANGEBANKLSH = "201602269999DBFN",
                        CURRENCY = "13",
                        List = new List<CBECPURCHASEDECLARETRNRQ_CONTENT>
                        {
                            new CBECPURCHASEDECLARETRNRQ_CONTENT{
                                SEQ=1,
                                BRANCH_NO="11702",
                                ID_TYPE=0,
                                ID_CODE="350121198806272712",
                                COUNTRY_CODE="156",
                                PERSON_NAME="AMI",
                                PURCHASE_AMT=500,
                                CAPITAL_PROP_CODE=310,
                                PURCHASE_CASH_AMT=100,
                                PURCHASE_REMIT_AMT=500,
                                FCY_ACCT_AMT=0,
                                TRIP_CHK_AMT=300,
                                PAY_ORG_CODE="570028451",
                                MEMO="购汇还原报送MEMO",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.5	结汇还原报送补录
        /// </summary>
        public static void CBECSETTLEMENTDECLAREREINTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECSETTLEMENTDECLAREREINTRNRQ, V1_CBECSETTLEMENTDECLAREREINTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECSETTLEMENTDECLAREREINTRNRQ
            {
                CBECSETTLEMENTDECLAREREINTRNRQ = new CBECSETTLEMENTDECLAREREINTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECSETTLEMENTDECLAREREINTRN_RQBODY
                    {
                        EXCHANGEBANKLSH = "201602269999DBFN",
                        BRANCH_NO = "11702",
                        ID_TYPE = 0,
                        ID_CODE = "350121198806272712",
                        COUNTRY_CODE = "156",
                        PERSON_NAME = "AMI",
                        CURRENCY = "13",
                        SETTLEMENT_AMT = 1000,
                        CAPITAL_PROP_CODE = 110,
                        SALE_SETTLE_CODE = "02",
                        PAY_ORG_CODE = "570028451",
                        DEAL_DATE = DateTime.Now,
                        MEMO = "结汇还原报送补录MEMO",
                        REIN_REASON_CODE = "01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.6	购汇还原报送补录
        /// </summary>
        public static void CBECPURCHASEDECLAREREINTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECPURCHASEDECLAREREINTRNRQ, V1_CBECPURCHASEDECLAREREINTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECPURCHASEDECLAREREINTRNRQ
            {
                CBECPURCHASEDECLAREREINTRNRQ = new CBECPURCHASEDECLAREREINTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECPURCHASEDECLAREREINTRN_RQBODY
                    {
                        EXCHANGEBANKLSH = "201602269999DBFN",
                        BRANCH_NO = "11702",
                        ID_TYPE = 0,
                        ID_CODE = "350121198806272712",
                        COUNTRY_CODE = "156",
                        PERSON_NAME = "AMI",
                        CURRENCY = "13",
                        PURCHASE_AMT = 1000,
                        CAPITAL_PROP_CODE = 310,
                        PURCHASE_CASH_AMT=100,
                        PURCHASE_REMIT_AMT=1000,
                        FCY_ACCT_AMT=0,
                        TRIP_CHK_AMT=0,
                        PAY_ORG_CODE = "570028451",
                        DEAL_DATE = DateTime.Now,
                        MEMO = "购汇还原报送补录MEMO",
                        REIN_REASON_CODE = "01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.7	结售汇还原报送查询
        /// </summary>
        public static void CBECEXCHANGEDECLAREQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECEXCHANGEDECLAREQUERYTRNRQ, V1_CBECEXCHANGEDECLAREQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECEXCHANGEDECLAREQUERYTRNRQ
            {
                CBECEXCHANGEDECLAREQUERYTRNRQ = new CBECEXCHANGEDECLAREQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECEXCHANGEDECLAREQUERYTRN_RQBODY
                    {
                        BEGIN_DATE = DateTime.Now.AddDays(-80),
                        DUE_DATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.8	付汇
        /// </summary>
        public static void CBECTRANSFERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECTRANSFERTRNRQ, V1_CBECTRANSFERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECTRANSFERTRNRQ
            {
                CBECTRANSFERTRNRQ = new CBECTRANSFERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECTRANSFERTRN_RQBODY
                    {
                        BUSN_TYPE = "JZF",
                        BRANCH_NO = "11701",
                        CURRENCY = "27",
                        REMIT_AMOUNT = 500,
                        REMITTER_ACCT_NO = "117011400100081792",
                        REMIT_CURRENCY = "14",
                        REMITTER_NAME = "fuzhoukehu",
                        PAYEE_ACCT_NO = "117012700100000650",
                        PAYEE_NAME = "weng",
                        COUNTRY_CODE = "ALB",
                        PAYEE_BANK_ACCT_NO = "1100",
                        PAYEE_BANK_CODE = "CITIUS33XXX",
                        PAYEE_BANK_NAME = "CITIBANK N.A. 111 WALL STREET",
                        BEAR_EXPENSES = "SHA",
                        PAY_TYPE = "O",
                        APPLY_TEL = "158600032S16",
                        APPLY_NAME = "WENGQ",
                        TRADE_CODE = "999999",
                        TRADE_MEMO = "付汇 TRADE_MEMO",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.9	付汇通知查询
        /// </summary>
        public static void CBECPAYNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECPAYNOTICEQUERYTRNRQ, V1_CBECPAYNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECPAYNOTICEQUERYTRNRQ
            {
                CBECPAYNOTICEQUERYTRNRQ = new CBECPAYNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECPAYNOTICEQUERYTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddDays(-80),
                        ENDDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.10	收汇通知查询
        /// </summary>
        public static void CBECINNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECINNOTICEQUERYTRNRQ, V1_CBECINNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECINNOTICEQUERYTRNRQ
            {
                CBECINNOTICEQUERYTRNRQ = new CBECINNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECINNOTICEQUERYTRN_RQBODY
                    {
                        BEGINDATE = DateTime.Now.AddDays(-80),
                        ENDDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.18.11	收付汇还原申报
        /// </summary>
        public static void CBECTRANSFERDECLARETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.18.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBECTRANSFERDECLARETRNRQ, V1_CBECTRANSFERDECLARETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBECTRANSFERDECLARETRNRQ
            {
                CBECTRANSFERDECLARETRNRQ = new CBECTRANSFERDECLARETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBECTRANSFERDECLARETRN_RQBODY
                    {
                        BATCH_NUM = "2",
                        CURR_BATCH_SEQ = "1",
                        FIRST_BATCH_REFNO = "wengq001",
                        CURRENCY = "01",

                        BRANCH_NO = "11701",
                        BLNC_PYMT_NO = "3500000014001604220001",
                        DATA_TYPE = "DBD",
                        BACK_TRACKING = "N",
                        List = new List<CBECTRANSFERDECLARETRN_CONTENT>
                        {
                            new CBECTRANSFERDECLARETRN_CONTENT{
                                SEQ=1,
                                PAYEE_TYPE="C",
                                FIRM_CODE="87636234-2",
                                PAYEE_NAME="ZONGXIN 新中",
                                REMITTER_NAME="(JW)zhengxiaohai",
                                REMIT_AMOUNT=1000,
                                EXCHNG_RATE=0.23m,
                                EXCHNG_AMT=1000,
                                CASH_ACCT_NO="117011400100081792",
                                SETTLE_WAY="L",
                                RCPT_PYMT_TYPE="A",
                                TRADE_CODE_1="121010",
                                AMOUNT_1=800,
                                MEMO_1="MEMO_1",
                                TRADE_CODE_2="121020",
                                AMOUNT_2=200,
                                MEMO_2="MEMO_2",
                                IS_BONDED="N",
                                EXCHNG_TYPE="M",
                                APPLY_NAME="WENG",
                                APPLY_TEL="124578965",
                                APPLY_DATE=DateTime.Now,
                                TRADE_TYPE="M",
                            }
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.19	跨境资金池
        /// <summary>
        /// 3.19.1	资金调拨
        /// </summary>
        public static void CBCPALLOCATETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPALLOCATETRNRQ, V1_CBCPALLOCATETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPALLOCATETRNRQ
            {
                CBCPALLOCATETRNRQ = new CBCPALLOCATETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPALLOCATETRN_RQBODY
                    {
                        MAINACCTNO = mainAccountId,
                        MEMACCTNO = "117010100100050880",
                        ALLOCDIRECTION = 1,
                        AMOUNT = 1000,
                        CURRENCY = "01",
                        PURPOSE = "资金调拨PURPOSE",
                        MEMO = "资金调拨MEMO",
                        DTDUE = DateTime.Now,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.2	利息分配
        /// </summary>
        public static void CBCPINTERESTADJUSTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPINTERESTADJUSTTRNRQ, V1_CBCPINTERESTADJUSTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPINTERESTADJUSTTRNRQ
            {
                CBCPINTERESTADJUSTTRNRQ = new CBCPINTERESTADJUSTTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPINTERESTADJUSTTRN_RQBODY
                    {
                        MAINACCTNO = mainAccountId,
                        MEMACCTNO = "117010100100050880",
                        TOTALUPSCORE = 10000,
                        UPRATIO = 9,
                        ADJUSTUPINTEREST = 12,
                        TOTALDOWNSCORE = 0,
                        DOWNRATIO = 5,
                        ADJUSTDOWNINTEREST = 0,
                        CURRENCY = "01",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.3	利息查询
        /// </summary>
        public static void CBCPINTRSTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPINTRSTQUERYTRNRQ, V1_CBCPINTRSTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPINTRSTQUERYTRNRQ
            {
                CBCPINTRSTQUERYTRNRQ = new CBCPINTRSTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPINTRSTQUERYTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.4	集中结汇
        /// </summary>
        public static void CBCPEXCHNGTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPEXCHNGTRNRQ, V1_CBCPEXCHNGTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPEXCHNGTRNRQ
            {
                CBCPEXCHNGTRNRQ = new CBCPEXCHNGTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPEXCHNGTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                        RMBACCTNO = "117010100100050880",
                        RMBACCTNAME = "test",
                        AMOUNT = 1000,
                        CURRENCY = "14",
                        EXCHNGTYPE = 0,
                        EXCHNGCODE = "11001",
                        TRANSNO = "121010",
                        MEMO = "集中结汇MEMO",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.5	集中结汇交易明细查询
        /// </summary>
        public static void CBCPEXCHNGTRADEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPEXCHNGTRADEQUERYTRNRQ, V1_CBCPEXCHNGTRADEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPEXCHNGTRADEQUERYTRNRQ
            {
                CBCPEXCHNGTRADEQUERYTRNRQ = new CBCPEXCHNGTRADEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPEXCHNGTRADEQUERYTRN_RQBODY
                    {
                        ACCTNO=mainAccountId,
                        STARTDATE = DateTime.Now.AddMonths(-2),
                        ENDDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.6	集中收付汇
        /// </summary>
        public static void CBCPTRANSFERTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPTRANSFERTRNRQ, V1_CBCPTRANSFERTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPTRANSFERTRNRQ
            {
                CBCPTRANSFERTRNRQ = new CBCPTRANSFERTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPTRANSFERTRN_RQBODY
                    {
                        REMITWAY = "T",
                        REMITTYPE = "O",
                        REMITTERTYPE = "C",
                        REMITTERACCTNO = mainAccountId + "666666",
                        TOACCTNO = "6222021202008454721",
                        TOACCTBANE = "葛吉利",
                        TOBANKCODE = "CITIUS33XXX",
                        TOBANKNAME = "CITIBANK N.A.111 WALL STREET",
                        CURRENTCY = "14",
                        REMITAMOUNT = 1000,
                        REMITMEMO = "集中收付汇REMITMEMO",
                        COUNTRYCODE = "AGO",
                        TRADECODE1 = "121010",
                        CURRENCY1 = "",
                        AMOUNT1 = 800,
                        AMOUNT2 = 200,
                        MEMO1 = "集中收付汇 MEMO1",
                        SETTLE_WAY = "T",
                        PAYTYPE = "O",
                        ISBONDED = "N",
                        CONTRATENO = "201609090005",
                        BILLNO = "201609090005",
                        APPLYNAME = "WENGQ",
                        APPLYTEL = "15860003216",
                        BEAREXPENSES = "SHA",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.7	成员账号信息查询
        /// </summary>
        public static void CBCPMEMACCTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMEMACCTQUERYTRNRQ, V1_CBCPMEMACCTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMEMACCTQUERYTRNRQ
            {
                CBCPMEMACCTQUERYTRNRQ = new CBCPMEMACCTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMEMACCTQUERYTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.8	国内主账户信息查询
        /// </summary>
        public static void CBCPMAINACCTQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMAINACCTQUERYTRNRQ, V1_CBCPMAINACCTQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMAINACCTQUERYTRNRQ
            {
                CBCPMAINACCTQUERYTRNRQ = new CBCPMAINACCTQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMAINACCTQUERYTRN_RQBODY
                    {
                        CURRENCY = "14"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.9	账户交易明细查询
        /// </summary>
        public static void CBCPTRADEDETAILQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPTRADEDETAILQUERYTRNRQ, V1_CBCPTRADEDETAILQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPTRADEDETAILQUERYTRNRQ
            {
                CBCPTRADEDETAILQUERYTRNRQ = new CBCPTRADEDETAILQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPTRADEDETAILQUERYTRN_RQBODY
                    {
                        TRADETYPE = 0,
                        CURRENCY = "14",
                        ACCTNO = mainAccountId,
                        STARTDATE = DateTime.Now.AddMonths(-2),
                        ENDDATE = DateTime.Now.AddDays(-1),
                        DCDIRECTOR = 1,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.10	成员单位子账号交易明细查询
        /// </summary>
        public static void CBCPMEMTRADEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMEMTRADEQUERYTRNRQ, V1_CBCPMEMTRADEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMEMTRADEQUERYTRNRQ
            {
                CBCPMEMTRADEQUERYTRNRQ = new CBCPMEMTRADEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMEMTRADEQUERYTRN_RQBODY
                    {
                        TRADETYPE = 1,
                        CURRENCY = "14",
                        MAINACCTNO = mainAccountId,
                        SEQNO = "000002",
                        STARTDATE = DateTime.Now.AddMonths(-2),
                        ENDDATE = DateTime.Now.AddDays(-1),
                        DCDIRECTOR = 1,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.11	账户资金池属性查询
        /// </summary>
        public static void CBCPACCTCFGQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.11", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPACCTCFGQUERYTRNRQ, V1_CBCPACCTCFGQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPACCTCFGQUERYTRNRQ
            {
                CBCPACCTCFGQUERYTRNRQ = new CBCPACCTCFGQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPACCTCFGQUERYTRN_RQBODY
                    {
                        ACCTNO = mainAccountId,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.12	国内成员资金调拨
        /// </summary>
        public static void CBCPMEMALLOCATETRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.12", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMEMALLOCATETRNRQ, V1_CBCPMEMALLOCATETRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMEMALLOCATETRNRQ
            {
                CBCPMEMALLOCATETRNRQ = new CBCPMEMALLOCATETRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMEMALLOCATETRN_RQBODY
                    {
                        FROMACCTNO = mainAccountId + "000001",
                        TOACCTNO = "117011400100093302000002",
                        AMOUNT = 1000,
                        PURPOSE = "国内成员资金调拨PURPOSE",
                        MEMO = "国内成员资金调拨MEMO",
                        DTDUE = DateTime.Now.Date,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.13	国内、国际主账户互转
        /// </summary>
        public static void CBCPMAINTRSFRTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.13", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMAINTRSFRTRNRQ, V1_CBCPMAINTRSFRTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMAINTRSFRTRNRQ
            {
                CBCPMAINTRSFRTRNRQ = new CBCPMAINTRSFRTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMAINTRSFRTRN_RQBODY
                    {
                        TRADETYPE = 1,
                        CURRENCY = "14",
                        AMOUNT = 1000,
                        APPROVEDDOCNO = "20160906134900001",
                        DEBTORNAME = "zwr",
                        DEBTORCOUNTRYCODE = "CHN",
                        CREDITORNAME = "zqr",
                        CREDITORCOUNTRYCODE = "Z01",
                        DTDUE = DateTime.Now.Date,
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.19.14	国内、国际主账户互转交易查询
        /// </summary>
        public static void CBCPMAINTRADEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.19.14", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_CBCPMAINTRADEQUERYTRNRQ, V1_CBCPMAINTRADEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_CBCPMAINTRADEQUERYTRNRQ
            {
                CBCPMAINTRADEQUERYTRNRQ = new CBCPMAINTRADEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new CBCPMAINTRADEQUERYTRN_RQBODY
                    {
                        QUERYTYPE = 1,
                        MAINACCTNO = mainAccountId,
                        SETTLESTATUS = 1,
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1),
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.20	信用证
        /// <summary>
        /// 3.20.1	进口信用证开立
        /// </summary>
        public static void LCOPENAPPLYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCOPENAPPLYTRNRQ, V1_LCOPENAPPLYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCOPENAPPLYTRNRQ
            {
                LCOPENAPPLYTRNRQ = new LCOPENAPPLYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCOPENAPPLYTRN_RQBODY
                    {
                        LCFORMTYPE = "I",
                        NOMINALAMTCURR = "CNY",
                        NOMINALAMT = 5000,
                        INITIALCODE = "11701",
                        LCISSUEDDATE = DateTime.Now.AddDays(1),
                        LCEXPIRYDATE = DateTime.Now.AddMonths(1),
                        EXPIRYPLACE = "China",
                        TENOR = "Usance",
                        APPLICABLERULES = "UCP LATEST VERSION",
                        CONTRACTNO = "CNO1234567890123",
                        CONTRACTAMT = 10000,
                        APPLICANT = "APPLICANT FUZHOU IMP. N EXP. CO.,LTD  QQQQQQQQQQQQQQQQQQQQQQ   TEL:0000-88888888   FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        ADVISINGBANK = "NOSCINBBCJB       BANK OF NOVA SCOTIA,COIMBATORE.",
                        BENEFICIARY = "BENEFICIARY FUZHOU IMP. N EXP. CO.,LTD   QQQQQQQQQQQQQQQQQQQQQQ   TEL:0000-88888888   FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        CONFIRMINSTRCTION = "A",
                        AVBLWITHBANK = "A",
                        AVBLPYMTWAY = "A",
                        COUNTRYCODE = "USA",
                        PATIALSHIPMENT = "Y",
                        TRANSSHIPMENT = "Y",
                        GOODSDESC = "Goods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMWGoods car for BMW",
                        DOCUMENTS = "Documents 1/INVOICE IN TRIPLICATE. 2/BILLS OF LADING IN 3 ORIGINALS AND 3 COPIES. 3/INSURANCE POLICY IN 2 ORIGINALS",
                        ADDCONDITIONS = "additional conditions 1/COPIES NOT ALLOWED. 2/LATE SHIPMENT NOT ALLOWED.",
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.2	进口信用证修改
        /// </summary>
        public static void LCAMENDAPPLYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCAMENDAPPLYTRNRQ, V1_LCAMENDAPPLYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCAMENDAPPLYTRNRQ
            {
                LCAMENDAPPLYTRNRQ = new LCAMENDAPPLYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCAMENDAPPLYTRN_RQBODY
                    {
                        BRANCHNO = "11701",
                        LCREFNO = "08101LC16000087F",
                        APPLICANT = "APPLICANT FUZHOU IMP. N EXP. CO.,LTD   QQQQQQQQQQQQQQQQQQQQQQ     TEL:0000-88888888   FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        BENEFICIARY = "BENEFICIARY FUZHOU IMP. N EXP. CO.,LTD  QQQQQQQQQQQQQQQQQQQQQQ  TEL:0000-88888888  FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        APPLYDTL = "进口信用证修改申请",
                        COMMENT = "进口信用证修改测试",
                        APPLYDATE = DateTime.Now
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.3	进口信用证付款承兑拒付申请
        /// </summary>
        public static void LCPAYAPPLYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.3", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCPAYAPPLYTRNRQ, V1_LCPAYAPPLYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCPAYAPPLYTRNRQ
            {
                LCPAYAPPLYTRNRQ = new LCPAYAPPLYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCPAYAPPLYTRN_RQBODY
                    {
                        BRANCHNO = "11701",
                        LCREFNO = "08101LC16000029C",
                        BPREFNO = "08101IB16000022C",
                        APPLICANT = "APPLICANT FUZHOU IMP. N EXP. CO.,LTD   QQQQQQQQQQQQQQQQQQQQQQ     TEL:0000-88888888   FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        BENEFICIARY = "BENEFICIARY FUZHOU IMP. N EXP. CO.,LTD  QQQQQQQQQQQQQQQQQQQQQQ  TEL:0000-88888888  FAX:QQQQQQQQQQQQQQQQQQQQQQQQQ",
                        DOCAMT = 1000,
                        ACTUALAMT = 1000,
                        CONTRACTNO = "",
                        LCBPPROCESS = 1,
                        COMMENT = "进口信用证付款承兑拒付申请测试",
                        APPLYDATE = DateTime.Now
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.4	进口信用证开立通知查询
        /// </summary>
        public static void LCOPENNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.4", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCOPENNOTICEQUERYTRNRQ, V1_LCOPENNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCOPENNOTICEQUERYTRNRQ
            {
                LCOPENNOTICEQUERYTRNRQ = new LCOPENNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCOPENNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.5	进口信用证修改通知查询
        /// </summary>
        public static void LCAMENDNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.5", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCAMENDNOTICEQUERYTRNRQ, V1_LCAMENDNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCAMENDNOTICEQUERYTRNRQ
            {
                LCAMENDNOTICEQUERYTRNRQ = new LCAMENDNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCAMENDNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.6	进口信用证到单通知查询
        /// </summary>
        public static void LCLITDCKNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.6", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCLITDCKNOTICEQUERYTRNRQ, V1_LCLITDCKNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCLITDCKNOTICEQUERYTRNRQ
            {
                LCLITDCKNOTICEQUERYTRNRQ = new LCLITDCKNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCAMENDNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.7	进口信用证拒付通知查询
        /// </summary>
        public static void LCREJECTNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.7", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCREJECTNOTICEQUERYTRNRQ, V1_LCREJECTNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCREJECTNOTICEQUERYTRNRQ
            {
                LCREJECTNOTICEQUERYTRNRQ = new LCREJECTNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCREJECTNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.8	进口信用证承兑通知查询
        /// </summary>
        public static void LCACCEPTNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.8", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCACCEPTNOTICEQUERYTRNRQ, V1_LCACCEPTNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCACCEPTNOTICEQUERYTRNRQ
            {
                LCACCEPTNOTICEQUERYTRNRQ = new LCACCEPTNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCACCEPTNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.9	进口信用证即期付款/远期付款通知查询
        /// </summary>
        public static void LCPAYNOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.9", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCPAYNOTICEQUERYTRNRQ, V1_LCPAYNOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCPAYNOTICEQUERYTRNRQ
            {
                LCPAYNOTICEQUERYTRNRQ = new LCPAYNOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCPAYNOTICEQUERYTRN_RQBODY
                    {
                        QUERYTYPE = 1,
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.20.10	出口信用证来证通知查询
        /// </summary>
        public static void LCCOMENOTICEQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.20.10", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_LCCOMENOTICEQUERYTRNRQ, V1_LCCOMENOTICEQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_LCCOMENOTICEQUERYTRNRQ
            {
                LCCOMENOTICEQUERYTRNRQ = new LCCOMENOTICEQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new LCOPENNOTICEQUERYTRN_RQBODY
                    {
                        STARTDATE = DateTime.Now.AddMonths(-3),
                        ENDDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.21	电子回单
        /// <summary>
        /// 3.21.1	生成电子回单
        /// </summary>
        public static void ELECTRONICRECEIPTTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.21.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ELECTRONICRECEIPTTRNRQ, V1_ELECTRONICRECEIPTTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ELECTRONICRECEIPTTRNRQ
            {
                ELECTRONICRECEIPTTRNRQ = new ELECTRONICRECEIPTTRNRQ
                {
                    TRNUID = "20190305135650_3.21.1",//
                    RQBODY = new ELECTRONICRECEIPTTRN_RQBODY
                    {
                        RECEIPT_TYPE = "01",
                        ACCTID = mainAccountId,
                        RECEIPTDATE = DateTime.Now.AddDays(-1)
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.21.2	同步电子回单
        /// </summary>
        public static void ASYNRECEIPTINFOTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.21.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_ASYNRECEIPTINFOTRNRQ, V1_ASYNRECEIPTINFOTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_ASYNRECEIPTINFOTRNRQ
            {
                ASYNRECEIPTINFOTRNRQ = new ASYNRECEIPTINFOTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new ASYNRECEIPTINFOTRN_RQBODY
                    {
                        CLT_REF_NO = "20190305135650_3.21.1"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion

        #region 3.23	批量余额对账
        /// <summary>
        /// 3.23.1	生成批量余额对账指令
        /// </summary>
        public static void BATCHCHECKTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.23.1", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BATCHCHECKTRNRQ, V1_BATCHCHECKTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BATCHCHECKTRNRQ
            {
                BATCHCHECKTRNRQ = new BATCHCHECKTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new BATCHCHECKTRN_RQBODY
                    {
                        RECONCILEDATE = "201902"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        /// <summary>
        /// 3.23.2	查询批量余额对账指令
        /// </summary>
        public static void BATCHCHECKQUERYTRNRQSample()
        {
            string tid = string.Format("{0:yyyyMMddHHmmss}_3.23.2", DateTime.Now);
            var rq = GetRequest<FOXRQ<V1_BATCHCHECKQUERYTRNRQ, V1_BATCHCHECKQUERYTRNRS>>();
            rq.SECURITIES_MSGSRQV1 = new V1_BATCHCHECKQUERYTRNRQ
            {
                BATCHCHECKQUERYTRNRQ = new BATCHCHECKQUERYTRNRQ
                {
                    TRNUID = tid,
                    RQBODY = new BATCHCHECKQUERYTRN_RQBODY
                    {
                         CLT_REF_NO = "20190305134728_3.23.1"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs.ResponseContent);
        }
        #endregion
    }
}
