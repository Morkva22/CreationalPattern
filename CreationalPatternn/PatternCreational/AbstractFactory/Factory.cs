using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactory
{
    public interface IFurnitureFactory
    {
        ISofa CreateSofa();
        ITable CreateTable();
    }
    
    public abstract class FurnitureFactory : IFurnitureFactory
    {
        public abstract ISofa CreateSofa();
        public abstract ITable CreateTable();
    }
    
    class IkeaFactory : FurnitureFactory
    {
        public override ISofa CreateSofa()
        {
            return new IkeaSofa();
        }
        
        public override ITable CreateTable()
        {
            return new IkeaTable();
        }
    }
    
    class AshleyFactory : FurnitureFactory
    {
        public override ISofa CreateSofa()
        {
            return new AshleySofa();
        }
        
        public override ITable CreateTable()
        {
            return new AshleyTable();
        }
    }
    
    class WestElmFactory : FurnitureFactory
    {
        public override ISofa CreateSofa()
        {
            return new WestElmSofa();
        }
        
        public override ITable CreateTable()
        {
            return new WestElmTable();
        }
    }
}