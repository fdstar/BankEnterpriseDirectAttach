using BEDA.CIB.Contracts;
using BEDA.CIB.Contracts.Requests;
using BEDA.CIB.Contracts.Responses;
using System;
using System.Collections.Generic;

namespace BEDA.CIB.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
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
            GATHERTRNRQSample();
            #endregion

            Console.ReadLine();
        }

        #region 基础数据
        const long cid = 1100343164;
        const string uid = "qw1";
        const string pwd = "a1111111";//密码错误6次账号会被永久锁定无法解锁
        static ICIBClient client = new CIBClient("127.0.0.1", 8007);

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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
                    SCUSTSTMTRQ = new SCUSTSTMTTRNRQ_SCUSTSTMTRQ
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
            Console.WriteLine(rs?.ResponseContent);
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
                    RQBODY = new BALNTRADEIN_RQBODY
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
                    SCUSTSTMTRQ = new FSTMTTRNRQ_SCUSTSTMTRQ
                    {
                        ACCTFROM = new ACCTFROM
                        {
                            ACCTID = mainAccountId
                        },
                        INCTRAN = new FSTMTTRNRQ_INCTRAN
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
                            PURPOSE = "转账",
                            TRNAMT = 1.77m,
                        }
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs?.ResponseContent);
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
                        CLIENTREF = "20190117114159_3.4.1"
                    }
                }
            };
            var rs = client.Execute(rq);
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
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
            Console.WriteLine(rs?.ResponseContent);
        }
        #endregion
    }
}
