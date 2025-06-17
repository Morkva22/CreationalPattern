using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Builder
{
    public class GamingPCBuilder : Builder<string>
    {
        public GamingPCBuilder()
        {
            product = new GamingProduct();
        }
        
        public override string InstallCPU()
        {
            GetActionInfo("Install CPU: ", "Intel Core i9-13900K");
            product.AddPart("Intel Core i9-13900K");
            return "Intel Core i9-13900K";
        }
        
        public override string InstallRAM()
        {
            GetActionInfo("Install RAM: ", "32GB DDR5-6000");
            product.AddPart("32GB DDR5-6000");
            return "32GB DDR5-6000";
        }
        
        public override string InstallGPU()
        {
            GetActionInfo("Install GPU: ", "RTX 4090");
            product.AddPart("RTX 4090");
            return "RTX 4090";
        }
        
        public override string InstallStorage()
        {
            GetActionInfo("Install Storage: ", "2TB NVMe SSD");
            product.AddPart("2TB NVMe SSD");
            return "2TB NVMe SSD";
        }
        
        public override string InstallPowerSupply()
        {
            GetActionInfo("Install Power Supply: ", "1000W 80+ Gold PSU");
            product.AddPart("1000W 80+ Gold PSU");
            return "1000W 80+ Gold PSU";
        }
        
        public override string InstallCooling()
        {
            GetActionInfo("Install Cooling: ", "AIO Liquid Cooler");
            product.AddPart("AIO Liquid Cooler");
            return "AIO Liquid Cooler";
        }
        
        public override string RemoveCPU()
        {
            GetActionInfo("Remove CPU: ", "Intel Core i9-13900K");
            product.RemovePart("Intel Core i9-13900K");
            return "Intel Core i9-13900K";
        }
        
        public override string RemoveRAM()
        {
            GetActionInfo("Remove RAM: ", "32GB DDR5-6000");
            product.RemovePart("32GB DDR5-6000");
            return "32GB DDR5-6000";
        }
        
        public override string RemoveGPU()
        {
            GetActionInfo("Remove GPU: ", "RTX 4090");
            product.RemovePart("RTX 4090");
            return "RTX 4090";
        }
        
        public override string RemoveStorage()
        {
            GetActionInfo("Remove Storage: ", "2TB NVMe SSD");
            product.RemovePart("2TB NVMe SSD");
            return "2TB NVMe SSD";
        }
        
        public override string RemovePowerSupply()
        {
            GetActionInfo("Remove Power Supply: ", "1000W 80+ Gold PSU");
            product.RemovePart("1000W 80+ Gold PSU");
            return "1000W 80+ Gold PSU";
        }
        
        public override string RemoveCooling()
        {
            GetActionInfo("Remove Cooling: ", "AIO Liquid Cooler");
            product.RemovePart("AIO Liquid Cooler");
            return "AIO Liquid Cooler";
        }
    }
    
    public class OfficePCBuilder : Builder<string>
    {
        public OfficePCBuilder()
        {
            product = new OfficeProduct();
        }
        
        public override string InstallCPU()
        {
            GetActionInfo("Install CPU: ", "Intel Core i5-13400");
            product.AddPart("Intel Core i5-13400");
            return "Intel Core i5-13400";
        }
        
        public override string InstallRAM()
        {
            GetActionInfo("Install RAM: ", "16GB DDR4-3200");
            product.AddPart("16GB DDR4-3200");
            return "16GB DDR4-3200";
        }
        
        public override string InstallGPU()
        {
            GetActionInfo("Install GPU: ", "Integrated Graphics");
            product.AddPart("Integrated Graphics");
            return "Integrated Graphics";
        }
        
        public override string InstallStorage()
        {
            GetActionInfo("Install Storage: ", "512GB SATA SSD");
            product.AddPart("512GB SATA SSD");
            return "512GB SATA SSD";
        }
        
        public override string InstallPowerSupply()
        {
            GetActionInfo("Install Power Supply: ", "450W 80+ Bronze PSU");
            product.AddPart("450W 80+ Bronze PSU");
            return "450W 80+ Bronze PSU";
        }
        
        public override string InstallCooling()
        {
            GetActionInfo("Install Cooling: ", "Stock CPU Cooler");
            product.AddPart("Stock CPU Cooler");
            return "Stock CPU Cooler";
        }
        
        public override string RemoveCPU()
        {
            GetActionInfo("Remove CPU: ", "Intel Core i5-13400");
            product.RemovePart("Intel Core i5-13400");
            return "Intel Core i5-13400";
        }
        
        public override string RemoveRAM()
        {
            GetActionInfo("Remove RAM: ", "16GB DDR4-3200");
            product.RemovePart("16GB DDR4-3200");
            return "16GB DDR4-3200";
        }
        
        public override string RemoveGPU()
        {
            GetActionInfo("Remove GPU: ", "Integrated Graphics");
            product.RemovePart("Integrated Graphics");
            return "Integrated Graphics";
        }
        
        public override string RemoveStorage()
        {
            GetActionInfo("Remove Storage: ", "512GB SATA SSD");
            product.RemovePart("512GB SATA SSD");
            return "512GB SATA SSD";
        }
        
        public override string RemovePowerSupply()
        {
            GetActionInfo("Remove Power Supply: ", "450W 80+ Bronze PSU");
            product.RemovePart("450W 80+ Bronze PSU");
            return "450W 80+ Bronze PSU";
        }
        
        public override string RemoveCooling()
        {
            GetActionInfo("Remove Cooling: ", "Stock CPU Cooler");
            product.RemovePart("Stock CPU Cooler");
            return "Stock CPU Cooler";
        }
    }
}
