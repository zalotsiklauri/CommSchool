using System;
namespace lecture12
{
    class artDecoChair : chair
    {

    }
    class artDecoSofa : sofa
    {

    }
    class artDecoCoffeeTable : coffeeTable
    {

    }
    class shl : factory
    {
        public override chair CreateChair()
        {
            return new artDecoChair();
        }
        public override sofa CreateSofa()
        {
            return new artDecoSofa();
        }
        public override coffeeTable CreateCoffeeTable()
        {
            return new artDecoCoffeeTable();
        }
    }
    public  class customer
    {
        private chair Chair;
        private sofa Sofa;
        private coffeeTable CoffeeTable;

        public customer (factory ss)
        {
            Chair = ss.CreateChair();
            Sofa = ss.CreateSofa();
            CoffeeTable = ss.CreateCoffeeTable();

        }
    }
    
}

    
