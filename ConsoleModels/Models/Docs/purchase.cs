using ConsoleModels.Models.References;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models.Docs
{
    public class DocsBase
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsCompleted { get; set; }
    }

    public class PurchasRecordsGoods 
    {
        public int PurchasId { get; set; }
        public Good Good { get; set; }
        public Storeges Storege { get; set; }
        public Units Unit { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Summ { get; set; }
    }


    public class Purchases : DocsBase
    {
        public Storeges Storege  { get; set; }
        public Contragents Contragent { get; set; }

        public List<PurchasRecordsGoods> Goods { get; set; }



    }


}
