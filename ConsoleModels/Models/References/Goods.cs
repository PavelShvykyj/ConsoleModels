using ConsoleModels.Models.References;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models
{

    public enum Units
    {
        portion,
        piece,
        kilogramm,
        litr,
        gramm,
        mlitr
    }

    public enum GoodsType
    {
        Good,
        Semifinished,
        Finished,
        Service
    }

    public class RcordOfGoodConsist 
    {
        public Guid GoodID { get; set; }
        public virtual Goods Good { get; set; }
        public byte Id { get; set; }
        public Units Unit { get; set; }
        public int Brutto { get; set; }
        public int Netto { get; set; }
        public string Description { get; set; }
    }

    public class Goods : BaseReference<Goods>
    {
        public GoodsType GoodsType { get; set; }
        public Units UnitOfSale { get; set; }
        public Units UnitOfStore { get; set; }
        public Units UnitOfConsist { get; set; }
        public int QuantityOnConsist { get; set; }
        public IEnumerable<RcordOfGoodConsist> Consist { get; set; }
    }

}
