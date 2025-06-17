using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AbstractFactory
{
    // Sofa products
    public interface ISofa
    {
        string SitOn();
        string Assemble();
        string Clean();
    }
    
    public abstract class Sofa : ISofa
    {
        public abstract string SitOn();
        public abstract string Assemble();
        public abstract string Clean();
    }
    
    public class IkeaSofa : Sofa
    {
        public override string SitOn()
        {
            return "Sitting on comfortable IKEA sofa with Swedish design";
        }
        
        public override string Assemble()
        {
            return "Assembling IKEA sofa with Allen key from instruction manual";
        }
        
        public override string Clean()
        {
            return "Cleaning IKEA sofa with removable fabric covers";
        }
    }
    
    public class AshleySofa : Sofa
    {
        public override string SitOn()
        {
            return "Sitting on luxurious Ashley leather sofa";
        }
        
        public override string Assemble()
        {
            return "Ashley sofa comes pre-assembled with professional delivery";
        }
        
        public override string Clean()
        {
            return "Cleaning Ashley leather sofa with special leather conditioner";
        }
    }
    
    public class WestElmSofa : Sofa
    {
        public override string SitOn()
        {
            return "Sitting on trendy West Elm mid-century modern sofa";
        }
        
        public override string Assemble()
        {
            return "Assembling West Elm sofa with premium hardware";
        }
        
        public override string Clean()
        {
            return "Cleaning West Elm sofa with eco-friendly fabric cleaner";
        }
    }
    
    public interface ITable
    {
        string Place();
        string Assemble();
        string Polish();
    }
    
    public abstract class Table : ITable
    {
        public abstract string Place();
        public abstract string Assemble();  
        public abstract string Polish();
    }
    
    public class IkeaTable : Table
    {
        public override string Place()
        {
            return "Placing items on IKEA minimalist dining table";
        }
        
        public override string Assemble()
        {
            return "Assembling IKEA table with cam lock fasteners";
        }
        
        public override string Polish()
        {
            return "Polishing IKEA table with wood oil finish";
        }
    }
    
    public class AshleyTable : Table
    {
        public override string Place()
        {
            return "Placing items on Ashley solid wood dining table";
        }
        
        public override string Assemble()
        {
            return "Ashley table delivered fully assembled by professionals";
        }
        
        public override string Polish()
        {
            return "Polishing Ashley table with premium furniture wax";
        }
    }
    
    public class WestElmTable : Table
    {
        public override string Place()
        {
            return "Placing items on West Elm industrial-style dining table";
        }
        
        public override string Assemble()
        {
            return "Assembling West Elm table with metal and wood components";
        }
        
        public override string Polish()
        {
            return "Polishing West Elm table with natural wood stain";
        }
    }
}