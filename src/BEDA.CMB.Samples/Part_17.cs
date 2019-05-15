using BEDA.CMB.Contracts.Requests;
using BEDA.CMB.Contracts.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BEDA.CMB.Samples
{
    partial class Program
    {
        static void Part_17()
        {
            //RQ17_1Sample(); //test
            //RQ17_2Sample(); //test
            //RQ17_3Sample(); //test
            //RQ17_4Sample(); //test
            //RQ17_5Sample(); //test
            //RQ17_6Sample(); //test
            //RQ17_7Sample(); //test
            //RQ17_8Sample(); //test
            //RQ17_9Sample(); //test
            //RQ17_10Sample(); //test
            //RQ17_11Sample(); //test
            //RQ17_12Sample(); //test
            //RQ17_13Sample(); //test
            //RQ17_14Sample(); //test
            //RQ17_15Sample(); //test
            //RQ17_16Sample(); //test
            //RQ17_17Sample(); //test
            //RQ17_18Sample(); //test
            //RQ17_19Sample(); //test
            //RQ17_20Sample(); //test
            //RQ17_21Sample(); //test
            //RQ17_22Sample(); //test
            //RQ17_23Sample(); //test
            //RQ17_24Sample(); //test
            //RQ17_25Sample(); //test
            //RQ17_26Sample(); //test
            //RQ17_27Sample(); //test
            //RQ17_28Sample(); //test
            //RQ17_29Sample(); //test
            //RQ17_30Sample(); //test
        }

        #region 17.记账宝
        /// <summary>
        /// 17.1.查询记账宝帐号列表
        /// </summary>
        public static void RQ17_1Sample()
        {
            var rq = new RQ17_1()
            {
                NTDMACTLX = new NTDMACTLX
                {
                }
            };
            var rs = client.Execute<RQ17_1, RS17_1>(rq, "银企直连测试用户110");
            var txt = string.Join(",", rs.List.Select(x => x.ACCNBR)); //755915712310502,755915712310607,755915712310806
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.2.查询虚拟户信息
        /// </summary>
        public static void RQ17_2Sample()
        {
            var rq = new RQ17_2()
            {
                NTDMALSTX = new NTDMALSTX
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_2, RS17_2>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.3.新增虚拟户
        /// </summary>
        public static void RQ17_3Sample()
        {
            var rq = new RQ17_3()
            {
                NTDMAADDX = new NTDMAADDX
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9911334455",
                    DMANAM = "BEDA测试创建01",
                }
            };
            var rs = client.Execute<RQ17_3, RS17_3>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.4.关闭虚拟户
        /// </summary>
        public static void RQ17_4Sample()
        {
            var rq = new RQ17_4()
            {
                NTDMADLTX1 = new NTDMADLTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTDMADLTX2>
                {
                    new NTDMADLTX2
                    {
                        DMANBR="9911334455"
                    }
                }
            };
            var rs = client.Execute<RQ17_4, RS17_4>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.5.记账宝交易查询
        /// </summary>
        public static void RQ17_5Sample()
        {
            for (var i = 7; i < 9; i++)
            {
                var dt = DateTime.Now.AddMonths(-i);
                var rq = new RQ17_5()
                {
                    NTDTHQRYY = new NTDTHQRYY
                    {
                        ACCNBR = "755915712310806",
                        QRYFLG = "2",
                        BEGDAT = dt,
                        ENDDAT = dt.AddDays(1),
                    }
                };
                var rs = client.Execute<RQ17_5, RS17_5>(rq, "银企直连测试用户110");
                if (rs.INFO.RETCOD == "0")
                {//i为7和8时有返回值
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
            }
        }
        /// <summary>
        /// 17.6.手工记账
        /// </summary>
        public static void RQ17_6Sample()
        {
            var rq = new RQ17_6()
            {
                NTHKPACTX1 = new NTHKPACTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "1804120002",
                },
                List = new List<NTHKPACTX2>
                {
                    new NTHKPACTX2
                    {
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000000000021",
                    }
                }
            };
            var rs = client.Execute<RQ17_6, RS17_6>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.7.虚拟户冲账
        /// </summary>
        public static void RQ17_7Sample()
        {
            var rq = new RQ17_7()
            {
                NTHCLACTX1 = new NTHCLACTX1
                {
                    ACCNBR = "755915712310806",
                },
                List = new List<NTHCLACTX2>
                {
                    new NTHCLACTX2
                    {
                        DMANBR = "1804120002",
                        TRXDAT=new DateTime(2018,8,1),
                        TRXNBR="TX0000001000001",
                    }
                }
            };
            var rs = client.Execute<RQ17_7, RS17_7>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.8.查询虚拟户当天交易
        /// </summary>
        public static void RQ17_8Sample()
        {
            var rq = new RQ17_8()
            {
                NTDMTLSTY = new NTDMTLSTY
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_8, RS17_8>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.9.查询虚拟户历史交易
        /// </summary>
        public static void RQ17_9Sample()
        {
            for (var i = 7; i < 17; i++)
            {
                var rq = new RQ17_9()
                {
                    NTDMTHLSY = new NTDMTHLSY
                    {
                        ACCNBR = "755915712310806",
                        BEGDAT = DateTime.Now.AddMonths(-i - 1),
                        ENDDAT = DateTime.Now.AddMonths(-i).AddDays(-1)
                    }
                };
                var rs = client.Execute<RQ17_9, RS17_9>(rq, "银企直连测试用户110");
                if (rs.List?.Count > 0)
                {
                    Console.WriteLine(rs.INFO.ResponseContent);
                }
            }
        }
        /// <summary>
        /// 17.10.查询虚拟户余额和当月积数
        /// </summary>
        public static void RQ17_10Sample()
        {
            var rq = new RQ17_10()
            {
                NTDMABALX = new NTDMABALX
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_10, RS17_10>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.11.查询虚拟户历史月积数
        /// </summary>
        public static void RQ17_11Sample()
        {
            var rq = new RQ17_11()
            {
                NTMTHAUBX = new NTMTHAUBX
                {
                    ACCNBR = "755915712310806",
                    BEGMTH = DateTime.Now.AddMonths(-10).ToString("yyyyMM"),
                    ENDMTH = DateTime.Now.AddMonths(-9).ToString("yyyyMM"),
                }
            };
            var rs = client.Execute<RQ17_11, RS17_11>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.12.虚拟户利息试算
        /// </summary>
        public static void RQ17_12Sample()
        {
            var rq = new RQ17_12()
            {
                NTDMAINTX1 = new NTDMAINTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9874545148",
                    PRDTYP = "Q",
                    PRDYER = 2018,
                    PRDNBR = 1,
                    INTRAT = 3.15m
                }
            };
            var rs = client.Execute<RQ17_12, RS17_12>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.13.虚拟户内部转账
        /// </summary>
        public static void RQ17_13Sample()
        {
            var rq = new RQ17_13()
            {
                NTDMATRXX1 = new NTDMATRXX1
                {
                    ACCNBR = "755915712310806",
                    DMADBT = "9874545148",
                    DMACRT = "8199991567",
                    TRXAMT = 0.01m,
                    TRXTXT = "虚拟户内部转账",
                }
            };
            var rs = client.Execute<RQ17_13, RS17_13>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
            // 9874545148  TX0000000015215  2018-10-31
            // 8199991567  TX0000000015216  2018-10-31
        }
        /// <summary>
        /// 17.14.批量新增虚拟户
        /// </summary>
        public static void RQ17_14Sample()
        {
            var rq = new RQ17_14()
            {
                NTDMABADX1 = new NTDMABADX1
                {
                    OPRCOD = "D",
                    ACCNBR = "755915712310806",
                    BEGDMA = "9000010001",
                    ENDDMA = "9000010002",
                    DMAFIX = "FKB",
                },
                List = new List<NTDMABADX2>
                {
                }
            };
            var rs = client.Execute<RQ17_14, RS17_14>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.15.查询虚拟户关联公司卡列表
        /// </summary>
        public static void RQ17_15Sample()
        {
            var rq = new RQ17_15()
            {
                NTDCDRLTX1 = new NTDCDRLTX1
                {
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_15, RS17_15>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.16.设置虚拟户关联公司卡
        /// </summary>
        public static void RQ17_16Sample()
        {
            var rq = new RQ17_16()
            {
                NTDCDADDX1 = new NTDCDADDX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR= "9874545148",
                },
                List = new List<NTDCDADDX2>
                {
                    new NTDCDADDX2
                    {
                        CDSNBR ="6225985910200810"
                    }
                }
            };
            var rs = client.Execute<RQ17_16, RS17_16>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.17.虚拟户解除公司卡关联
        /// </summary>
        public static void RQ17_17Sample()
        {
            var rq = new RQ17_17()
            {
                NTDCDDLTX1 = new NTDCDDLTX1
                {
                    ACCNBR = "755915712310806",
                    DMANBR = "9874545148",
                },
                List = new List<NTDCDDLTX2>
                {
                    new NTDCDDLTX2
                    {
                        CDSNBR ="6225985910200810"
                    }
                }
            };
            var rs = client.Execute<RQ17_17, RS17_17>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.18.流水号查询虚拟户交易信息
        /// </summary>
        public static void RQ17_18Sample()
        {
            var rq = new RQ17_18()
            {
                NTDMTQR2X1 = new NTDMTQR2X1
                {
                    BBKNBR="75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    TRSNBR= "TX0000000015216"
                }
            };
            var rs = client.Execute<RQ17_18, RS17_18>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
            // 9874545148  TX0000000015215  2018-10-31
            // 8199991567  TX0000000015216  2018-10-31
        }
        /// <summary>
        /// 17.19.修改虚拟户
        /// </summary>
        public static void RQ17_19Sample()
        {
            var rq = new RQ17_19()
            {
                NTDMAMNTX1 = new NTDMAMNTX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    DMANAM= "生打款账号公司5510",
                    OVRCTL = "Y"
                }
            };
            var rs = client.Execute<RQ17_19, RS17_19>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.20.设置虚拟户关联付款方信息
        /// </summary>
        public static void RQ17_20Sample()
        {
            var rq = new RQ17_20()
            {
                NTDMARLTX1 = new NTDMARLTX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    TLYOPR = "Y",
                    DBTACC= "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_20, RS17_20>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.21.修改虚拟户非关联付款方入账方式
        /// </summary>
        public static void RQ17_21Sample()
        {
            var rq = new RQ17_21()
            {
                NTDMATMNX1 = new NTDMATMNX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    TLYOPR = "N",
                }
            };
            var rs = client.Execute<RQ17_21, RS17_21>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.22.删除虚拟户关联付款方信息请求主体
        /// </summary>
        public static void RQ17_22Sample()
        {
            var rq = new RQ17_22()
            {
                NTDMARLDX1 = new NTDMARLDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    DBTACC = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_22, RS17_22>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.23.查询虚拟户关联付款方信息
        /// </summary>
        public static void RQ17_23Sample()
        {
            var rq = new RQ17_23()
            {
                NTDMARLQY1 = new NTDMARLQY1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                }
            };
            var rs = client.Execute<RQ17_23, RS17_23>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.24.查询虚拟户关联公司卡列表(续传)
        /// </summary>
        public static void RQ17_24Sample()
        {
            var rq = new RQ17_24()
            {
                NTDCDRLDX1 = new NTDCDRLDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                }
            };
            var rs = client.Execute<RQ17_24, RS17_24>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.25.单笔设置公司卡关联付方账号
        /// </summary>
        public static void RQ17_25Sample()
        {
            var rq = new RQ17_25()
            {
                NTDMDRADX1 = new NTDMDRADX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    CDSNBR = "6225985910200821",
                    TLYOPR = "N",
                    DBTACC= "755915712310806"
                }
            };
            var rs = client.Execute<RQ17_25, RS17_25>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.26.单笔设置公司卡非关联付方账号的入账方式
        /// </summary>
        public static void RQ17_26Sample()
        {
            var rq = new RQ17_26()
            {
                NTDMDRMDX1 = new NTDMDRMDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    CDSNBR = "6225985910200821",
                    TLYOPR = "N",
                }
            };
            var rs = client.Execute<RQ17_26, RS17_26>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.27.删除公司卡关联付款方信息请求报文说明请求主体
        /// </summary>
        public static void RQ17_27Sample()
        {
            var rq = new RQ17_27()
            {
                NTDMDRDDX1 = new NTDMDRDDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "8199991567",
                    CDSNBR = "6225985910200821",
                    DBTACC = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_27, RS17_27>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.28.查询公司卡关联付款方信息
        /// </summary>
        public static void RQ17_28Sample()
        {
            var rq = new RQ17_28()
            {
                NTDMDRQDX1 = new NTDMDRQDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                }
            };
            var rs = client.Execute<RQ17_28, RS17_28>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.29.查询所有虚拟户的某日余额
        /// </summary>
        public static void RQ17_29Sample()
        {
            var rq = new RQ17_29()
            {
                NTDMAHBDX1 = new NTDMAHBDX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    QRYDAT= DateTime.Now.AddDays(-200),
                    DMANBR= "1804240005",
                }
            };
            var rs = client.Execute<RQ17_29, RS17_29>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        /// <summary>
        /// 17.30.查询单个虚拟户的历史余额
        /// </summary>
        public static void RQ17_30Sample()
        {
            var rq = new RQ17_30()
            {
                NTDMAHADX1 = new NTDMAHADX1
                {
                    BBKNBR = "75",
                    ACCNBR = "755915712310806",
                    DMANBR = "1804240005",
                    BEGDAT = DateTime.Now.AddMonths(-12),
                    ENDDAT= DateTime.Now.AddMonths(-11),
                }
            };
            var rs = client.Execute<RQ17_30, RS17_30>(rq, "银企直连测试用户110");
            Console.WriteLine(rs.INFO.ResponseContent);
        }
        #endregion
    }
}
